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

#region 
using System;
using System.Collections.Generic;
using System.Data;
using SQLite.Net.Attributes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Xml.Serialization;
using System.IO;
#endregion

namespace Qex
{
    public class Presupuesto : ItemPres
    {
        public string imagen { get; set; }
        public double indirectos { get; set; }
        public double generales { get; set; }
        public int proyecto_id { get; set; }
        public int op_decimales { get; set; }
        public double coef_resumen { get; set; }

        #region Constructors
        public Presupuesto()
        {
            this.imagen = string.Empty;
            this.categoria = "Presupuesto";
            this.indirectos = 0;
            this.generales = 0;
            this.proyecto_id = 0;
            this.op_decimales = 2;
            this.coef_resumen = 1;
        }
        public Presupuesto(string wbs, string nombre, double consumo, string unidad, double costoUnit,
             double costoTotal, double coef_resumen, double precioVenta, int rubropres_id, string imagen, 
             double indirectos, double generales, int proyecto_id, int op_decimales) : 
            base(wbs, nombre, consumo, unidad, costoUnit, costoTotal, precioVenta, rubropres_id, 0, 0)
        {
            this.id = 0;
            this.categoria = "Presupuesto";
            this.imagen = imagen;
            this.indirectos = indirectos;
            this.generales = generales;
            this.proyecto_id = proyecto_id;
            this.op_decimales = op_decimales;
            this.coef_resumen = coef_resumen;
        }
#endregion

        #region Conversions
        /// <summary>
        /// Convert the Estimate into TreeNode string
        /// </summary>
        public string toNodeText()
        {
            string cadena = string.Format("{0}", nombre);
            return cadena;
        }

        /// <summary>
        /// Convert the Estimate into a Treenode
        /// </summary>
        public TreeNode toNode()
        {
            TreeNode node = new TreeNode();
            node.Name = this.id.ToString();
            node.Text = this.nombre;
            node.ImageIndex = 0;
            node.SelectedImageIndex = 0;

            return node;
        }

        /// <summary>
        /// Convert the Estimate into a AnalisisItem. This Item can be used with a ListView control 
        /// </summary>
        public AnalisisItem toItems()
        {
            AnalisisItem item = new AnalisisItem();
            item.Category = "Presupuesto";
            item.id = this.id;
            item.parentId = 0;
            item.orden = 0;
            item.wbs = "";
            item.nombre = this.nombre.ToUpper();
            item.unidad = "";
            item.consumo = 0;
            item.coeficiente = this.coef_resumen;
            return item;
        }
        /// <summary>
        /// Convert the Estimate into a ItemRecurso. This Item can be used with a ListView control
        /// </summary>
        public ConsumoPres ToConsumoPres()//BackgroundWorker work)
        {
            ConsumoPres item = new ConsumoPres();
            item.id = this.id;
            item.nombre = this.nombre;
            item.categoria = "Presupuesto";
            List<ConsumoPres> lst = getConsumoRecursos();
            foreach (var cr in lst)
            {
                TareaPres tarea = TareaPres.getById(cr.tareapres_id);
                item.costoTotal += tarea.consumo * cr.consumo * cr.coeficiente * cr.costoUnit;
            }
            item.incidencia = 100.00;
            return item;
        }
        /// <summary>
        /// Converts the Estimate to an Xml file
        /// </summary>
        public void SaveToXml(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Presupuesto));
            TextWriter tw = new StreamWriter(path); // @"c:\temp\presupuesto.xml"
            xs.Serialize(tw, this);
        }

        public Task toMppTask(int id, int level)
        {
            Task tarea = new Task();
            tarea.UID = this.id;
            tarea.ID = id;
            tarea.Name = this.nombre;
            tarea.IsNull = 0;
            tarea.OutlineLevel = level;
            return tarea;
        }

        public Project toMppProject()
        {
            Project proj = new Project();
            proj.SaveVersion = 14;
            proj.Name = this.nombre;
            proj.Tasks = new List<Task>();
            int count = 1;
            int level = 1;
            List<Task> lst = new List<Task>();

            Task tarea0 = this.toMppTask(count, level);
            lst.Add(tarea0);
            count++;
            level++;

            List<RubroPres> lstParents = getRubrosParent();
            if (lstParents.Count > 0)
            {
                foreach (RubroPres rubro in lstParents)
                {
                    Task tarea = rubro.toMppTask(count, level);
                    lst.Add(tarea);
                    count++;
                    rubro.mppTareaChild(lst, count, level);
                }
            }
            proj.Tasks = lst;
            return proj;
        }
        #endregion

        #region DataBase
        /// <summary>
        /// Insert the Estimate into SQlite database
        /// </summary>
        public void insert()
        {
            this.UpdateCostos();
            //this.UpdateTieneHijos();
            using (var datos = new DataAccess())
            {
                datos.InsertPresupuesto(this);
            };
        }

        /// <summary>
        /// Delete the Estimate from SQlite database
        /// </summary>
        public void delete()
        {
            //Borrar RubrosPres
            foreach (RubroPres rubro in getRubros())
            {
                rubro.delete();
            }

            //Borrar Presupuesto
            using (var datos = new DataAccess())
            {
                datos.DeletePresupuesto(this);
            };
        }

        /// <summary>
        /// Actualiza el Presupuesto en la Base de Datos. Sin Cálculos
        /// </summary>
        public void Update()
        {
            this.UpdateCostos();
            using (var datos = new DataAccess())
            {
                datos.UpdatePresupuesto(this);
            };
        }

        /// <summary>
        /// Actualiza todos los Items y Grupos en la Base de Datos. Luego actualiza el Presupuesto 
        /// en la Base de Datos. Utiliza un BackGroundWorker
        /// </summary>
        public void UpdateAll(BackgroundWorker work)
        {
            Tools._status = "Actualizando...";
            work.ReportProgress(0);

            // Actualizar hijos
            List<TareaPres> lstTareas = getTareas();
            List<RubroPres> lstRubros = RubroPres.read().FindAll(x => x.pres_id == this.id);
            TareaPres.UpdateList(lstTareas, work);
            RubroPres.UpdateList(lstRubros, work);

            // Actualizar Presupuesto
            this.UpdateCostos();
            Tools._status = "Actualizando Presupuesto...";
            work.ReportProgress(99);
            using (var datos = new DataAccess())
            {
                datos.UpdatePresupuesto(this);
            };
            work.ReportProgress(100);
        }
        /// <summary>
        /// Actualiza todos los Items y Grupos en la Base de Datos. Luego actualiza el Presupuesto 
        /// en la Base de Datos
        /// </summary>
        public void UpdateAll()
        {
            // Actualizar Presupuesto
            this.UpdateCostos();
            using (var datos = new DataAccess())
            {
                datos.UpdatePresupuesto(this);
            };

            // Actualizar hijos
            List<TareaPres> lstTareas = getTareas();
            List<RubroPres> lstRubros = RubroPres.read().FindAll(x => x.pres_id == this.id);
            TareaPres.UpdateList(lstTareas);
            RubroPres.UpdateList(lstRubros);
        }

        /// <summary>
        /// Get the Estimate from Sqlite Database, based on its Id
        /// </summary>
        public static Presupuesto getById(int id)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetPresupuestoById(id);
            };
        }

        /// <summary>
        /// Get the Estimate from Sqlite Database, based on its Name
        /// </summary>
        public static Presupuesto getByNombre(string nombre)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetPresupuestos().FirstOrDefault(xx => xx.nombre == nombre);
            };
        }

        /// <summary>
        /// Get the List of all the Estimates in the Sqlite database
        /// </summary>
        public static List<Presupuesto> read()
        {
            using (var datos = new DataAccess())
            {
                return datos.GetPresupuestos();
            };
        }

        /// <summary>
        /// Get the folder for this Estimate
        /// </summary>
        public Proyecto getProyecto()
        {
            Proyecto pro = Proyecto.read().Find(x => x.id == this.proyecto_id);
            return pro;
        }
        #endregion

        #region Lists
        /// <summary>
        /// Get a list of ALL Groups in this Estimate (parents and children)
        /// </summary>
        public List<RubroPres> getRubros()
        {
            return RubroPres.read().FindAll(xx => xx.pres_id == this.id).ToList();
        }

        /// <summary>
        /// Gets a list with the Parent Groups of this Estimate
        /// </summary>
        public List<RubroPres> getRubrosParent()
        {
            return  getRubros().FindAll(xx => xx.rubropres_id == 0).ToList();
            //lst = lst.OrderBy(x => x.orden).ThenBy(y => y.nombre).ToList();
            //return lst;
        }

        /// <summary>
        /// Get a list with ALL Items in this Estimate (parents and children)
        /// </summary>
        public List<TareaPres> getTareas()
        {
            return TareaPres.read().FindAll(x => x.pres_id == this.id);
        }

        /// <summary>
        /// Gets a list of ALL Resource Quantities in the Estimate (parents and children)
        /// </summary>
        public List<ConsumoPres> getConsumoRecursos()
        {
            return ConsumoPres.read().FindAll(x => x.presId == this.id);
        }
        /// <summary>
        /// Obtiene una Lista con todos los ItemPres del Presupuesto
        /// </summary>
        public List<ItemPres> GetAllItemPres()
        {
            List<ItemPres> lst = new List<ItemPres>();
            lst.Add(this);
            List<RubroPres> lstRubros = new List<RubroPres>();
            foreach (var item in RubroPres.read().FindAll(x => x.pres_id == this.id))
            {
                lst.Add(item);
                lstRubros.Add(item);
            }
            foreach (var item in lstRubros)
            {
                foreach (var item1 in item.getTareas())
                {
                    lst.Add(item1);
                }
            }
            return lst;
        }
        #endregion

        #region Get
        /// <summary>
        /// Obtiene el último Presupuesto creado en la Base de Datos
        /// </summary>
        public static Presupuesto GetLast()
        {
            return Presupuesto.read().LastOrDefault();
        }
#endregion

        #region Calculations
        public double getRecursosCostoTotal()
        {
            double costoTotal = 0;
            foreach (ConsumoPres cp in getConsumoRecursos())
            {
                double costo = cp.consumo * cp.coeficiente * cp.getRecurso().precio;
                costoTotal += costo;
            }
            return costoTotal;
        }
        /// <summary>
        /// Calculates the Total Cost of the Estimate
        /// </summary>
        //public double CalcCostoTotal()
        //{
        //    double total = 0;
        //    foreach (TareaPres tarea in this.getTareas())
        //    {
        //        total += (tarea.getCostoTotal() * tarea.consumo);
        //    }
        //    return total;
        //}
        #endregion

        #region Xml
        /// <summary>
        /// Gets the Estimate from an Xml file
        /// </summary>
        public static Presupuesto GetEstimateFromXml(string path)
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

        #region Metodos Virtuales
        public override double GetCostoUnitario()
        {
            return 0;
        }

        public override double GetCostoTotal()
        {
            double costoTotal = 0;
            foreach (var item in getTareas())
            {
                costoTotal += item.costoTotal;
            }
            return costoTotal;
        }

        public override double GetPrecioVenta()
        {
            double precioVenta = GetCostoTotal() * this.coef_resumen;
            return precioVenta;
        }

        public override List<ItemPres> GetChildrens()
        {
            List<ItemPres> lst = new List<ItemPres>();
            foreach (var item in getRubrosParent())
            {
                lst.Add(item);
            }
            return lst;
        }
        public override List<ItemPres> GetChildrensOrden()
        {
            List<ItemPres> lst = new List<ItemPres>();
            foreach (var item in getRubrosParent())
            {
                lst.Add(item);
            }
            lst = lst.OrderBy(x => x.orden).ThenBy(x => x.nombre).ToList();
            return lst;
        }
        public override bool tieneRecursos()
        {
            return false;
        }

        public override void UpdateCostos()
        {
            this.costoUnitario = GetCostoUnitario();
            this.costoTotal = GetCostoTotal();
            this.precioVenta = GetPrecioVenta();
        }
        public override List<ItemPres> GetGrupos()
        {
            return GetChildrensOrden();
        }
        //public override void UpdateTieneHijos()
        //{
        //    bool hijos = false;
        //    if (this.GetChildrens().Count > 0)
        //    {
        //        hijos = true;
        //    }
        //    this.tieneHijos = hijos;
        //}
        #endregion
    }
}
