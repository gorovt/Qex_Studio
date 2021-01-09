using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qex
{
    public abstract class ItemPres
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string categoria { get; set; }
        public string wbs { get; set; }
        public string nombre { get; set; }
        public double consumo { get; set; }
        public string unidad { get; set; }
        public double costoUnitario { get; set; }
        public double costoTotal { get; set; }
        //public double coef_resumen { get; set; }
        public double precioVenta { get; set; }
        public int rubropres_id { get; set; }
        public int orden { get; set; }
        public int pres_id { get; set; }
        //public bool tieneHijos { get; set; }

        #region Constructores
        public ItemPres()
        {
            this.id = 0;
            this.categoria = string.Empty;
            this.wbs = string.Empty;
            this.nombre = string.Empty;
            this.consumo = 0;
            this.unidad = string.Empty;
            this.costoUnitario = 0;
            this.costoTotal = 0;
            //this.coef_resumen = 1;
            this.precioVenta = 0;
            this.rubropres_id = 0;
            this.orden = 0;
            this.pres_id = 0;
            //this.tieneHijos = false;
        }
        public ItemPres(string wbs, string nombre, double consumo, string unidad, 
            double costoUnitario, double costoTotal, double precioVenta, int rubropres_id,
            int orden, int presId)
        {
            this.id = 0;
            this.categoria = string.Empty;
            this.wbs = wbs;
            this.nombre = nombre;
            this.consumo = consumo;
            this.unidad = unidad;
            this.costoUnitario = costoUnitario;
            this.costoTotal = costoTotal;
            //this.coef_resumen = coef_resumen;
            this.precioVenta = precioVenta;
            this.rubropres_id = rubropres_id;
            this.orden = orden;
            this.pres_id = presId;
            //this.tieneHijos = false;
        }
        #endregion

        #region Conversores
        public string ToExcelLine()
        {
            string line = "";
            switch (this.categoria)
            {
                case "Presupuesto":
                    line = this.nombre + "\t" + this.wbs + "\t\t\t\t" + this.costoTotal + "\t" +
                    this.precioVenta + "\t" + this.orden;
                    break;
                case "Grupo":
                    line = this.nombre + "\t" + this.wbs + "\t\t\t\t" + this.costoTotal + "\t" +
                    this.precioVenta + "\t" + this.orden;
                    break;
                case "Item":
                    line = this.nombre + "\t" + this.wbs + "\t" + this.consumo + "\t" +
                    this.unidad + "\t" + this.costoUnitario + "\t" + this.costoTotal + "\t" +
                    this.precioVenta + "\t" + this.orden;
                    break;
            }
            return line;
        }
#endregion

        #region Metodos Abstractos
        /// <summary>
        /// Obtiene la sumatoria de todos los ConsumoPres de las TareasPres: consumo * costoUnit * coef. 
        /// Los Presupuestos y RubrosPres NO tienen Costo Unitario
        /// </summary>
        public abstract double GetCostoUnitario();
        public abstract double GetCostoTotal();
        public abstract double GetPrecioVenta();
        public abstract List<ItemPres> GetChildrens();
        public abstract List<ItemPres> GetChildrensOrden();
        public abstract bool tieneRecursos();
        public abstract void UpdateCostos();
        public abstract List<ItemPres> GetGrupos();
        //public abstract void UpdateTieneHijos();
#endregion
        /// <summary>
        /// Convierte el ItemPres en un AnalisisItem
        /// </summary>
        public AnalisisItem ToItem()
        {
            AnalisisItem item = new AnalisisItem();
            item.id = this.id;
            item.Category = this.categoria;
            item.wbs = this.wbs;
            item.nombre = this.nombre;
            item.consumo = this.consumo;
            item.unidad = this.unidad;
            item.costoUnit = this.costoUnitario;
            item.costoTotal = this.costoTotal;
            item.coeficiente = 1;
            item.precioVenta = this.precioVenta;
            item.lstChilds = new List<AnalisisItem>();
            item.parentId = this.rubropres_id;
            if (this.tieneRecursos())
                item.tieneRecursos = true;

            return item;
        }

        public static void getAllChildsOrden(ItemPres item, List<ItemPres> lst)
        {
            List<ItemPres> lstHijos = item.GetChildrensOrden();
            if (lstHijos != null)
            {
                foreach (ItemPres item1 in lstHijos)
                {
                    lst.Add(item1);
                    if (item1.GetChildrensOrden().Count > 0)
                    {
                        getAllChildsOrden(item1, lst);
                    }
                }
            }
            lst = lst.OrderBy(x => x.orden).ThenBy(x => x.nombre).ToList();
        }
    }
}
