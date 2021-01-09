#region Using
using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Qex
{
    public abstract class ItemRecurso
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
        public double consumo { get; set; }
        public string unidad { get; set; }
        public string categoria { get; set; }
        public double consumoComercial { get; set; }
        public string unidadComercial { get; set; }
        public double costoUnit { get; set; }
        public double costoTotal { get; set; }
        public double incidencia { get; set; }
        public string wbs { get; set; }
        public int presId { get; set; }
        //public List<ItemRecurso> lstChild { get; set; }
        // Categories:
        // * Presupuesto
        // * Material
        // * Trabajo
        // * Equipo

        #region Constructores
        public ItemRecurso()
        {
            id = 0;
            nombre = string.Empty;
            consumo = 0;
            unidad = string.Empty;
            categoria = string.Empty;
            consumoComercial = 0;
            unidadComercial = string.Empty;
            costoUnit = 0;
            costoTotal = 0;
            incidencia = 0;
            wbs = string.Empty;
            presId = 0;
            //lstChild = new List<ItemRecurso>();
        }
        public ItemRecurso(string nombre, double consumo, string unidad, string categoria, double consumoComercial,
            string unidadComercial, double costoUnit, double costoTotal, double incidencia, string wbs, int presId)
        {
            this.id = 0;
            this.nombre = nombre;
            this.consumo = consumo;
            this.unidad = unidad;
            this.categoria = categoria;
            this.consumoComercial = consumoComercial;
            this.unidadComercial = unidadComercial;
            this.costoUnit = costoUnit;
            this.costoTotal = costoTotal;
            this.incidencia = incidencia;
            this.wbs = wbs;
            this.presId = presId;
            //this.lstChild = new List<ItemRecurso>();
        }
        #endregion

        #region Metodos Abstractos
        public abstract double GetCostoTotal();
        public abstract List<ItemRecurso> GetChildrens();
        public abstract List<ItemRecurso> GetChildrensOrden();
        public abstract void UpdateCostos();
        public abstract void UpdateCantComercial();
        public abstract double GetConsumoTotal();
            #endregion
        public string toExcelLine()
        {
            string line = "";
            switch (this.categoria)
            {
                case "Presupuesto":
                    line = this.nombre + "\t\t\t\t\t\t" + this.costoTotal + "\t" + 
                        this.incidencia + "\t" + this.wbs;
                    break;
                case "Material":
                    line = this.nombre + "\t" + this.consumo + "\t" + this.unidad + "\t" +
                    this.costoUnit + "\t" + this.consumoComercial + "\t" + this.unidadComercial + "\t" +
                    this.costoTotal + "\t" + this.incidencia + "\t" + this.wbs;
                    break;
                case "Trabajo":
                    line = this.nombre + "\t" + this.consumo + "\t" + this.unidad + "\t" +
                    this.costoUnit + "\t" + this.consumoComercial + "\t" + this.unidadComercial + "\t" +
                    this.costoTotal + "\t" + this.incidencia + "\t" + this.wbs;
                    break;
                case "Equipo":
                    line = this.nombre + "\t" + this.consumo + "\t" + this.unidad + "\t" +
                    this.costoUnit + "\t" + this.consumoComercial + "\t" + this.unidadComercial + "\t" +
                    this.costoTotal + "\t" + this.incidencia + "\t" + this.wbs;
                    break;
            }
            return line;
        }

        /// <summary>
        /// Obtains a list with all the ItemResources of the Estimate (parents and children)
        /// </summary>
        //public List<ItemRecurso> getChildrens()
        //{
        //    List<ItemRecurso> lst = new List<ItemRecurso>();
            
        //    if (this.categoria == "Presupuesto")
        //    {
        //        Presupuesto pres = Presupuesto.getById(this.id);
                
        //        foreach (ConsumoPres cp in pres.getConsumoRecursos())
        //        {
        //            // The resource exist in the list
        //            if (lst.Exists(x => x.nombre == cp.getRecurso().nombre))
        //            {
        //                ItemRecurso item = lst.Find(x => x.nombre == cp.getRecurso().nombre);
        //                Recurso rec = cp.getRecurso();
        //                TareaPres tarea = TareaPres.getById(cp.tareapres_id);
        //                double consumo = item.consumo;
        //                consumo += (cp.consumo * cp.coeficiente * tarea.consumo);
        //                item.consumo = consumo;
        //                item.consumoComercial = consumo / rec.venta_cantidad;
        //                item.costoTotal = consumo * cp.costoUnit;
        //            }
        //            // The resource not exist in the list
        //            else
        //            {
        //                ItemRecurso item = cp.ToItem();
        //                lst.Add(item);
        //            }
        //        }
        //    }
        //    lst = lst.OrderBy(x => x.categoria).ThenBy(x => x.nombre).ToList();
        //    return lst;
        //}
        /// <summary>
        /// Obtains a list with all the ItemResources of the Estimate (parents and children)
        /// </summary>
        //public List<ItemRecurso> getChildrens(BackgroundWorker work)
        //{
        //    List<ItemRecurso> lst = new List<ItemRecurso>();

        //    if (this.categoria == "Presupuesto")
        //    {
        //        Presupuesto pres = Presupuesto.getById(this.id);

        //        List<ConsumoPres> lista = pres.getConsumoRecursos();
        //        int count = 1;
        //        int total = lista.Count;
        //        foreach (ConsumoPres cp in lista)
        //        {
        //            // The resource exist in the list
        //            if (lst.Exists(x => x.nombre == cp.getRecurso().nombre))
        //            {
        //                ItemRecurso item = lst.Find(x => x.nombre == cp.getRecurso().nombre);
        //                Recurso rec = cp.getRecurso();
        //                TareaPres tarea = TareaPres.getById(cp.tareapres_id);
        //                double consumo = item.consumo;
        //                consumo += (cp.consumo * cp.coeficiente * tarea.consumo);
        //                item.consumo = consumo;
        //                item.consumoComercial = consumo / rec.venta_cantidad;
        //                item.costoTotal = consumo * cp.precioUnit;
        //            }
        //            // The resource not exist in the list
        //            else
        //            {
        //                ItemRecurso item = new ItemRecurso();
        //                Recurso rec = cp.getRecurso();
        //                TareaPres tarea = TareaPres.getById(cp.tareapres_id);
        //                item.id = rec.id;
        //                item.nombre = rec.nombre;
        //                item.categoria = rec.categoria;
        //                item.consumo = cp.consumo * cp.coeficiente * tarea.consumo;
        //                item.unidad = rec.unidad;
        //                item.consumoComercial = ((cp.consumo * cp.coeficiente * tarea.consumo) / rec.venta_cantidad);
        //                item.unidadComercial = rec.venta_unidad;
        //                item.costoUnit = cp.precioUnit;
        //                item.costoTotal = (cp.consumo * cp.coeficiente * tarea.consumo * cp.precioUnit);
        //                lst.Add(item);
        //            }
        //            int progress = 100 * count / total;
        //            work.ReportProgress(progress);
        //            Tools._status = "Procesando " + count + "/" + total;
        //            count++;
        //        }
        //    }
        //    lst = lst.OrderBy(x => x.categoria).ThenBy(x => x.nombre).ToList();
        //    return lst;
        //}
    }
}
