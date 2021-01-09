using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qex
{
    public class AnalisisItem
    {
        public string Category { get; set; }
        // Categorias:
        // * Presupuesto
        // * Grupo
        // * Item
        public int id { get; set; }
        public int parentId { get; set; }
        public int orden { get; set; }
        public string wbs { get; set; }
        public string nombre { get; set; }
        public double consumo { get; set; }
        public string unidad { get; set; }
        public double costoUnit { get; set; }
        public double costoMaterial { get; set; }
        public double costoManoObra { get; set; }
        public double costoEquipos { get; set; }
        public double costoTotal { get; set; }
        public double coeficiente { get; set; }
        public double precioVenta { get; set; }
        public double incidencia { get; set; }
        public List<AnalisisItem> lstChilds { get; set; }
        public bool tieneRecursos { get; set; }

#region Constructores
        public AnalisisItem()
        {
            Category = string.Empty;
            id = 0;
            parentId = 0;
            orden = 1;
            wbs = "1";
            nombre = string.Empty;
            consumo = 0;
            unidad = string.Empty;
            costoUnit = 0;
            costoMaterial = 0;
            costoManoObra = 0;
            costoEquipos = 0;
            costoTotal = 0;
            coeficiente = 1;
            precioVenta = 0;
            incidencia = 0;
            lstChilds = new List<AnalisisItem>();
            tieneRecursos = false;
        }
        #endregion
#region Verificaciones
        /// <summary>
        /// Verifica si el Item es un Grupo
        /// </summary>
        public bool isGroup()
        {
            bool isGrupo = false;
            if (this.Category == "Grupo")
            {
                isGrupo = true;
            }
            return isGrupo;
        }
        /// <summary>
        /// Verifica si el Item tiene SubItems de cualquier Categoria
        /// </summary>
        public bool hasChildrens()
        {
            bool tieneHijos = false;
            if (lstChilds.Count > 0)
            {
                tieneHijos = true;
            }
            return tieneHijos;
        }
        #endregion
#region Get
        /// <summary>
        /// Obtiene una lista con los SubItems
        /// </summary>
        /// <returns></returns>
        public List<AnalisisItem> getChildrens()
        {
            List<AnalisisItem> lst = this.lstChilds;
            lst = lst.OrderBy(x => x.orden).ThenBy(x => x.nombre).ToList();
            return lst;
        }
        /// <summary>
        /// Si el Item es un Grupo, devuelve el RubroPres original. Caso contrario devuelve null
        /// </summary>
        public RubroPres getRubroPres()
        {
            RubroPres rubro = null;
            if (this.isGroup())
            {
                rubro = RubroPres.getByid(this.id);
            }
            return rubro;
        }
        /// <summary>
        /// Si el Item es un Grupo, devuelve el RubroPres Padre. Caso contrario devuelve null
        /// </summary>
        public RubroPres getParent()
        {
            RubroPres rubro = null;
            if (this.isGroup())
            {
                rubro = RubroPres.getByid(this.parentId);
            }
            return rubro; 
        }
        /// <summary>
        /// Si el Item es un Item, devuelve la TareaPres original. Caso contrario devuelve null
        /// </summary>
        public TareaPres getTareaPres()
        {
            TareaPres tarea = null;
            if (this.Category == "Item")
            {
                tarea = TareaPres.getById(this.id);
            }
            return tarea;
        }
#endregion
        /// <summary>
        /// Actualiza toda la información de un AnalisisItem, a partir de otro AnalisisItem
        /// </summary>
        public void update(AnalisisItem item)
        {
            this.Category = item.Category;
            this.coeficiente = item.coeficiente;
            this.consumo = item.consumo;
            this.costoEquipos = item.costoEquipos;
            this.costoManoObra = item.costoManoObra;
            this.costoMaterial = item.costoMaterial;
            this.costoTotal = item.costoTotal;
            this.costoUnit = item.costoUnit;
            this.incidencia = item.incidencia;
            this.nombre = item.nombre;
            this.orden = item.orden;
            this.parentId = item.parentId;
            this.precioVenta = item.precioVenta;
            this.unidad = item.unidad;
            this.wbs = item.wbs;
            this.tieneRecursos = item.tieneRecursos;
            this.lstChilds = item.lstChilds;
        }
        /// <summary>
        /// Actualiza toda la información del AnalisisItem, consultando la Base de Datos
        /// </summary>
        //public void update()
        //{
        //    if (this.Category == "Presupuesto")
        //    {
        //        Presupuesto pres = Presupuesto.getById(this.id);
        //        this.update(Tools.GetItemFromPresupuesto(pres));
        //    }
        //    if (this.Category == "Grupo")
        //    {
        //        RubroPres grupo = RubroPres.getByid(this.id);
        //        this.update(Tools.GetItemFromRubroPres(grupo));
        //    }
        //    if (this.Category == "Item")
        //    {
        //        TareaPres tarea = TareaPres.getById(this.id);
        //        this.update(tarea.toItems());
        //    }
        //}
        public static void getAllChilds(AnalisisItem item, List<AnalisisItem> lst)
        {
            if (item.lstChilds != null)
            {
                foreach (AnalisisItem item1 in item.lstChilds)
                {
                    lst.Add(item1);
                    if (item1.lstChilds.Count > 0)
                    {
                        getAllChilds(item1, lst);
                    }
                }
            }
            lst = lst.OrderBy(x => x.orden).ThenBy(x => x.nombre).ToList();
        }
        public string toWordLine()
        {
            string line;
            if (this.Category == "Grupo")
            {
                line = this.wbs + "\t" + this.nombre + "\t\t\t\t" + string.Format("{0:c}", this.costoTotal);
            }
            else
            {
                line = this.wbs + "\t" + this.nombre + "\t" + this.consumo.ToString() + "\t" +
                    this.unidad + "\t" + string.Format("{0:c}", this.costoUnit) + "\t" +
                    string.Format("{0:c}", this.costoTotal);
            }
            return line;
        }

        public string toExcelLine()
        {
            string line = "";
            switch (this.Category)
            {
                case "Presupuesto":
                    line = this.nombre + "\t" + this.wbs + "\t\t\t\t" + this.costoTotal + "\t" +
                    this.coeficiente + "\t" + this.precioVenta + "\t" + this.orden;
                    break;
                case "Grupo":
                    line = this.nombre + "\t" + this.wbs + "\t\t\t\t" + this.costoTotal + "\t" +
                    this.coeficiente + "\t" + this.precioVenta + "\t" + this.orden;
                    break;
                case "Item":
                    line = this.nombre + "\t" + this.wbs + "\t" + this.consumo + "\t" +
                    this.unidad + "\t" + this.costoUnit + "\t" + this.costoTotal + "\t" +
                    this.coeficiente + "\t" + this.precioVenta + "\t" + this.orden;
                    break;
            }
            return line;
        }
        public string toHtmlTable()
        {
            string line;
            if (this.Category == "Grupo")
            {
                line = "<td style='font-weight:bold' align='right'>" + this.wbs + "</td><td style='font-weight:bold'>" +
                    this.nombre + "</td><td style='font-weight:bold'></td><td style='font-weight:bold'>" +
                    "</td><td style='font-weight:bold'></td><td style='font-weight:bold' align='right'>" + 
                    string.Format("{0:c}", this.costoTotal) + "</td>";
            }
            else
            {
                line = "<td align='right'>" + this.wbs + "</td><td>" + this.nombre + "</td><td align='center'>" + 
                    this.consumo.ToString() + "</td><td>" + this.unidad + "</td><td align='right'>" +
                    string.Format("{0:c}", this.costoUnit) + "</td><td align='right'>" + 
                    string.Format("{0:c}", this.costoTotal) + "</td>";
            }
            return line;
        }
    }
}
