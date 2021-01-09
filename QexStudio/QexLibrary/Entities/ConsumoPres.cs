#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using System.Data;
#endregion

namespace Qex
{
    public class ConsumoPres : ItemRecurso
    {
        //[PrimaryKey, AutoIncrement]
        //public int id { get; set; }
        public int tareapres_id { get; set; }
        public int recurso_id { get; set; }
        //public double consumo { get; set; }
        public double coeficiente { get; set; }
        //public double precioUnit { get; set; }
        //public string categoria { get; set; }

        #region Constructores
        public ConsumoPres()
        {
            //id = 0;
            tareapres_id = 0;
            recurso_id = 0;
            //consumo = 1;
            coeficiente = 1;
            //precioUnit = 0;
            //categoria = string.Empty;
        }
        public ConsumoPres(string nombre, double consumo, string unidad, string categoria, double consumoComercial,
            string unidadComercial, double costoUnit, double costoTotal, double incidencia, string wbs, 
            int tareapres_id, int recurso_id, double coeficiente, int presId) : 
            base(nombre, consumo, unidad, categoria, consumoComercial, unidadComercial, costoUnit, costoTotal, 
                incidencia, wbs, presId)
        {
            this.tareapres_id = tareapres_id;
            this.recurso_id = recurso_id;
            //this.consumo = consumo;
            this.coeficiente = coeficiente;
            //this.precioUnit = precioUnit;
            //this.categoria = categoria;
        }
        #endregion

        #region Base de Datos
        public void insert()
        {
            UpdateCostos();
            UpdateCantComercial();
            using (var datos = new DataAccess())
            {
                datos.InsertConsumoPres(this);
            };
        }
        public void delete()
        {
            using (var datos = new DataAccess())
            {
                datos.DeleteConsumoPres(this);
            };
        }
        public void update()
        {
            UpdateCostos();
            UpdateCantComercial();
            using (var datos = new DataAccess())
            {
                datos.UpdateConsumoPres(this);
            };
        }
        public static ConsumoPres getByCodigos(int tareapres_id, int recurso_id)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetConsumoPres().FirstOrDefault(xx => xx.tareapres_id == tareapres_id &&
                xx.recurso_id == recurso_id);
            };
        }
        
        public static List<ConsumoPres> read()
        {
            using (var datos = new DataAccess())
            {
                return datos.GetConsumoPres();
            };
        }
        #endregion

        #region Get
        public Recurso getRecurso()
        {
            Recurso obj = Recurso.getById(this.recurso_id);
            return obj;
        }

        public string getCategoria()
        {
            return getRecurso().categoria;
        }

        public TareaPres getTareaPres()
        {
            TareaPres obj = TareaPres.getById(this.tareapres_id);
            return obj;
        }

        //public double getCosto()
        //{
        //    double costo = this.consumo * this.coeficiente * this.precioUnit;
        //    return costo;
        //}
#endregion

        #region Metodos Virtuales
        public override double GetCostoTotal()
        {
            double costo = this.consumo * this.coeficiente * this.costoUnit;
            return costo;
        }

        public override List<ItemRecurso> GetChildrens()
        {
            List<ItemRecurso> lst = new List<ItemRecurso>();
            if (this.categoria == "Presupuesto")
            {
                Presupuesto pres = Presupuesto.getById(this.id);
                foreach (var item in pres.getConsumoRecursos())
                {
                    lst.Add(item);
                }
            }
            return lst;
        }

        public override List<ItemRecurso> GetChildrensOrden()
        {
            List<ItemRecurso> lst = new List<ItemRecurso>();
            if (this.categoria == "Presupuesto")
            {
                Presupuesto pres = Presupuesto.getById(this.id);
                foreach (var item in pres.getConsumoRecursos())
                {
                    double consumo = item.GetConsumoTotal();
                    double costoTotal = consumo * item.costoUnit;
                    double cantComercial = item.GetConsumoComercialTotal();
                    // El Recurso Existe en la Lista?
                    if (lst.Exists(x => x.nombre == item.nombre))
                    {
                        // SI Existe. Sumar consumo y costo
                        ItemRecurso item0 = lst.FirstOrDefault(x => x.nombre == item.nombre);
                        item0.consumo += consumo;
                        item0.costoTotal += costoTotal;
                        item0.consumoComercial += cantComercial;
                    }
                    else
                    {
                        // NO existe. Agregarlo
                        item.consumo = consumo;
                        item.costoTotal = costoTotal;
                        item.consumoComercial = cantComercial;
                        lst.Add(item);
                    }
                }
            }
            lst = lst.OrderBy(x => x.categoria).ThenBy(x => x.nombre).ToList();
            return lst;
        }

        public override void UpdateCantComercial()
        {
            Recurso rec = Recurso.getById(this.recurso_id);
            this.consumoComercial = this.consumo / rec.venta_cantidad;
        }

        public override void UpdateCostos()
        {
            this.costoTotal = GetCostoTotal();
        }

        public override double GetConsumoTotal()
        {
            TareaPres tarea = TareaPres.getById(this.tareapres_id);
            double consumoTotal = tarea.consumo * this.consumo * this.coeficiente;
            return consumoTotal;
        }
        public double GetConsumoComercialTotal()
        {
            TareaPres tarea = TareaPres.getById(this.tareapres_id);
            Recurso rec = Recurso.getById(this.recurso_id);
            double consumoTotal = tarea.consumo * this.consumo * this.coeficiente / rec.venta_cantidad;
            return consumoTotal;
        }

        #endregion
    }
}