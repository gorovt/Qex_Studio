/*   Qex Studio License
*******************************************************************************
*                                                                             *
*    Copyright (c) 2017-2021 Luciano Gorosito <lucianogorosito@hotmail.com>   *
*                                                                             *
*    This file is part of Qex Studio                                          *
*                                                                             *
*    Qex Studio is free software: you can redistribute it and/or modify       *
*    it under the terms of the GNU General Public License as published by     *
*    the Free Software Foundation, either version 3 of the License, or        *
*    (at your option) any later version.                                      *
*                                                                             *
*    Qex Studio is distributed in the hope that it will be useful,            *
*    but WITHOUT ANY WARRANTY; without even the implied warranty of           *
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the            *
*    GNU General Public License for more details.                             *
*                                                                             *
*    You should have received a copy of the GNU General Public License        *
*    along with this program.  If not, see <https://www.gnu.org/licenses/>.   *
*                                                                             *
*******************************************************************************
*/

#region using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using Novacode;
using System.Data;
using System.ComponentModel;
using BrightIdeasSoftware;
using System.Xml.Serialization;
#endregion

namespace Qex
{
    public class Tools
    {
        public static string _title = "Qex Studio 1.3";
        public static string _status = "";
        //public static bool _isDemo = true;
        public static string _user = "";
        public static List<ConsumoRecurso> lstClipboardConsumos = new List<ConsumoRecurso>();
        public static List<WarningItem> _lstWarnings;
        //public static int _estadoLicencia = 1;
        // 3 casos de verificación de licencia
        // Caso 1: No existe licencia previa. Login
        // Caso 2: Existe login, y estamos dentro de la fecha. NO hace falta Login
        // Caso 3: Existe login, pero estamos fuera de la fecha. Borrar datos y Login
        //public static int _diasVerificacion = 7;
        public static byte[] _treeEstimateSave;
        public static int _treeDeep = 10;
        public static List<ItemPres> _cacheList;
        public static int _level = 2; // 1: Level 1 expanded - 2: All Expanded

        #region General
        public static List<string> ListaCategorias()
        {
            List<string> lst = new List<string>();
            lst.Add("Material");
            lst.Add("Trabajo");
            lst.Add("Equipo");
            return lst;
        }
        public static string wbsPlus(string wbs)
        {
            if (wbs.Length > 1)
            {
                int count = wbs.Length;
                string first = wbs.Remove(count - 2, 2);
                string last = wbs.Remove(0, count - 1);
                int number = Convert.ToInt32(last);
                number++;
                return first + "." + number.ToString();
            }
            else
            {
                return wbs + ".1";
            }
        }
        public static AnalisisItem createItemTotal(List<AnalisisItem> lst)
        {
            double costoMat = 0;
            double costoMo = 0;
            double costoEq = 0;
            foreach (AnalisisItem item in lst)
            {
                if (item.Category != "Grupo")
                {
                    costoMat += item.costoMaterial;
                    costoMo += item.costoManoObra;
                    costoEq += item.costoEquipos;
                }
            }
            double total = costoMat + costoMo + costoEq;

            AnalisisItem itemT = new AnalisisItem();
            itemT.nombre = "TOTAL";
            itemT.costoMaterial = costoMat;
            itemT.costoManoObra = costoMo;
            itemT.costoEquipos = costoEq;
            itemT.costoTotal = total;
            return itemT;
        }
        public static void CrearCarpetaInicial(string nombre)
        {
            if (!Proyecto.read().Exists(xx => xx.nombre == nombre))
            {
                Proyecto proy = new Proyecto(nombre, "", "");
                proy.insert();
            }
        }
        public static void AutoWbs(Presupuesto pres)
        {
            MouseWait();
            int countGroup = 1;
            foreach (var rubro in pres.getRubrosParent().OrderBy(x => x.orden).ThenBy(x => x.nombre))
            {
                rubro.orden = countGroup;
                rubro.update();
                countGroup++;
                rubro.WbsChild(rubro, rubro.orden);
            }
            MouseArrow();
        }
        public static void MouseWait()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
        }
        public static void MouseArrow()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
        }
        public static void FillOrdenFromTree(TreeListView tree)
        {
            MouseWait();
            for (int i = 0; i < tree.Items.Count; i++)
            {
                AnalisisItem item = (AnalisisItem)tree.GetModelObject(i);
                switch (item.Category)
                {
                    case "Presupuesto":
                        break;
                    case "Grupo":
                        RubroPres rubro = RubroPres.getByid(item.id);
                        rubro.orden = i;
                        rubro.update();
                        break;
                    case "Item":
                        TareaPres tarea = TareaPres.getById(item.id);
                        tarea.orden = i;
                        tarea.update();
                        break;
                }
            }
            MouseArrow();
        }
        #endregion
        #region Options
        public static void SetInitialOptions()
        {
            if (GrOptions.read().Count == 0)
            {
                //GrOptions opIdiom = new GrOptions("Idiom", "en");
                //opIdiom.insert();
            }
        }
        #endregion
        #region Listados ListViews
        public static List<ListViewItem> ListadoRecursosByGrupo(int grupo_id)
        {
            List<ListViewItem> lstViewItems = new List<ListViewItem>();
            List<Recurso> lst = Recurso.read();
            lst = lst.FindAll(x => x.grupo_id == grupo_id).ToList();
            lst = lst.OrderBy(x => x.nombre).ToList();
            List<string[]> lstItems = new List<string[]>();

            foreach (Recurso mat in lst)
            {
                string[] values = new string[3];
                values[0] = mat.nombre;
                values[1] = mat.unidad;
                values[2] = mat.grupo_id.ToString();
                ListViewItem item = new ListViewItem(values);
                if (mat.categoria == "Material")
                    item.ImageIndex = 1;
                if (mat.categoria == "Mano de Obra")
                    item.ImageIndex = 2;
                if (mat.categoria == "Equipo")
                    item.ImageIndex = 3;
                lstViewItems.Add(item);
            }
            return lstViewItems;
        }
        public static List<ListViewItem> ListadoTareasByRubro(int rubro_Id)
        {
            List<ListViewItem> lstViewItems = new List<ListViewItem>();
            List<Tarea> lstTarea = Tarea.read();
            lstTarea = lstTarea.FindAll(x => x.rubro_Id == rubro_Id).ToList();
            lstTarea = lstTarea.OrderBy(x => x.nombre).ToList();
            List<string[]> lstItems = new List<string[]>();

            foreach (Tarea tarea in lstTarea)
            {
                string[] values = new string[3];
                values[0] = tarea.nombre;
                values[1] = tarea.unidad;
                values[2] = tarea.rubro_Id.ToString();
                lstItems.Add(values);
            }
            foreach (string[] s in lstItems)
            {
                ListViewItem item = new ListViewItem(s);
                item.ImageIndex = 1;
                lstViewItems.Add(item);
            }
            return lstViewItems;
        }
        public static List<ListViewItem> ListadoPresupuestosByProyecto(int proyecto_id)
        {
            List<ListViewItem> lstViewItems = new List<ListViewItem>();
            List<Presupuesto> lst = Presupuesto.read();
            lst = lst.FindAll(x => x.proyecto_id == proyecto_id).ToList();
            lst = lst.OrderBy(x => x.nombre).ToList();
            List<string[]> lstItems = new List<string[]>();

            foreach (Presupuesto pre in lst)
            {
                string[] values = new string[2];
                values[0] = pre.nombre;
                values[1] = pre.proyecto_id.ToString();
                ListViewItem item = new ListViewItem(values);
                item.ImageIndex = 2;
                lstViewItems.Add(item);
            }
            return lstViewItems;
        }
        //public static List<ListViewItem> ListadoCostosIndirectos()
        //{
        //    List<ListViewItem> lstViewItems = new List<ListViewItem>();
        //    List<CostoIndirecto> lstCostos = CostoIndirecto.read();
        //    lstCostos = lstCostos.OrderBy(x => x.codigo).ToList();
        //    List<string[]> lstItems = new List<string[]>();

        //    foreach (CostoIndirecto co in lstCostos)
        //    {
        //        string[] values = new string[3];
        //        values[0] = co.codigo;
        //        values[1] = co.nombre;
        //        values[2] = co.unidad;
        //        lstItems.Add(values);
        //    }
        //    foreach (string[] s in lstItems)
        //    {
        //        ListViewItem item = new ListViewItem(s);
        //        item.ImageIndex = 1;
        //        lstViewItems.Add(item);
        //    }
        //    return lstViewItems;
        //}
        //public static List<ListViewItem> ListadoGastosGenerales()
        //{
        //    List<ListViewItem> lstViewItems = new List<ListViewItem>();
        //    List<GastoGeneral> lstGastos = GastoGeneral.read();
        //    lstGastos = lstGastos.OrderBy(x => x.codigo).ToList();
        //    List<string[]> lstItems = new List<string[]>();

        //    foreach (GastoGeneral ga in lstGastos)
        //    {
        //        string[] values = new string[3];
        //        values[0] = ga.codigo;
        //        values[1] = ga.nombre;
        //        values[2] = ga.unidad;
        //        lstItems.Add(values);
        //    }
        //    foreach (string[] s in lstItems)
        //    {
        //        ListViewItem item = new ListViewItem(s);
        //        item.ImageIndex = 1;
        //        lstViewItems.Add(item);
        //    }
        //    return lstViewItems;
        //}
        public static List<ListViewItem> ListadoTareas()
        {
            List<ListViewItem> lstViewItems = new List<ListViewItem>();
            List<Tarea> lstTarea = Tarea.read();
            lstTarea = lstTarea.OrderBy(x => x.nombre).ToList();
            List<string[]> lstItems = new List<string[]>();

            foreach (Tarea tarea in lstTarea)
            {
                string[] values = new string[2];
                values[0] = tarea.nombre;
                values[1] = tarea.unidad;
                lstItems.Add(values);
            }
            foreach (string[] s in lstItems)
            {
                ListViewItem item = new ListViewItem(s);
                item.ImageIndex = 1;
                lstViewItems.Add(item);
            }
            return lstViewItems;
        }
        public static List<ListViewItem> ListadoConsumoRecurso(int tarea_id)
        {
            List<ListViewItem> lstViewItems = new List<ListViewItem>();
            List<ConsumoRecurso> lst = ConsumoRecurso.read().FindAll(x => x.tarea_id == tarea_id);
            lst = lst.OrderBy(x => x.recurso_id).ToList();
            //List<string[]> lstItems = new List<string[]>();

            foreach (ConsumoRecurso obj in lst)
            {
                Recurso rec = obj.getRecurso();
                string[] values = new string[6];
                values[0] = rec.nombre;
                values[1] = obj.consumo.ToString();
                values[2] = rec.unidad;
                values[3] = String.Format("{0:c}", rec.precio);
                values[4] = obj.coeficiente.ToString();
                double total = obj.consumo * rec.precio * obj.coeficiente;
                values[5] = String.Format("{0:c}", total);
                ListViewItem item = new ListViewItem(values);
                if (obj.getCategoria() == "Material")
                {
                    item.ImageIndex = 0;
                }
                if (obj.getCategoria() == "Trabajo")
                {
                    item.ImageIndex = 1;
                }
                if (obj.getCategoria() == "Equipo")
                {
                    item.ImageIndex = 2;
                }
                lstViewItems.Add(item);
            }
            return lstViewItems;
        }
        #endregion
        #region Nodes
        public static TreeNode crearNodeGruposRecursos()
        {
            //Treenodes
            TreeNode node0 = new TreeNode();
            node0.Name = "Grupos";
            node0.Text = "Grupos de Recursos";

            //Ordenar Nodes
            List<GrupoRecurso> lst = GrupoRecurso.read();
            lst = lst.OrderBy(x => x.nombre).ToList();
            foreach (GrupoRecurso gru in lst)
            {
                TreeNode node1 = new TreeNode();
                node1.Name = gru.id.ToString();
                node1.Text = gru.toNodeText();
                node0.Nodes.Add(node1);
            }
            node0.ExpandAll();
            return node0;
        }
        public static TreeNode crearNodeRubros()
        {
            //Treenodes
            TreeNode node0 = new TreeNode();
            node0.Name = "Rubros";
            node0.Text = "Rubros";

            //Ordenar Nodes
            List<Rubro> lst = Rubro.read();
            lst = lst.OrderBy(x => x.nombre).ToList();
            foreach (Rubro rubro in lst)
            {
                TreeNode node1 = new TreeNode();
                node1.Name = rubro.id.ToString();
                node1.Text = rubro.toNodeText();
                node0.Nodes.Add(node1);
            }
            node0.ExpandAll();
            return node0;
        }
        public static TreeNode crearNodeProyectos()
        {
            //Treenodes
            TreeNode node0 = new TreeNode();
            node0.Name = "Proyectos";
            node0.Text = "Proyectos";
            node0.ImageIndex = 0;
            node0.SelectedImageIndex = 0;

            //Ordenar Nodes
            List<Proyecto> lst = Proyecto.read();
            lst = lst.OrderBy(x => x.nombre).ToList();
            foreach (Proyecto proy in lst)
            {
                TreeNode node1 = new TreeNode();
                node1.Name = proy.id.ToString();
                node1.Text = proy.toNodeText();
                node1.ImageIndex = 1;
                node1.SelectedImageIndex = 1;
                node0.Nodes.Add(node1);
            }
            node0.ExpandAll();
            return node0;
        }
        public static TreeNode crearNodeRubrosPres(Presupuesto pres)
        {
            //Treenodes
            TreeNode node0 = new TreeNode();
            node0.Name = "00";
            node0.Text = pres.nombre;
            node0.ImageIndex = 0;
            node0.SelectedImageIndex = 0;

            //Ordenar Nodes
            List<RubroPres> lst = RubroPres.read().FindAll(x => x.pres_id == pres.id);
            lst = lst.OrderBy(x => x.orden).ThenBy(x => x.nombre).ToList();
            foreach (RubroPres rubro in lst)
            {
                TreeNode node1 = new TreeNode();
                node1.Name = rubro.id.ToString();
                node1.Text = rubro.toNodeText();
                node1.ImageIndex = 1;
                node1.SelectedImageIndex = 1;
                node0.Nodes.Add(node1);
            }
            node0.ExpandAll();
            return node0;
        }
        public static TreeNode crearNode0()
        {
            #region Treenodes
            //Treenodes
            TreeNode node0 = new TreeNode();
            node0.Name = "GR";
            node0.Text = "Gestión Revit";

            TreeNode nodeDB = new TreeNode();
            nodeDB.Name = "nodeDB";
            nodeDB.Text = "Bases de Datos";

            TreeNode nodeMat = new TreeNode();
            nodeMat.Name = "nodeMat";
            nodeMat.Text = "Materiales";

            TreeNode nodeMO = new TreeNode();
            nodeMO.Name = "nodeMO";
            nodeMO.Text = "Mano de Obra";

            TreeNode nodeEq = new TreeNode();
            nodeEq.Name = "nodeEq";
            nodeEq.Text = "Equipos";

            TreeNode nodeIndi = new TreeNode();
            nodeIndi.Name = "nodeIndi";
            nodeIndi.Text = "Costos Indirectos";

            TreeNode nodeGen = new TreeNode();
            nodeGen.Name = "nodeGen";
            nodeGen.Text = "Gastos Generales";

            TreeNode nodeItem = new TreeNode();
            nodeItem.Name = "nodeItem";
            nodeItem.Text = "Items de Presupuesto";

            TreeNode nodeObras = new TreeNode();
            nodeObras.Name = "nodeObras";
            nodeObras.Text = "Obras Civiles";
            #endregion

            //foreach (Ob   raCivil oc in ObraCivil.read())
            //{
            //    TreeNode nodeOc = new TreeNode();
            //    nodeOc.Name = oc.codigo.ToString();
            //    nodeOc.Text = oc.toNodeText();
            //    nodeObras.Nodes.Add(nodeOc);
            //}

            nodeDB.Nodes.Add(nodeMat);
            nodeDB.Nodes.Add(nodeMO);
            nodeDB.Nodes.Add(nodeEq);
            nodeDB.Nodes.Add(nodeIndi);
            nodeDB.Nodes.Add(nodeGen);
            nodeDB.Nodes.Add(nodeItem);
            node0.Nodes.Add(nodeDB);
            node0.Nodes.Add(nodeObras);
            node0.ExpandAll();
            return node0;
        }
        #endregion
        #region Importar Excel
        public static List<GrupoRecurso> importGruposFromExcel()
        {
            string path = @"C:\GestionRevit2013\Datos\grupo_materiales.xlsx";
            List<GrupoRecurso> lstGrupos = new List<GrupoRecurso>();
            var workbook = new XLWorkbook(path);
            var ws1 = workbook.Worksheet(1);
            foreach (IXLRow row in ws1.Rows())
            {
                string codigo = row.Cell(2).Value.ToString();
                string nombre = row.Cell(3).Value.ToString();
                GrupoRecurso grupo = new GrupoRecurso(nombre);
                lstGrupos.Add(grupo);
            }
            lstGrupos.RemoveAt(0);
            lstGrupos = lstGrupos.OrderBy(x => x.nombre).ToList();
            return lstGrupos;
        }
        public static List<Recurso> importMaterialFromExcel()
        {
            //Grupos
            List<GrupoImportado> lstGrupos = new List<GrupoImportado>();
            string pathG = @"C:\GestionRevit2013\Datos\grupo_materiales.xlsx";
            var workbookG = new XLWorkbook(pathG);
            var wsG = workbookG.Worksheet(1);
            List<IXLRow> lstRowG = new List<IXLRow>();
            foreach (IXLRow row in wsG.Rows())
            {
                lstRowG.Add(row);
            }
            lstRowG.RemoveAt(0);
            foreach (IXLRow row in lstRowG)
            {
                string id = row.Cell(1).Value.ToString();
                string codigo = row.Cell(2).Value.ToString();
                string nombre = row.Cell(3).Value.ToString();
                GrupoImportado grupo = new GrupoImportado();
                grupo.id = id;
                grupo.nombre = nombre;
                lstGrupos.Add(grupo);
            }
            lstGrupos = lstGrupos.OrderBy(x => x.nombre).ToList();

            //Recursos
            string path = @"C:\GestionRevit2013\Datos\materiales.xlsx";
            List<Recurso> lstMats = new List<Recurso>();
            var workbook = new XLWorkbook(path);
            var ws1 = workbook.Worksheet(1);
            List<IXLRow> lstRows = new List<IXLRow>();
            foreach (IXLRow row in ws1.Rows())
            {
                lstRows.Add(row);
            }
            lstRows.RemoveAt(0);
            foreach (IXLRow row in lstRows)
            {
                string codigo = row.Cell(2).Value.ToString();
                string nombre = row.Cell(3).Value.ToString();
                double precio = 0;
                try
                {
                    precio = Convert.ToDouble(row.Cell(4).Value.ToString());
                }
                catch (Exception)
                {

                }
                string unidad = row.Cell(5).Value.ToString();
                DateTime ultima_actualizacion = DateTime.Now;
                string proveedor_id = row.Cell(8).Value.ToString();
                string venta_comercial = row.Cell(10).Value.ToString();
                double venta_cantidad = 1;
                try
                {
                    venta_cantidad = Convert.ToDouble(row.Cell(11).Value.ToString());
                }
                catch (Exception)
                {
                }
                string venta_unidad = row.Cell(12).Value.ToString();
                double precio_venta = 0;
                try
                {
                    precio_venta = Convert.ToDouble(row.Cell(13).Value.ToString());
                }
                catch (Exception)
                {
                }
                string grupo_id = row.Cell(14).Value.ToString();
                GrupoImportado grupo = lstGrupos.Find(x => x.id == grupo_id);
                int grupo_material_id = GrupoRecurso.getByNombre(grupo.nombre).id;
                string codigo_comercial = row.Cell(15).Value.ToString();
                string proveedor_nombre = row.Cell(16).Value.ToString();
                string nombre_comercial = row.Cell(17).Value.ToString();

                Recurso mat = new Recurso();
                mat.nombre = nombre;
                mat.categoria = "Material";
                mat.precio = precio;
                mat.unidad = unidad;
                mat.ultima_actualizacion = ultima_actualizacion;
                mat.venta_cantidad = venta_cantidad;
                mat.venta_unidad = venta_unidad;
                mat.precio_venta = precio_venta;
                mat.grupo_id = grupo_material_id;
                mat.codigo_comercial = codigo_comercial;
                mat.nombre_comercial = nombre_comercial;
                lstMats.Add(mat);
            }
            lstMats = lstMats.OrderBy(x => x.nombre).ToList();
            return lstMats;
        }
        public static List<Recurso> importManoObraFromExcel()
        {
            string path = @"C:\GestionRevit2013\Datos\manodeobra.xlsx";
            List<Recurso> lst = new List<Recurso>();
            var workbook = new XLWorkbook(path);
            var ws1 = workbook.Worksheet(1);
            List<IXLRow> lstRows = new List<IXLRow>();
            foreach (IXLRow row in ws1.Rows())
            {
                lstRows.Add(row);
            }
            lstRows.RemoveAt(0);

            if (!GrupoRecurso.read().Exists(x => x.nombre == "000-Mano de Obra"))
            {
                GrupoRecurso grupo = new GrupoRecurso("000-Mano de Obra");
                grupo.insert();
            }

            foreach (IXLRow row in lstRows)
            {
                string nombre = row.Cell(2).Value.ToString();
                string categoria = "Trabajo";
                double precio = Convert.ToDouble(row.Cell(3).Value.ToString());
                string unidad = row.Cell(4).Value.ToString();
                DateTime actualizacion = DateTime.Now;
                int proveedor_id = 0;
                double venta_cantidad = 1;
                string venta_unidad = unidad;
                double precio_venta = precio;
                int grupo_id = GrupoRecurso.getByNombre("000-Mano de Obra").id;
                string codigo_comercial = string.Empty;
                string nombre_comercial = string.Empty;

                Recurso mo = new Recurso();
                mo.nombre = nombre;
                mo.categoria = categoria;
                mo.precio = precio;
                mo.unidad = unidad;
                mo.ultima_actualizacion = actualizacion;
                mo.proveedor_id = proveedor_id;
                mo.venta_cantidad = venta_cantidad;
                mo.venta_unidad = venta_unidad;
                mo.precio_venta = precio_venta;
                mo.grupo_id = grupo_id;
                mo.codigo_comercial = codigo_comercial;
                mo.nombre_comercial = nombre_comercial;
                lst.Add(mo);
            }
            lst = lst.OrderBy(x => x.nombre).ToList();
            return lst;
        }
        public static List<Recurso> importEquiposFromExcel()
        {
            string path = @"C:\GestionRevit2013\Datos\equipos.xlsx";
            List<Recurso> lstEqs = new List<Recurso>();
            var workbook = new XLWorkbook(path);
            var ws1 = workbook.Worksheet(1);
            List<IXLRow> lstRows = new List<IXLRow>();
            foreach (IXLRow row in ws1.Rows())
            {
                lstRows.Add(row);
            }
            lstRows.RemoveAt(0);

            if (!GrupoRecurso.read().Exists(x => x.nombre == "000-Equipos"))
            {
                GrupoRecurso grupo = new GrupoRecurso("000-Equipos");
                grupo.insert();
            }

            foreach (IXLRow row in lstRows)
            {
                string codigo = row.Cell(2).Value.ToString();
                string nombre = row.Cell(3).Value.ToString();
                string categoria = "Equipo";
                double precio = Convert.ToDouble(row.Cell(4).Value.ToString());
                string unidad = row.Cell(5).Value.ToString();
                DateTime actualizacion = DateTime.Now;
                int proveedor_id = 0;
                double venta_cantidad = 1;
                string venta_unidad = unidad;
                double precio_venta = precio;
                int grupo_id = GrupoRecurso.getByNombre("000-Equipos").id;
                string codigo_comercial = string.Empty;
                string nombre_comercial = string.Empty;

                Recurso eq = new Recurso();
                eq.nombre = nombre;
                eq.categoria = categoria;
                eq.precio = precio;
                eq.unidad = unidad;
                eq.ultima_actualizacion = actualizacion;
                eq.proveedor_id = proveedor_id;
                eq.venta_cantidad = venta_cantidad;
                eq.venta_unidad = venta_unidad;
                eq.precio_venta = precio_venta;
                eq.grupo_id = grupo_id;
                eq.codigo_comercial = codigo_comercial;
                eq.nombre_comercial = nombre_comercial;

                lstEqs.Add(eq);
            }
            lstEqs = lstEqs.OrderBy(x => x.nombre).ToList();
            return lstEqs;
        }
        public static List<Rubro> importRubrosFromExcel()
        {
            string path = @"C:\GestionRevit2013\Datos\rubros.xlsx";
            List<Rubro> lstRubros = new List<Rubro>();
            var workbook = new XLWorkbook(path);
            var ws1 = workbook.Worksheet(1);
            foreach (IXLRow row in ws1.Rows())
            {
                string codigo = row.Cell(2).Value.ToString();
                string nombre = row.Cell(3).Value.ToString();
                Rubro rubro = new Rubro(nombre, codigo);
                lstRubros.Add(rubro);
            }
            lstRubros.RemoveAt(0);
            lstRubros = lstRubros.OrderBy(x => x.nombre).ToList();
            return lstRubros;
        }
        public static List<Tarea> importTareasFromExcel()
        {
            //Rubros
            List<RubroImportado> lstRubros = new List<RubroImportado>();
            string pathR = @"C:\GestionRevit2013\Datos\rubros.xlsx";
            var workbookR = new XLWorkbook(pathR);
            var wsR = workbookR.Worksheet(1);
            List<IXLRow> lstRowR = wsR.Rows().ToList(); //new List<IXLRow>();
            //foreach (IXLRow row in wsR.Rows())
            //{
            //    lstRowR.Add(row);
            //}
            lstRowR.RemoveAt(0);
            foreach (IXLRow row in lstRowR)
            {
                string id = row.Cell(1).Value.ToString();
                string codigo = row.Cell(2).Value.ToString();
                string nombre = row.Cell(3).Value.ToString();
                RubroImportado rubroImp = new RubroImportado();
                rubroImp.id = id;
                rubroImp.codigo = codigo;
                rubroImp.nombre = nombre;
                lstRubros.Add(rubroImp);
            }
            lstRubros = lstRubros.OrderBy(x => x.codigo).ToList();

            //Tareas
            List<Tarea> lstTareas = new List<Tarea>();
            string path = @"C:\GestionRevit2013\Datos\tareas.xlsx";
            var workbook = new XLWorkbook(path);
            var ws1 = workbook.Worksheet(1);
            List<IXLRow> lstRows = ws1.Rows().ToList();//new List<IXLRow>();
            //foreach (IXLRow row in ws1.Rows())
            //{
            //    lstRows.Add(row);
            //}
            lstRows.RemoveAt(0);
            foreach (IXLRow row in lstRows)
            {
                try
                {
                    string codigo = row.Cell(2).Value.ToString();
                    string nombre = row.Cell(3).Value.ToString();
                    string unidad = row.Cell(4).Value.ToString();
                    string detalles = row.Cell(5).Value.ToString();
                    string rubro_id = row.Cell(6).Value.ToString();
                    RubroImportado rubroImp = lstRubros.Find(x => x.id == rubro_id);
                    Rubro rubro = Rubro.getByNombre(rubroImp.nombre);
                    //string rubro_codigo = rubroImp.id;

                    Tarea tarea = new Tarea();
                    tarea.nombre = nombre;
                    tarea.unidad = unidad;
                    tarea.detalles = detalles;
                    tarea.rubro_Id = rubro.id;
                    lstTareas.Add(tarea);
                }
                catch (Exception)
                {

                }
            }
            lstTareas = lstTareas.OrderBy(x => x.nombre).ToList();
            return lstTareas;
        }
        public static List<ConsumoRecurso> importConsumos()
        {
            //Tareas importadas
            List<TareaImportada> lstT = new List<TareaImportada>();
            string pathT = @"C:\GestionRevit2013\Datos\tareas.xlsx";
            var workbookT = new XLWorkbook(pathT);
            var wsT = workbookT.Worksheet(1);
            List<IXLRow> lstRowT = wsT.Rows().ToList();//new List<IXLRow>();
            //foreach (IXLRow row in wsT.Rows())
            //{
            //    lstRowT.Add(row);
            //}
            lstRowT.RemoveAt(0);
            foreach (IXLRow row in lstRowT)
            {
                string id = row.Cell(1).Value.ToString();
                string codigo = row.Cell(2).Value.ToString();
                string nombre = row.Cell(3).Value.ToString();
                TareaImportada obj = new TareaImportada();
                obj.id = id;
                obj.codigo = codigo;
                obj.nombre = nombre;
                lstT.Add(obj);
            }
            lstT = lstT.OrderBy(x => x.nombre).ToList();

            //Materiales importados
            List<MaterialImportado> lstM = new List<MaterialImportado>();
            string pathM = @"C:\GestionRevit2013\Datos\materiales.xlsx";
            var workbookM = new XLWorkbook(pathM);
            var wsM = workbookM.Worksheet(1);
            List<IXLRow> lstRowM = wsM.Rows().ToList();//new List<IXLRow>();
            //foreach (IXLRow row in wsM.Rows())
            //{
            //    lstRowM.Add(row);
            //}
            lstRowM.RemoveAt(0);
            foreach (IXLRow row in lstRowM)
            {
                string id = row.Cell(1).Value.ToString();
                string nombre = row.Cell(3).Value.ToString();
                MaterialImportado obj = new MaterialImportado();
                obj.id = id;
                obj.nombre = nombre;
                lstM.Add(obj);
            }
            lstM = lstM.OrderBy(x => x.nombre).ToList();

            //Consumo Materiales
            List<ConsumoRecurso> lstMats = new List<ConsumoRecurso>();
            string pathCM = @"C:\GestionRevit2013\Datos\consumo_materiales.xlsx";
            var workbook = new XLWorkbook(pathCM);
            var ws1 = workbook.Worksheet(1);
            List<IXLRow> lstRows = ws1.Rows().ToList();//new List<IXLRow>();
            //foreach (IXLRow row in ws1.Rows())
            //{
            //    lstRows.Add(row);
            //}
            lstRows.RemoveAt(0);
            foreach (IXLRow row in lstRows)
            {
                string tarea_id = row.Cell(2).Value.ToString();
                string material_id = row.Cell(3).Value.ToString();
                double consumo = Convert.ToDouble(row.Cell(4).Value.ToString());
                double coeficiente = Convert.ToDouble(row.Cell(5).Value.ToString());
                string categoria = "Material";
                TareaImportada tarea = lstT.Find(x => x.id == tarea_id);
                Tarea tarea0 = Tarea.getByNombre(tarea.nombre);
                MaterialImportado mat = lstM.Find(x => x.id == material_id);
                Recurso rec = Recurso.getByNombre(mat.nombre);
                //string tarea_codigo = tarea.codigo;
                int recurso_id = rec.id;
                int tarea0Id = tarea0.id;

                ConsumoRecurso cm = new ConsumoRecurso();
                cm.tarea_id = tarea0Id;
                cm.recurso_id = recurso_id;
                cm.consumo = consumo;
                cm.coeficiente = coeficiente;
                //cm.categoria = categoria;
                lstMats.Add(cm);
            }
            //Mano de Obra importada
            List<MaterialImportado> lstMo = new List<MaterialImportado>();
            string pathMo = @"C:\GestionRevit2013\Datos\manodeobra.xlsx";
            var workbookMo = new XLWorkbook(pathMo);
            var wsMo = workbookMo.Worksheet(1);
            List<IXLRow> lstRowMo = wsMo.Rows().ToList();//new List<IXLRow>();
            //foreach (IXLRow row in wsMo.Rows())
            //{
            //    lstRowMo.Add(row);
            //}
            lstRowMo.RemoveAt(0);
            foreach (IXLRow row in lstRowMo)
            {
                string id = row.Cell(1).Value.ToString();
                string nombre = row.Cell(2).Value.ToString();
                MaterialImportado obj = new MaterialImportado();
                obj.id = id;
                obj.nombre = nombre;
                lstMo.Add(obj);
            }
            lstMo = lstMo.OrderBy(x => x.nombre).ToList();

            //Consumo Mano de Obra
            List<ConsumoRecurso> lstMano = new List<ConsumoRecurso>();
            string pathCMo = @"C:\GestionRevit2013\Datos\consumo_mano_obra.xlsx";
            var workbookCmo = new XLWorkbook(pathCMo);
            var wsCmo = workbookCmo.Worksheet(1);
            List<IXLRow> lstRowCmo = wsCmo.Rows().ToList();//new List<IXLRow>();
            //foreach (IXLRow row in wsCmo.Rows())
            //{
            //    lstRowCmo.Add(row);
            //}
            lstRowCmo.RemoveAt(0);
            foreach (IXLRow row in lstRowCmo)
            {
                string tarea_id = row.Cell(2).Value.ToString();
                string material_id = row.Cell(3).Value.ToString();
                double consumo = Convert.ToDouble(row.Cell(4).Value.ToString());
                double coeficiente = 1;
                string categoria = "Trabajo";
                TareaImportada tarea = lstT.Find(x => x.id == tarea_id);
                Tarea tarea0 = Tarea.getByNombre(tarea.nombre);
                MaterialImportado mat = lstMo.Find(x => x.id == material_id);
                Recurso rec = Recurso.getByNombre(mat.nombre);
                //string tarea_codigo = tarea.codigo;
                int recurso_id = rec.id;
                int tarea0Id = tarea0.id;

                ConsumoRecurso cm = new ConsumoRecurso();
                cm.tarea_id = tarea0Id;
                cm.recurso_id = recurso_id;
                cm.consumo = consumo;
                cm.coeficiente = coeficiente;
                //cm.categoria = categoria;
                lstMano.Add(cm);
            }
            //Equipos Importados
            List<MaterialImportado> lstEq = new List<MaterialImportado>();
            string pathEq = @"C:\GestionRevit2013\Datos\equipos.xlsx";
            var workbookEq = new XLWorkbook(pathEq);
            var wsEq = workbookEq.Worksheet(1);
            List<IXLRow> lstRowEq = wsEq.Rows().ToList();//new List<IXLRow>();
            //foreach (IXLRow row in wsEq.Rows())
            //{
            //    lstRowEq.Add(row);
            //}
            lstRowEq.RemoveAt(0);
            foreach (IXLRow row in lstRowEq)
            {
                string id = row.Cell(1).Value.ToString();
                string nombre = row.Cell(3).Value.ToString();
                MaterialImportado obj = new MaterialImportado();
                obj.id = id;
                obj.nombre = nombre;
                lstEq.Add(obj);
            }
            lstEq = lstEq.OrderBy(x => x.nombre).ToList();

            //Consumo de equipos
            List<ConsumoRecurso> lstEquipo = new List<ConsumoRecurso>();
            string pathCeq = @"C:\GestionRevit2013\Datos\consumo_equipos.xlsx";
            var workbookCeq = new XLWorkbook(pathCeq);
            var wsCeq = workbookCeq.Worksheet(1);
            List<IXLRow> lstRowCeq = wsCeq.Rows().ToList();//new List<IXLRow>();
            //foreach (IXLRow row in wsCeq.Rows())
            //{
            //    lstRowCeq.Add(row);
            //}
            lstRowCeq.RemoveAt(0);
            foreach (IXLRow row in lstRowCeq)
            {
                string tarea_id = row.Cell(2).Value.ToString();
                string material_id = row.Cell(3).Value.ToString();
                double consumo = Convert.ToDouble(row.Cell(4).Value.ToString());
                double coeficiente = Convert.ToDouble(row.Cell(5).Value.ToString());
                string categoria = "Equipo";
                TareaImportada tarea = lstT.Find(x => x.id == tarea_id);
                Tarea tarea0 = Tarea.getByNombre(tarea.nombre);
                MaterialImportado mat = lstEq.Find(x => x.id == material_id);
                Recurso rec = Recurso.getByNombre(mat.nombre);
                //string tarea_codigo = tarea.codigo;
                int recurso_id = rec.id;
                int tarea0Id = tarea0.id;

                ConsumoRecurso cm = new ConsumoRecurso();
                cm.tarea_id = tarea0Id;
                cm.recurso_id = recurso_id;
                cm.consumo = consumo;
                cm.coeficiente = coeficiente;
                //cm.categoria = categoria;
                lstEquipo.Add(cm);
            }

            lstMats.AddRange(lstMano);
            lstMats.AddRange(lstEquipo);
            return lstMats;
        }
        public static void importTareas()
        {
            //Importo los Grupos de Recursos
            List<GrupoRecurso> lstGrupos = importGruposFromExcel();
            foreach (GrupoRecurso grupo in lstGrupos)
            {
                if (!GrupoRecurso.read().Exists(x => x.nombre == grupo.nombre))
                {
                    grupo.insert();
                }
            }
            //Importo los Materiales
            List<Recurso> lstMA = importMaterialFromExcel();
            foreach (Recurso rec in lstMA)
            {
                if (!Recurso.read().Exists(x => x.nombre == rec.nombre))
                {
                    rec.insert();
                }
                else
                {
                    Recurso rec0 = Recurso.getByNombre(rec.nombre);
                    rec0.precio = rec.precio;
                    rec0.unidad = rec.unidad;
                    rec0.ultima_actualizacion = DateTime.Now;
                    rec0.proveedor_id = rec.proveedor_id;
                    rec0.venta_cantidad = rec.venta_cantidad;
                    rec0.venta_unidad = rec.venta_unidad;
                    rec0.precio_venta = rec.precio_venta;
                    rec0.codigo_comercial = rec.codigo_comercial;
                    rec0.nombre_comercial = rec.nombre_comercial;
                    rec0.update();
                }
            }
            //Importo la Mano de Obra
            List<Recurso> lstMo = importManoObraFromExcel();
            foreach (Recurso rec in lstMo)
            {
                if (!Recurso.read().Exists(x => x.nombre == rec.nombre))
                {
                    rec.insert();
                }
                else
                {
                    Recurso rec0 = Recurso.getByNombre(rec.nombre);
                    rec0.precio = rec.precio;
                    rec0.unidad = rec.unidad;
                    rec0.ultima_actualizacion = DateTime.Now;
                    rec0.proveedor_id = rec.proveedor_id;
                    rec0.venta_cantidad = rec.venta_cantidad;
                    rec0.venta_unidad = rec.venta_unidad;
                    rec0.precio_venta = rec.precio_venta;
                    rec0.codigo_comercial = rec.codigo_comercial;
                    rec0.nombre_comercial = rec.nombre_comercial;
                    rec0.update();
                }
            }
            //Importo los Equipos
            List<Recurso> lstEq = importEquiposFromExcel();
            foreach (Recurso rec in lstEq)
            {
                if (!Recurso.read().Exists(x => x.nombre == rec.nombre))
                {
                    rec.insert();
                }
                else
                {
                    Recurso rec0 = Recurso.getByNombre(rec.nombre);
                    rec0.precio = rec.precio;
                    rec0.unidad = rec.unidad;
                    rec0.ultima_actualizacion = DateTime.Now;
                    rec0.proveedor_id = rec.proveedor_id;
                    rec0.venta_cantidad = rec.venta_cantidad;
                    rec0.venta_unidad = rec.venta_unidad;
                    rec0.precio_venta = rec.precio_venta;
                    rec0.codigo_comercial = rec.codigo_comercial;
                    rec0.nombre_comercial = rec.nombre_comercial;
                    rec0.update();
                }
            }
            //Importo los Rubros
            List<Rubro> lstRubros = importRubrosFromExcel();
            foreach (Rubro rubro in lstRubros)
            {
                if (!Rubro.read().Exists(x => x.nombre == rubro.nombre))
                {
                    rubro.insert();
                }
            }
            //Importo las tareas
            List<Tarea> lstTareas = importTareasFromExcel();
            foreach (Tarea tarea in lstTareas)
            {
                if (!Tarea.read().Exists(x => x.nombre == tarea.nombre))
                {
                    tarea.insert();
                }
                else
                {
                    Tarea tarea0 = Tarea.getByNombre(tarea.nombre);
                    tarea0.nombre = tarea.nombre;
                    tarea0.unidad = tarea.unidad;
                    tarea0.detalles = tarea.detalles;
                    tarea0.update();
                }
            }
            //Importo los consumos de Materiales, Mano de Obra y Equipos
            List<ConsumoRecurso> lstConsumoMat = importConsumos();
            foreach (ConsumoRecurso cr in lstConsumoMat)
            {
                if (!ConsumoRecurso.read().Exists(x => x.tarea_id == cr.tarea_id && x.recurso_id == cr.recurso_id))
                {
                    cr.insert();
                }
                else
                {
                    ConsumoRecurso cr0 = ConsumoRecurso.getByCodigos(cr.tarea_id, cr.recurso_id); //, cr.categoria);
                    cr0.consumo = cr.consumo;
                    cr0.coeficiente = cr.coeficiente;
                    cr0.update();
                }
            }
        }
        public static List<string> GetSheetsFromExcel(string path)
        {
            List<string> lst = new List<string>();
            var workbook = new XLWorkbook(path);
            for (int i = 1; i < workbook.Worksheets.Count + 1; i++)
            {
                string name = workbook.Worksheet(i).Name;
                lst.Add(name);
            }
            return lst;
        }
        public static int GetSheetRowsCount(string path, string sheetName)
        {
            var book = new XLWorkbook(path);
            var ws1 = book.Worksheet(sheetName);
            return ws1.Rows().Count();
        }
        public static List<RecursoImportadoExcel> ImportRecursosFromExcel(string path, 
            string sheetName, int GroupColumn, int NameColumn, int UnitColumn, int CostColumn, int FromRow, 
            int ToRow, bool addInfo, int ComUnit, int ComCost, int Equiv, int TipoCol)
        {
            List<RecursoImportadoExcel> lst = new List<RecursoImportadoExcel>();
            var book = new XLWorkbook(path);
            var ws1 = book.Worksheet(sheetName);
            int rowCount = ws1.Rows().Count();
            int final = ToRow;
            if (rowCount < ToRow)
            {
                final = rowCount;
            }
            for (int i = FromRow; i < final + 1; i++)
            {
                string grupo = ws1.Row(i).Cell(GroupColumn).Value.ToString();
                string nombre = ws1.Row(i).Cell(NameColumn).Value.ToString();
                string unit = ws1.Row(i).Cell(UnitColumn).Value.ToString();
                double Cost = 0;
                string comUnit = unit;
                double equivalence = 1;
                string categoria = "Material";
                try
                {
                    Cost = Math.Round(Convert.ToDouble(ws1.Row(i).Cell(CostColumn).Value), 3);
                }
                catch (Exception)
                {

                }
                double comCost = Cost;
                if (addInfo)
                {
                    comUnit = ws1.Row(i).Cell(ComUnit).Value.ToString();
                    categoria = ws1.Row(i).Cell(TipoCol).Value.ToString();
                    try
                    {
                        equivalence = Math.Round(Convert.ToDouble(ws1.Row(i).Cell(Equiv).Value), 3);
                        comCost = Math.Round(Convert.ToDouble(ws1.Row(i).Cell(ComCost).Value), 3);
                    }
                    catch (Exception)
                    {

                    }
                }
                RecursoImportadoExcel rec = new RecursoImportadoExcel();
                rec.Group = grupo;
                rec.Name = nombre;
                rec.Unit = unit;
                rec.Cost = Cost;
                rec.CommercialUnit = comUnit;
                rec.CommercialCost = comCost;
                rec.Equivalence = equivalence;
                rec.Categoria = categoria;
                lst.Add(rec);
            }
            return lst;
        }
        public static List<TareaImportadaExcel> ImportItemsFromExcel(string path, string sheetName, 
            int GroupColumn, int NameColumn, int UnitColumn, int DetalleColumn, int FromRow, int ToRow)
        {
            List<TareaImportadaExcel> lst = new List<TareaImportadaExcel>();
            var book = new XLWorkbook(path);
            var ws1 = book.Worksheet(sheetName);
            int rowCount = ws1.Rows().Count();
            int final = ToRow;
            if (rowCount < ToRow)
            {
                final = rowCount;
            }
            for (int i = FromRow; i < final + 1; i++)
            {
                string grupo = ws1.Row(i).Cell(GroupColumn).Value.ToString();
                string nombre = ws1.Row(i).Cell(NameColumn).Value.ToString();
                string unit = ws1.Row(i).Cell(UnitColumn).Value.ToString();
                string detalles = ws1.Row(i).Cell(DetalleColumn).Value.ToString();
                TareaImportadaExcel tr = new TareaImportadaExcel();
                tr.grupo = grupo;
                tr.nombre = nombre;
                tr.unidad = unit;
                tr.detalles = detalles;
                lst.Add(tr);
            }
            return lst;
        }
        public static List<ConsumoItemExcel> ImportConsumoItemsFromExcel(string path, string sheetName,
            int ItemColumn, int NameColumn, int QuantityColumn, int UnitColumn, int FromRow, int ToRow)
        {
            List<ConsumoItemExcel> lst = new List<ConsumoItemExcel>();
            var book = new XLWorkbook(path);
            var ws1 = book.Worksheet(sheetName);
            int rowCount = ws1.Rows().Count();
            int final = ToRow;
            if (rowCount < ToRow)
            {
                final = rowCount;
            }
            for (int i = FromRow; i < final + 1; i++)
            {
                string tarea = ws1.Row(i).Cell(ItemColumn).Value.ToString();
                string nombre = ws1.Row(i).Cell(NameColumn).Value.ToString();
                double quantity = 0;
                try
                {
                    quantity = Math.Round(Convert.ToDouble(ws1.Row(i).Cell(QuantityColumn).Value), 3);
                }
                catch (Exception)
                {

                }
                string unit = ws1.Row(i).Cell(UnitColumn).Value.ToString();
                ConsumoItemExcel ci = new ConsumoItemExcel();
                ci.tarea = tarea;
                ci.recurso = nombre;
                ci.consumo = quantity;
                ci.consumo_unidad = unit;
                lst.Add(ci);
            }
            return lst;
        }
        #endregion
        #region Seleccionar Recursos
        public static TreeNode nodeSeleccionarMateriales()
        {
            //Treenodes
            TreeNode node0 = new TreeNode();
            node0.Name = "Recursos";
            node0.Text = "Recursos";

            //Ordenar Nodes
            List<GrupoRecurso> lstG = GrupoRecurso.read();
            lstG = lstG.OrderBy(x => x.nombre).ToList();
            foreach (GrupoRecurso gru in lstG)
            {
                TreeNode node1 = new TreeNode();
                node1.Name = gru.nombre;
                node1.Text = gru.nombre;
                node1.ImageIndex = 0;
                node1.SelectedImageIndex = 0;

                foreach (Recurso rec in gru.getChilds())
                {
                    TreeNode node2 = new TreeNode();
                    node2.Name = rec.id.ToString();
                    node2.Text = rec.toNodeText();
                    if (rec.categoria == "Material")
                    {
                        node2.ImageIndex = 1;
                        node2.SelectedImageIndex = 1;
                    }
                    if (rec.categoria == "Trabajo")
                    {
                        node2.ImageIndex = 2;
                        node2.SelectedImageIndex = 2;
                    }
                    if (rec.categoria == "Equipo")
                    {
                        node2.ImageIndex = 3;
                        node2.SelectedImageIndex = 3;
                    }
                    node1.Nodes.Add(node2);
                }
                node0.Nodes.Add(node1);
            }
            node0.ExpandAll();
            return node0;
        }
        public static TreeNode nodeSeleccionarTareas()
        {
            //Treenodes
            TreeNode node0 = new TreeNode();
            node0.Name = "Items";
            node0.Text = "Items";

            //Ordenar Nodes
            List<Rubro> lstG = Rubro.read();
            lstG = lstG.OrderBy(x => x.nombre).ToList();
            foreach (Rubro rubro in lstG)
            {
                TreeNode node1 = new TreeNode();
                node1.Name = rubro.id.ToString();
                node1.Text = rubro.toNodeText();
                node1.ImageIndex = 0;
                node1.SelectedImageIndex = 0;

                foreach (Tarea tarea in rubro.getChilds())
                {
                    TreeNode node2 = new TreeNode();
                    node2.Name = tarea.id.ToString();
                    node2.Text = tarea.toNodeText();
                    node2.ImageIndex = 1;
                    node2.SelectedImageIndex = 1;
                    node1.Nodes.Add(node2);
                }
                node0.Nodes.Add(node1);
            }
            node0.Expand();
            return node0;
        }
        #endregion
        #region Imagenes
        public static byte[] ImageToByte(System.Drawing.Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        public static System.Drawing.Image ByteToImage(byte[] imageBytes)
        {
            // Convert byte[] to Image
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = new Bitmap(ms);
            return image;
        }
        public static string ImageToBase64(System.Drawing.Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
        public static System.Drawing.Image Base64toImage(string base64)
        {
            byte[] imageBytes = Convert.FromBase64String(base64);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = new Bitmap(ms);
            return image;
        }
        #endregion
        #region Backup
        public static string crearBackupGrupoRecurso()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("###GrupoRecurso");
                foreach (GrupoRecurso grupo in GrupoRecurso.read())
                {
                    sb.AppendLine(grupo.toCode());
                }
                return sb.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
        public static string crearBackupRecursos()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("###Recursos");
                foreach (Recurso rec in Recurso.read())
                {
                    sb.AppendLine(rec.toCode());
                }
                return sb.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
        public static string crearBackupRubros()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("###Rubros");
                foreach (Rubro rubro in Rubro.read())
                {
                    sb.AppendLine(rubro.toCode());
                }
                return sb.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
        public static string crearBackupTareas()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("###Tareas");
                foreach (Tarea tarea in Tarea.read())
                {
                    sb.AppendLine(tarea.toCode());
                }
                return sb.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
        public static string crearBackupConsumoRecursos()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("###ConsumoRecurso");
                foreach (ConsumoRecurso cr in ConsumoRecurso.read())
                {
                    sb.AppendLine(cr.toCode());
                }
                return sb.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
        #endregion
        #region Qex
        public static List<string> qexReadLibros(string path)
        {
            List<string> lst = new List<string>();

            string[] lines = File.ReadAllLines(path);
            string[] lines2 = lines.Skip(1).ToArray();

            for (int i = 0; i < lines2.Length; i++)
            {
                string[] values = Regex.Split(lines2[i], ";");
                string libro = values[8];
                if (!lst.Exists(x => x == libro))
                {
                    lst.Add(libro);
                }
            }
            return lst;
        }
        public static List<Quantity> qexReadFileGetQuantities(string path)
        {
            List<Quantity> lst = new List<Quantity>();
            string[] lines = File.ReadAllLines(path);
            string[] lines2 = lines.Skip(1).ToArray();

            for (int i = 0; i < lines2.Length; i++)
            {
                string[] values = Regex.Split(lines2[i], ";");
                string qId = values[0];
                int typeId = Convert.ToInt32(values[1]);
                string category = values[2];
                string name = values[3];
                //if (name.Length > 60)
                //{
                //    name = name.Remove(60);
                //}
                string medicion = values[4];
                double totalCost = Convert.ToDouble(values[5]);
                string fase = values[6];
                string grupo = values[7];
                string libro = values[8];
                Quantity q = new Quantity(qId, typeId, category, name, medicion, totalCost,
                    fase, grupo, libro);
                lst.Add(q);
            }
            return lst;
        }
        public static void qexCrearPresupuesto(Proyecto proy, string libroSelected)
        {
            Presupuesto pres = new Presupuesto();
            pres.nombre = libroSelected;
            pres.proyecto_id = proy.id;
            pres.insert();
        }
        /// <summary>
        /// Agrega una Quantificacion a un Presupuesto. Si la Tarea ya existe, la actualiza con sus
        /// nuevos valores
        /// </summary>
        public static void qexAppendQuantity2(Presupuesto pres, Quantity q)
        {
            string libroName = q.libro;
            string grupoName = q.grupo;
            TareaPres tarea = q.toTareaPres(0);
            List<TareaPres> lstTareas = pres.getTareas();

            // Verificar si la Tarea y sus Grupos existen
            if (lstTareas.Exists(x => x.nombre == tarea.nombre && x.getParent().nombre == grupoName &&
            x.getParent().getParent().nombre == libroName))
            {
                // La Tarea y los Grupos existen, actualizar sus valores
                // Actualizando Tarea
                TareaPres tarea0 = TareaPres.getByPresIdAndNombres(pres.id, tarea.nombre, grupoName, libroName);
                tarea0.consumo = tarea.consumo;
                tarea0.unidad = tarea.unidad;
                tarea0.update();
            }
            else
            {
                // La Tarea NO existe. Crearla
                // Verificar si el Libro existe en los Grupos Parent
                if (!pres.getRubrosParent().Exists(xx => xx.nombre == libroName))
                {
                    // El Libro NO existe. Agregando Grupo
                    RubroPres libro = new RubroPres("", libroName, 0, "", 0, 0, 1, 0, 0, 0, pres.id);
                    libro.insert();
                    RubroPres libro0 = pres.getRubros().Last();

                    RubroPres grupo = new RubroPres("", grupoName, 0, "", 0, 0, 1, 0, 0, libro0.id, pres.id);
                    grupo.insert();
                    RubroPres grupo0 = pres.getRubros().Last();

                    // Creando Tarea
                    TareaPres tarea0 = new TareaPres("1", tarea.nombre, tarea.consumo, tarea.unidad, 0, 0, 1,
                        0, 1, grupo0.id, pres.id);
                    tarea0.insert();
                }
                else
                {
                    // El Libro existe cono Grupo Parent
                    // Verificar si el Grupo existe en el Parent
                    RubroPres libro0 = pres.getRubrosParent().FirstOrDefault(x => x.nombre == libroName);
                    if (!libro0.getChilds().Exists(x => x.nombre == grupoName))
                    {
                        // El Grupo NO existe en el Parent. Crearlo
                        RubroPres grupo = new RubroPres("", grupoName, 0, "", 0, 0, 1, 0, 1, libro0.id, pres.id);
                        grupo.insert();
                        RubroPres grupo0 = pres.getRubros().Last();
                        TareaPres tarea0 = new TareaPres("1", tarea.nombre, tarea.consumo, tarea.unidad, 0, 0, 1,
                            0, 1, grupo0.id, pres.id);
                        tarea0.insert();
                    }
                    else
                    {
                        // El Grupo existe en el Parent. Crear Tarea
                        RubroPres grupo = libro0.getChilds().FirstOrDefault(x => x.nombre == grupoName);
                        TareaPres tarea0 = new TareaPres("1", tarea.nombre, tarea.consumo, tarea.unidad,
                            0, 0, 1, 0, 1, grupo.id, pres.id);
                        tarea0.insert();
                    }
                }
            }
        }
        public static void qexCrearRubrosTareas(Presupuesto pres, Quantity q)
        {
            string nombre = q.grupo;
            if (!pres.getRubros().Exists(x => x.nombre == nombre))
            {
                RubroPres rubro = new RubroPres();
                int orden = pres.getRubros().Count + 1;
                rubro.orden = orden;
                rubro.nombre = nombre;
                rubro.pres_id = pres.id;
                rubro.insert();
            }
            RubroPres rubroPres = pres.getRubros().Find(x => x.nombre == nombre);
            TareaPres tarea = new TareaPres();
            int ordenTarea = rubroPres.getTareas().Count + 1;
            tarea.orden = ordenTarea;
            tarea.nombre = q.name;
            tarea.consumo = q.getConsumo();
            tarea.unidad = q.getUnidad();
            tarea.rubropres_id = rubroPres.id;
            tarea.insert();
        }
        #endregion
        #region Menu
        public static TreeNode MenuPresupuesto()
        {
            TreeNode node0 = new TreeNode();
            node0.Name = "Presupuesto";
            node0.Text = "Presupuesto";

            TreeNode nodeP01 = new TreeNode();
            nodeP01.Name = "P01";
            nodeP01.Text = "P01 - Crear Presupuesto";
            nodeP01.ImageIndex = 0;
            nodeP01.SelectedImageIndex = 0;
            node0.Nodes.Add(nodeP01);

            TreeNode nodeP02 = new TreeNode();
            nodeP02.Name = "P02";
            nodeP02.Text = "P02 - Ver Listado de Presupuestos";
            nodeP02.ImageIndex = 0;
            nodeP02.SelectedImageIndex = 0;

            TreeNode nodeP03 = new TreeNode();
            nodeP03.Name = "P03";
            nodeP03.Text = "P03 - ";

            return node0;
        }
        #endregion
        #region OPenXml
        public static void crearWord(string title, List<AnalisisItem> lstItem, string fileName)
        {
            // A formatting object for our title:
            var titleFormat = new Formatting();
            titleFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            titleFormat.Size = 18D;
            titleFormat.Bold = true;
            titleFormat.Position = 12;
            // A formatting object for our Group:
            var categoryFormat = new Formatting();
            categoryFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            categoryFormat.Size = 12D;
            categoryFormat.Bold = true;
            categoryFormat.Position = 12;
            // A formatting object for our normal paragraph text:
            var paraFormat = new Formatting();
            paraFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            paraFormat.Size = 10D;
            // Create the document in memory:
            var doc = DocX.Create(fileName);
            //Insert Title
            doc.InsertParagraph(title, false, titleFormat);
            //doc.InsertParagraph("Fase de creación: ", false, titleFormat);

            foreach (AnalisisItem item in lstItem)
            {
                if (item.Category == "Grupo") //Si es un grupo
                {
                    doc.InsertParagraph(item.toWordLine(), false, categoryFormat);
                }
                else
                {
                    doc.InsertParagraph(item.toWordLine(), false, paraFormat);
                }
            }
            doc.Save();
        }
        /// <summary>
        /// Crea un Excel a partir de un TreeListView con el Presupuesto
        /// </summary>
        public static void crearExcelPresupuesto(Presupuesto pres, TreeListView tree, string fileName)
        {
            // Creating DataTable
            DataTable dt = new DataTable();
            List<int> lstIndex = new List<int>();
            // Adding the Columns
            foreach (OLVColumn col in tree.GetFilteredColumns(tree.View))
            {
                dt.Columns.Add(col.AspectName);
                lstIndex.Add(col.LastDisplayIndex);
            }
            // Adding the Rows
            for (int i = 0; i < tree.Items.Count; i++)
            {
                dt.Rows.Add();
            }

            //Exporting to Excel
            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(dt, pres.nombre);
            var ws = wb.Worksheet(1);

            int row = 2;

            // Append Presupuesto
            //AnalisisItem item0 = Tools.GetItemFromPresupuesto(pres);
            string[] array0 = pres.ToExcelLine().Split('\t');
            int colum0 = 1;
            for (int i = 0; i < array0.Count(); i++)
            {
                if (lstIndex.Exists(x => x == i))
                {
                    ws.Cell(row, colum0).Value = array0[i];
                    ws.Cell(row, colum0).Style.Font.Bold = true;
                    colum0++;
                }
            }
            row++;

            // Append Childrens
            List<ItemPres> lstItems = new List<ItemPres>();
            ItemPres.getAllChildsOrden(pres, lstItems);
            //AnalisisItem.getAllChilds(item0, lstItems);

            foreach (ItemPres item in lstItems)
            {
                int colum = 1;
                switch (item.categoria)
                {
                    case "Presupuesto":
                        string[] array = item.ToExcelLine().Split('\t');
                        for (int i = 0; i < array.Count(); i++)
                        {
                            if (lstIndex.Exists(x => x == i))
                            {
                                ws.Cell(row, colum).Value = array[i];
                                ws.Cell(row, colum).Style.Font.Bold = true;
                                colum++;
                            }
                        }
                        break;
                    case "Grupo":
                        string[] array2 = item.ToExcelLine().Split('\t');
                        for (int i = 0; i < array2.Count(); i++)
                        {
                            if (lstIndex.Exists(x => x == i))
                            {
                                ws.Cell(row, colum).Value = array2[i];
                                ws.Cell(row, colum).Style.Font.Bold = true;
                                colum++;
                            }
                        }
                        break;
                    case "Item":
                        string[] array3 = item.ToExcelLine().Split('\t');
                        for (int i = 0; i < array3.Count(); i++)
                        {
                            if (lstIndex.Exists(x => x == i))
                            {
                                ws.Cell(row, colum).Value = array3[i];
                                colum++;
                            }
                        }
                        break;
                }
                row++;
            }
            wb.SaveAs(fileName);
        }

        /// <summary>
        /// Crea un Excel a partir de un TreeListView con Los Materiales
        /// </summary>
        public static void crearExcelRecursos(Presupuesto pres, TreeListView tree, string fileName)
        {
            // Creating DataTable
            DataTable dt = new DataTable();
            List<int> lstIndex = new List<int>();
            // Adding the Columns
            foreach (OLVColumn col in tree.GetFilteredColumns(tree.View))
            {
                dt.Columns.Add(col.AspectName);
                lstIndex.Add(col.LastDisplayIndex);
            }
            // Adding the Rows
            for (int i = 0; i < tree.Items.Count; i++)
            {
                dt.Rows.Add();
            }

            //Exporting to Excel
            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(dt, pres.nombre);
            var ws = wb.Worksheet(1);

            int row = 2;

            // Append Presupuesto
            //ItemRecurso item0 = pres.toItemRecurso();
            ItemRecurso item0 = pres.ToConsumoPres();
            string[] array0 = item0.toExcelLine().Split('\t');
            int colum0 = 1;
            for (int i = 0; i < array0.Count(); i++)
            {
                if (lstIndex.Exists(x => x == i))
                {
                    ws.Cell(row, colum0).Value = array0[i];
                    ws.Cell(row, colum0).Style.Font.Bold = true;
                    colum0++;
                }
            }
            row++;

            // Append Childrens
            foreach (ItemRecurso item in item0.GetChildrensOrden())
            {
                int colum = 1;
                switch (item.categoria)
                {
                    case "Presupuesto":
                        string[] array1 = item.toExcelLine().Split('\t');
                        for (int i = 0; i < array1.Count(); i++)
                        {
                            if (lstIndex.Exists(x => x == i))
                            {
                                ws.Cell(row, colum).Value = array1[i];
                                ws.Cell(row, colum).Style.Font.Bold = true;
                                colum++;
                            }
                        }
                        break;
                    case "Material":
                        string[] array2 = item.toExcelLine().Split('\t');
                        for (int i = 0; i < array2.Count(); i++)
                        {
                            if (lstIndex.Exists(x => x == i))
                            {
                                ws.Cell(row, colum).Value = array2[i];
                                colum++;
                            }
                        }
                        break;
                    case "Trabajo":
                        string[] array3 = item.toExcelLine().Split('\t');
                        for (int i = 0; i < array3.Count(); i++)
                        {
                            if (lstIndex.Exists(x => x == i))
                            {
                                ws.Cell(row, colum).Value = array3[i];
                                colum++;
                            }
                        }
                        break;
                    case "Equipo":
                        string[] array4 = item.toExcelLine().Split('\t');
                        for (int i = 0; i < array4.Count(); i++)
                        {
                            if (lstIndex.Exists(x => x == i))
                            {
                                ws.Cell(row, colum).Value = array4[i];
                                colum++;
                            }
                        }
                        break;
                }
                row++;
            }
            wb.SaveAs(fileName);
        }
        public static void crearHtml(string title, List<AnalisisItem> lstItems, string fileName)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<meta http-equiv='Content-Type' content='text/html; charset=utf-8'/>");
            sb.AppendLine("<h2>" + title + @"</h2>");
            sb.AppendLine("<table border='1' cellpadding='5'>");
            string titulos = "<th>" + "WBS" + "</th><th>" + "Name" + "</th><th>" + "Quantity" +
                    "</th><th>" + "Unit" + "</th><th>" + "Unit Cost" + "</th><th>" + "Total Cost" + "</th>";
            sb.AppendLine(titulos);
            foreach (AnalisisItem item in lstItems)
            {
                sb.AppendLine("<tr>");
                sb.AppendLine(item.toHtmlTable());
                sb.AppendLine("</tr>");
            }
            sb.AppendLine("</table>");
            File.WriteAllText(fileName, sb.ToString());
        }
        public static void crearExcelRecursos(string title, List<Recurso> lstRec, string fileName)
        {
            //Creating DataTable
            DataTable dt = new DataTable();
            //Adding the Columns
            dt.Columns.Add("Nombre Grupo");
            dt.Columns.Add("Nombre Recurso");
            dt.Columns.Add("Costo");
            dt.Columns.Add("Unidad");
            dt.Columns.Add("Unidad Comercial");
            dt.Columns.Add("Costo Comercial");
            dt.Columns.Add("Equivalencia");
            dt.Columns.Add("Tipo Recurso");
            foreach (Recurso rec in lstRec)
                dt.Rows.Add();

            //Exporting to Excel
            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(dt, "Resource Catalog");
            wb.Worksheet(1).Column(1).Width = 25;
            wb.Worksheet(1).Column(2).Width = 35;
            wb.Worksheet(1).Column(3).Width = 6;
            wb.Worksheet(1).Column(4).Width = 10;
            wb.Worksheet(1).Column(5).Width = 10;
            wb.Worksheet(1).Column(6).Width = 10;
            wb.Worksheet(1).Column(7).Width = 10;
            wb.Worksheet(1).Column(8).Width = 10;
            var ws = wb.Worksheet(1);

            int row = 2;
            foreach (Recurso rec in lstRec.OrderBy(x => x.nombre))
            {
                string[] array = rec.toExcelLine().Split('\t');
                for (int i = 0; i < array.Count(); i++)
                {
                    ws.Cell(row, i + 1).Value = array[i];
                }
                row += 1;
            }
            wb.SaveAs(fileName);
        }
        public static void crearExcelTareas(string title, List<Tarea> lstTarea, string fileName)
        {
            //Creating DataTable
            DataTable dt = new DataTable();
            DataTable dtR = new DataTable();
            //Adding the Columns
            dt.Columns.Add("Nombre Grupo");
            dt.Columns.Add("Nombre Item");
            dt.Columns.Add("Unidad");
            dt.Columns.Add("Detalles");

            dtR.Columns.Add("Nombre Item");
            dtR.Columns.Add("Nombre Recurso");
            dtR.Columns.Add("Consumo");
            dtR.Columns.Add("Unidad");

            foreach (Tarea tr in lstTarea)
            {
                dt.Rows.Add();
                foreach (ConsumoRecurso cr in tr.getConsumos())
                {
                    dtR.Rows.Add();
                }
            }

            //Exporting to Excel
            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(dt, "Catalogo Items");
            wb.Worksheet(1).Column(1).Width = 25;
            wb.Worksheet(1).Column(2).Width = 40;
            wb.Worksheet(1).Column(3).Width = 10;
            wb.Worksheet(1).Column(4).Width = 60;
            wb.Worksheets.Add(dtR, "Recursos de Items");
            wb.Worksheet(2).Column(1).Width = 25;
            wb.Worksheet(2).Column(2).Width = 35;
            wb.Worksheet(2).Column(3).Width = 10;
            wb.Worksheet(2).Column(4).Width = 6;
            var ws = wb.Worksheet(1);
            var wsR = wb.Worksheet(2);

            int row = 2;
            List<ConsumoRecurso> lst2 = new List<ConsumoRecurso>();
            foreach (Tarea tr in lstTarea.OrderBy(x => x.nombre))
            {
                string[] array = tr.toExcelLine().Split('\t');
                for (int i = 0; i < array.Count(); i++)
                {
                    ws.Cell(row, i + 1).Value = array[i];
                }
                foreach (ConsumoRecurso cr in tr.getConsumos())
                {
                    lst2.Add(cr);
                }
                row++;
            }
            int rowR = 2;
            foreach (ConsumoRecurso cr in lst2)
            {
                string[] array = cr.toExcelLine().Split('\t');
                for (int i = 0; i < array.Count(); i++)
                {
                    wsR.Cell(rowR, i + 1).Value = array[i];
                }
                rowR++;
            }
            wb.SaveAs(fileName);
        }
        #endregion
        #region Login
        public static string getUserfromDb()
        {
            string user = "";
            using (var datos = new DataAccess())
            {
                if (datos.getLoginDbs().Count > 0)
                {
                    loginDb login = datos.getLoginDbs()[0];
                    user = login.user;
                }
            };
            return user;
        }
        public static string getPasswordfromDb()
        {
            string password = "";
            using (var datos = new DataAccess())
            {
                if (datos.getLoginDbs().Count > 0)
                {
                    loginDb login = datos.getLoginDbs()[0];
                    password = login.password;
                }
            };
            return password;
        }
        /// <summary>
        /// Obtiene la Fecha de login de SQlite
        /// </summary>
        public static DateTime getDateFromDb()
        {
            DateTime date = DateTime.Now;
            using (var datos = new DataAccess())
            {
                if (datos.getLoginDbs().Count > 0)
                {
                    loginDb login = datos.getLoginDbs()[0];
                    date = login.fechaInicio;
                }
            };
            return date;
        }
        /// <summary>
        /// Return True if Exist a Login record in DataBase
        /// </summary>
        public static bool existLoginInDb()
        {
            bool exist = false;
            using (var datos = new DataAccess())
            {
                if (datos.getLoginDbs().Count > 0)
                {
                    exist = true;
                }
            };
            return exist;
        }
        /// <summary>
        /// Get the first record in the LoginDb Table
        /// </summary>
        public static loginDb getLoginFromDb()
        {
            loginDb login = new loginDb();
            using (var datos = new DataAccess())
            {
                login = datos.getLoginDbs()[0];
            };
            return login;
        }
        #endregion
        #region Xml
        /// <summary>
        /// Converts the Estimate to an Xml file
        /// </summary>
        public static void SaveEstimateToXml(Project pres, string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Project));
            TextWriter tw = new StreamWriter(path); // @"c:\temp\presupuesto.xml"
            xs.Serialize(tw, pres);
        }

        /// <summary>
        /// Guarda un Presupuesto en formato Xml
        /// </summary>
        public static void SavePresupuestoToXml(Presupuesto pres, string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Presupuesto));
            TextWriter tw = new StreamWriter(path); // @"c:\temp\presupuesto.xml"
            xs.Serialize(tw, pres);
        }

        /// <summary>
        /// Obtiene un Presupuesto de un archivo Xml
        /// </summary>
        public static Presupuesto LoadEstimateFromXml(string path)
        {
            Presupuesto pres = new Presupuesto();
            XmlSerializer xs = new XmlSerializer(typeof(Presupuesto));

            using (var sr = new StreamReader(path)) // @"c:\temp\presupuesto.xml"
            {
                pres = (Presupuesto)xs.Deserialize(sr);
            }
            return pres;
        }
        #endregion
        #region AnalisisItems
        /// <summary>
        /// Devuelve un AnalisisItem completo, a partir de un Presupuesto
        /// </summary>
        //public static AnalisisItem GetItemFromPresupuesto(Presupuesto pres)
        //{
        //    AnalisisItem item0 = pres.toItems();
        //    // Crear una Lista con todos los Items en bruto
        //    List<AnalisisItem> lstItems = new List<AnalisisItem>();
        //    List<AnalisisItem> lstItemsRubro = new List<AnalisisItem>();
        //    List<AnalisisItem> lstFinal = new List<AnalisisItem>();
            
        //    // Procesar TareasPres
        //    List<TareaPres> lstTareas = pres.getTareas();
        //    foreach (TareaPres tarea in lstTareas)
        //    {
        //        AnalisisItem item2 = tarea.toItems();
        //        lstItems.Add(item2);
        //    }
            
        //    // Procesar Grupos
        //    List<RubroPres> lstRubros = pres.getRubros();
        //    foreach (RubroPres rubro in lstRubros)
        //    {
        //        // Procesar Tareas recurrente
        //        AnalisisItem item2 = GetItemFromRubroPres(rubro);
        //        lstItemsRubro.Add(item2);
        //    }
        //    // Procesar Presupuesto
        //    item0.costoTotal = lstItems.Sum(x => x.costoTotal);
        //    item0.precioVenta = lstItems.Sum(x => x.precioVenta);
        //    item0.lstChilds = lstItemsRubro.FindAll(x => x.parentId == 0).ToList();
        //    return item0;
        //}
        //public static AnalisisItem GetItemFromPresupuesto(BackgroundWorker work, Presupuesto pres)
        //{
        //    AnalisisItem item0 = pres.toItems();
        //    // Crear una Lista con todos los Items en bruto
        //    List<AnalisisItem> lstItems = new List<AnalisisItem>();
        //    List<AnalisisItem> lstItemsRubro = new List<AnalisisItem>();
        //    List<AnalisisItem> lstFinal = new List<AnalisisItem>();
        //    int count = 1;
        //    int total = 1;
        //    // Procesar TareasPres
        //    List<TareaPres> lstTareas = pres.getTareas();
        //    total = lstTareas.Count;
        //    foreach (TareaPres tarea in lstTareas)
        //    {
        //        AnalisisItem item2 = tarea.toItems();
        //        lstItems.Add(item2);
        //        int progress = 100 * count / total;
        //        work.ReportProgress(progress);
        //        _status = "Procesando Item: " + tarea.nombre;
        //        count++;
        //    }

        //    // Procesar Grupos
        //    List<RubroPres> lstRubros = pres.getRubros();
        //    count = 1;
        //    total = lstRubros.Count;
        //    foreach (RubroPres rubro in lstRubros)
        //    {
        //        // Procesar Tareas recurrente
        //        AnalisisItem item2 = GetItemFromRubroPres(rubro);
        //        lstItemsRubro.Add(item2);
        //        int progress = 100 * count / total;
        //        work.ReportProgress(progress);
        //        _status = "Procesando Grupo: " + rubro.nombre;
        //        count++;
        //    }
        //    // Procesar Presupuesto
        //    item0.costoTotal = lstItems.Sum(x => x.costoTotal);
        //    item0.precioVenta = lstItems.Sum(x => x.precioVenta);
        //    item0.lstChilds = lstItemsRubro.FindAll(x => x.parentId == 0).ToList();
        //    return item0;
        //}
        public static AnalisisItem GetItemFromPresupuesto2(BackgroundWorker work, Presupuesto pres)
        {
            AnalisisItem item0 = pres.toItems();
            // Crear una Lista con todos los Items en bruto
            List<AnalisisItem> lstItems = new List<AnalisisItem>();
            List<AnalisisItem> lstItemsRubro = new List<AnalisisItem>();
            List<AnalisisItem> lstFinal = new List<AnalisisItem>();
            int count = 1;
            int total = 1;
            // Procesar TareasPres
            List<TareaPres> lstTareas = pres.getTareas();
            total = lstTareas.Count;
            foreach (TareaPres tarea in lstTareas)
            {
                AnalisisItem item2 = tarea.ToItem();
                lstItems.Add(item2);
                int progress = 100 * count / total;
                work.ReportProgress(progress);
                _status = "Procesando Item: " + tarea.nombre;
                count++;
            }

            // Procesar Grupos
            List<RubroPres> lstRubros = pres.getRubros();
            count = 1;
            total = lstRubros.Count;
            foreach (RubroPres rubro in lstRubros)
            {
                // Procesar Tareas recurrente
                AnalisisItem item2 = GetItemFromRubroPres2(rubro);
                lstItemsRubro.Add(item2);
                int progress = 100 * count / total;
                work.ReportProgress(progress);
                _status = "Procesando Grupo: " + rubro.nombre;
                count++;
            }
            // Procesar Presupuesto
            item0.costoTotal = lstItems.Sum(x => x.costoTotal);
            item0.precioVenta = lstItems.Sum(x => x.precioVenta);
            item0.lstChilds = lstItemsRubro.FindAll(x => x.parentId == 0).ToList();
            return item0;
        }
        /// <summary>
        /// Devuelve un AnalisisItem completo, a partir de un RubroPres
        /// </summary>
        //public static AnalisisItem GetItemFromRubroPres(RubroPres rubro)
        //{
        //    AnalisisItem item1 = rubro.toItems();
        //    Presupuesto pres = Presupuesto.getById(rubro.pres_id);

        //    // Crear una Lista con todos los Items en bruto
        //    List<AnalisisItem> lstItemsTarea = new List<AnalisisItem>();

        //    // Procesar TareasPres
        //    List<TareaPres> lstTareas = RubroPres.getAllTareas(rubro);
        //    foreach (TareaPres tarea in lstTareas)
        //    {
        //        AnalisisItem item2 = tarea.toItems();
        //        lstItemsTarea.Add(item2);
        //    }

        //    // Procesar el Grupo
        //    item1.costoTotal = lstItemsTarea.Sum(x => x.costoTotal);
        //    item1.precioVenta = lstItemsTarea.Sum(x => x.precioVenta);

        //    // Procesar Grupos hijos
        //    foreach (RubroPres rubro1 in rubro.getChilds())
        //    {
        //        // Procesar Tareas recurrente
        //        AnalisisItem item2 = GetItemFromRubroPres(rubro1);
        //        lstItemsTarea.Add(item2);
        //    }
            
        //    // Procesar Grupo
        //    item1.lstChilds = lstItemsTarea.FindAll(x => x.parentId == rubro.id).ToList();
        //    return item1;
        //}
        public static AnalisisItem GetItemFromRubroPres2(RubroPres rubro)
        {
            AnalisisItem item1 = rubro.toItems();
            Presupuesto pres = Presupuesto.getById(rubro.pres_id);

            // Crear una Lista con todos los Items en bruto
            List<AnalisisItem> lstItemsTarea = new List<AnalisisItem>();

            // Procesar TareasPres
            List<TareaPres> lstTareas = RubroPres.getAllTareas(rubro);
            foreach (TareaPres tarea in lstTareas)
            {
                AnalisisItem item2 = tarea.ToItem();
                lstItemsTarea.Add(item2);
            }

            // Procesar el Grupo
            item1.costoTotal = lstItemsTarea.Sum(x => x.costoTotal);
            item1.precioVenta = lstItemsTarea.Sum(x => x.precioVenta);

            // Procesar Grupos hijos
            foreach (RubroPres rubro1 in rubro.getChilds())
            {
                // Procesar Tareas recurrente
                AnalisisItem item2 = GetItemFromRubroPres2(rubro1);
                lstItemsTarea.Add(item2);
            }

            // Procesar Grupo
            item1.lstChilds = lstItemsTarea.FindAll(x => x.parentId == rubro.id).ToList();
            return item1;
        }
        #endregion
        #region Cache List
        public static void FillCacheList(Presupuesto pres)
        {
            List<ItemPres> lst = new List<ItemPres>();
            // Agregar Grupos
            lst.AddRange(pres.getRubros());
            // Agregar TareasPres
            lst.AddRange(pres.getTareas());
        }
        #endregion
    }
    
}
//String.Format("{0:c}", mat.precio);
