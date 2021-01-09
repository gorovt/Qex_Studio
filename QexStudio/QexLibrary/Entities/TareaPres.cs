#region Using
using System;
using System.Collections.Generic;
using System.Data;
using SQLite.Net.Attributes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
#endregion
namespace Qex
{
    public class TareaPres : ItemPres
    {
        //public int orden { get; set; }

        #region Constructores
        public TareaPres()
        {
            //this.orden = 1;
            this.categoria = "Item";
        }

        public TareaPres(string wbs, string nombre, double consumo, string unidad, double costoUnit,
             double costoTotal, double coef_resumen, double precioVenta, int orden, int rubropres_id, int presId) :
            base(wbs, nombre, consumo, unidad, costoUnit, costoTotal, precioVenta, rubropres_id, orden, presId)
        {
            this.id = 0;
            this.categoria = "Item";
            //this.orden = orden;
        }
        #endregion

        #region Conversiones
        public string toNodeText()
        {
            string cadena = string.Format("{0} - {1} [{2} {3}]", orden, nombre, consumo, unidad);
            return cadena;
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
        /// <summary>
        /// Convierte la TareaPres en un AnalisisItem
        /// </summary>
        //public AnalisisItem toItems()
        //{
        //    Presupuesto pres = Presupuesto.getById(this.getParent().pres_id);
        //    AnalisisItem item1 = new AnalisisItem();
        //    RubroPres rubro = this.getParent();
        //    item1.Category = "Item";
        //    item1.id = this.id;
        //    item1.orden = this.orden;
        //    item1.parentId = rubro.id;
        //    item1.nombre = this.nombre;
        //    item1.consumo = this.consumo;
        //    item1.unidad = this.unidad;
        //    item1.coeficiente = pres.coef_resumen;
        //    item1.wbs = this.wbs;
        //    item1.costoUnit = this.getCostoTotal();
        //    item1.costoTotal = item1.costoUnit * this.consumo;
        //    item1.precioVenta = item1.costoTotal * item1.coeficiente;
        //    if (this.getConsumos().Count > 0)
        //    {
        //        item1.tieneRecursos = true;
        //    }
        //    return item1;
        //}
        #endregion

        #region Calculos
        public void updateWbs()
        {
            this.wbs = this.getParent().wbs + "." + this.orden.ToString();
        }
#endregion

        #region Base Datos
        /// <summary>
        /// Inserta una TareaPres en la Base de Datos
        /// </summary>
        public void insert()
        {
            this.updateWbs();
            this.UpdateCostos();
            using (var datos = new DataAccess())
            {
                datos.InsertTareaPres(this);
            };
        }

        /// <summary>
        /// Inserta una Lista de TareaPres en la Base de Datos
        /// </summary>
        public static void InsertList(List<TareaPres> lst)
        {
            using (var datos = new DataAccess())
            {
                datos.InsertTareaPresList(lst);
            };
        }

        /// <summary>
        /// Inserta una Lista de TareaPres en la Base de Datos
        /// </summary>
        public static void InsertList(List<TareaPres> lst, BackgroundWorker work)
        {
            using (var datos = new DataAccess())
            {
                datos.InsertTareaPresList(lst, work);
            };
        }

        /// <summary>
        /// Borra una TareaPres de la Base de Datos
        /// </summary>
        public void delete()
        {
            //Borrar Recursos
            foreach (ConsumoPres cp in getConsumos())
            {
                cp.delete();
            }

            //Borrar TareaPres
            using (var datos = new DataAccess())
            {
                datos.DeleteTareaPres(this);
            };
        }

        /// <summary>
        /// Borra una Lista de TareaPres de la Base de Datos
        /// </summary>
        public static void DeleteList(List<TareaPres> lst)
        {
            using (var datos = new DataAccess())
            {
                datos.DeleteTareaPresList(lst);
            };
        }

        /// <summary>
        /// Actualiza la TareaPres en la Base de Datos
        /// </summary>
        public void update()
        {
            this.updateWbs();
            this.UpdateCostos();
            using (var datos = new DataAccess())
            {
                datos.UpdateTareaPres(this);
            };
        }

        /// <summary>
        /// Actualiza una Lista de TareaPres en la Base de Datos
        /// </summary>
        public static void UpdateList(List<TareaPres> lst)
        {
            foreach (var item in lst)
            {
                item.updateWbs();
                item.UpdateCostos();
            }
            using (var datos = new DataAccess())
            {
                datos.UpdateTareaPresList(lst);
            };
        }

        /// <summary>
        /// Actualiza una Lista de TareaPres en la Base de Datos
        /// </summary>
        public static void UpdateList(List<TareaPres> lst, BackgroundWorker work)
        {
            int count = 1;
            int total = lst.Count;
            int progress = 0;

            foreach (var item in lst)
            {
                item.updateWbs();
                item.UpdateCostos();
                progress = 100 * count / total;
                Tools._status = "Actualizando Costos (" + count + "/" + total + ")";
                work.ReportProgress(progress);
                count++;
            }
            using (var datos = new DataAccess())
            {
                datos.UpdateTareaPresList(lst, work);
            };
        }
        #endregion

        #region Get
        public static TareaPres getById(int id)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetTareaPresById(id);
            };
        }
        public static TareaPres getByPresIdAndNombres(int presId, string tareaNombre, string grupoNombre, 
            string libroName)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetTareasPres().FirstOrDefault(x => x.pres_id == presId && x.nombre == tareaNombre &&
                x.getParent().nombre == grupoNombre && x.getParent().getParent().nombre == libroName);
            };
        }
        /// <summary>
        /// Obtiene el nombre del Grupo padre
        /// </summary>
        public string GetRubroName()
        {
            RubroPres rubro = RubroPres.getByid(this.rubropres_id);
            return rubro.nombre;
        }
        public static List<TareaPres> read()
        {
            using (var datos = new DataAccess())
            {
                return datos.GetTareasPres();
            };
        }
        public RubroPres getParent()
        {
            RubroPres rubro = RubroPres.getByid(this.rubropres_id);
            return rubro;
        }
        /// <summary>
        /// Obtiene el Presupuesto padre de esta TareaPres
        /// </summary>
        public Presupuesto GetPresupuesto()
        {
            Presupuesto pres = Presupuesto.getById(this.pres_id);
            return pres;
        }
        /// <summary>
        /// Obtiene una lista de los Consumos de esta TareaPres
        /// </summary>
        public List<ConsumoPres> getConsumos()
        {
            return ConsumoPres.read().FindAll(x => x.tareapres_id == this.id);
        }
        public List<ConsumoPresItem> getConsumoItems()
        {
            List<ConsumoPresItem> lst = new List<ConsumoPresItem>();
            foreach (ConsumoPres cp in this.getConsumos())
            {
                Recurso rec = cp.getRecurso();
                ConsumoPresItem ci = new ConsumoPresItem();
                ci.tareapres_id = this.id;
                ci.recurso_id = rec.id;
                ci.recurso_nombre = rec.nombre;
                ci.consumo = cp.consumo;
                ci.consumo_unidad = rec.unidad;
                ci.recurso_precio = cp.costoUnit;
                ci.coeficiente = cp.coeficiente;
                ci.subTotal = cp.consumo * cp.costoUnit * cp.coeficiente;
                ci.categoria = rec.categoria;
                lst.Add(ci);
            }
            return lst;
        }
        /// <summary>
        /// Devuelve la suma de Costo de todos los Consumos de la TareaPres
        /// </summary>
        //public double getCostoTotal()
        //{
        //    double costoUnit = 0;
        //    foreach (ConsumoPres cp in getConsumos())
        //    {
        //        double costo = cp.getCosto();
        //        costoUnit += costo;
        //    }
        //    return costoUnit;
        //}
        //public double getCostoMaterial()
        //{
        //    double costoMat = 0;
        //    foreach (ConsumoPres cp in getConsumos())
        //    {
        //        if (cp.getCategoria() == "Material")
        //        {
        //            double costo = cp.getCosto();
        //            costoMat += costo;
        //        }
        //    }
        //    return costoMat;
        //}
        //public double getCostoManoObra()
        //{
        //    double costoMo = 0;
        //    foreach (ConsumoPres cp in getConsumos())
        //    {
        //        if (cp.getCategoria() == "Trabajo")
        //        {
        //            double costo = cp.getCosto();
        //            costoMo += costo;
        //        }
        //    }
        //    return costoMo;
        //}
        //public double getCostoEquipo()
        //{
        //    double costoEq = 0;
        //    foreach (ConsumoPres cp in getConsumos())
        //    {
        //        if (cp.getCategoria() == "Equipo")
        //        {
        //            double costo = cp.getCosto();
        //            costoEq += costo;
        //        }
        //    }
        //    return costoEq;
        //}
        #endregion

        #region Metodos Virtuales Override
        /// <summary>
        /// Obtiene la sumatoria de todos los ConsumoPres: consumo * costoUnit * coef
        /// </summary>
        public override double GetCostoUnitario()
        {
            double costoUnit = 0;
            foreach (var item in getConsumos())
            {
                costoUnit += (item.consumo * item.costoUnit * item.coeficiente);
            }
            return costoUnit;
        }
        /// <summary>
        /// Se debe calcular primero el CostoUnitario de la TareaPres. Se multiplica el Consumo * Costo Unitario
        /// de la TareaPres
        /// </summary>
        public override double GetCostoTotal()
        {
            double costoTotal = this.consumo * this.costoUnitario;
            return costoTotal;
        }
        /// <summary>
        /// Previamente se debe calcular primero el CostoUnitario, y luego el CostoTotal de la TareaPres. 
        /// Se multiplica el Coeficiente * CostoTotal de la TareaPres
        /// </summary>
        public override double GetPrecioVenta()
        {
            double precioVenta = this.costoTotal * this.GetPresupuesto().coef_resumen;
            return precioVenta;
        }
        /// <summary>
        /// Las TareasPres NO tienen hijos. Se obtiene una Lista vacía
        /// </summary>
        public override List<ItemPres> GetChildrens()
        {
            List<ItemPres> lst = new List<ItemPres>();
            return lst;
        }
        public override List<ItemPres> GetChildrensOrden()
        {
            List<ItemPres> lst = new List<ItemPres>();
            return lst;
        }
        /// <summary>
        /// Se actualizan todos los Costos de la TareaPres
        /// </summary>
        public override void UpdateCostos()
        {
            this.costoUnitario = GetCostoUnitario();
            this.costoTotal = GetCostoTotal();
            //this.coef_resumen = GetPresupuesto().coef_resumen;
            this.precioVenta = GetPrecioVenta();
        }
        /// <summary>
        /// Devuelve True si la TareaPres tiene Consumos de Recursos
        /// </summary>
        public override bool tieneRecursos()
        {
            bool tiene = false;
            if (this.getConsumos().Count > 0)
            {
                tiene = true;
            }
            return tiene;
        }
        public override List<ItemPres> GetGrupos()
        {
            return new List<ItemPres>();
        }
        //public override void UpdateTieneHijos()
        //{
        //    this.tieneHijos = false;
        //}
        #endregion
    }
}
