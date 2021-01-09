using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Qex;

namespace uiGR2020
{
    public partial class frmImportarTareasGR : Form
    {
        public string _status = "";
        public frmImportarTareasGR()
        {
            InitializeComponent();
            this.backgroundWorker1.RunWorkerAsync();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            _status = "Iniciando...";
            int actual = 0;
            int progreso = 0;

            //Importo los Grupos de Recursos
            List<GrupoRecurso> lstGrupos = Tools.importGruposFromExcel();
            foreach (GrupoRecurso grupo in lstGrupos)
            {
                if (!GrupoRecurso.read().Exists(x => x.nombre == grupo.nombre))
                {
                    grupo.insert();
                }
                actual += 1;
                progreso = Convert.ToInt32(100 * actual / lstGrupos.Count);
                this.backgroundWorker1.ReportProgress(progreso);
                _status = "(1/7) Importando Grupo: " + grupo.toNodeText();
            }
            actual = 0;

            //Importo los Materiales
            List<Recurso> lstMA = Tools.importMaterialFromExcel();
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
                actual += 1;
                progreso = Convert.ToInt32(100 * actual / lstMA.Count);
                this.backgroundWorker1.ReportProgress(progreso);
                _status = "(2/7) Importando Recurso: " + rec.nombre;
            }
            actual = 0;

            //Importo la Mano de Obra
            List<Recurso> lstMo = Tools.importManoObraFromExcel();
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
                actual += 1;
                progreso = Convert.ToInt32(100 * actual / lstMo.Count);
                this.backgroundWorker1.ReportProgress(progreso);
                _status = "(3/7) Importando Recurso: " + rec.nombre;
            }
            actual = 0;

            //Importo los Equipos
            List<Recurso> lstEq = Tools.importEquiposFromExcel();
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
                actual += 1;
                progreso = Convert.ToInt32(100 * actual / lstEq.Count);
                this.backgroundWorker1.ReportProgress(progreso);
                _status = "(4/7) Importando Recurso: " + rec.nombre;
            }
            actual = 0;

            //Importo los Rubros
            List<Rubro> lstRubros = Tools.importRubrosFromExcel();
            foreach (Rubro rubro in lstRubros)
            {
                if (!Rubro.read().Exists(x => x.nombre == rubro.nombre))
                {
                    rubro.insert();
                }
                actual += 1;
                progreso = Convert.ToInt32(100 * actual / lstRubros.Count);
                this.backgroundWorker1.ReportProgress(progreso);
                _status = "(5/7) Importando Rubro: " + rubro.toNodeText();
            }
            actual = 0;

            //Importo las tareas
            List<Tarea> lstTareas = Tools.importTareasFromExcel();
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
                actual += 1;
                progreso = Convert.ToInt32(100 * actual / lstTareas.Count);
                this.backgroundWorker1.ReportProgress(progreso);
                _status = "(6/7) Importando Item: " + tarea.nombre;
            }
            actual = 0;

            //Importo los consumos de Materiales, Mano de Obra y Equipos
            _status = "(7/7) Preparando la importación de recursos...";
            List<ConsumoRecurso> lstConsumoMat = Tools.importConsumos();
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
                actual += 1;
                progreso = Convert.ToInt32(100 * actual / lstConsumoMat.Count);
                this.backgroundWorker1.ReportProgress(progreso);
                _status = "(7/7) Importando Consumos... " + progreso + "%";
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
            this.lblStatus.Text = _status;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }
    }
}
