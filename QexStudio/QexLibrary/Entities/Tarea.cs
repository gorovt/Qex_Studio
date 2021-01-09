using System;
using System.Collections.Generic;
using System.Data;
using SQLite.Net.Attributes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qex
{
    public class Tarea
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
        public string unidad { get; set; }
        public string detalles { get; set; }
        public int rubro_Id { get; set; }
        public string sep = ";";
        public string code { get; set; }

        #region Constructores
        public Tarea()
        {
            nombre = string.Empty;
            unidad = string.Empty;
            detalles = string.Empty;
            rubro_Id = 0;
            code = string.Empty;
        }

        public Tarea(string nombre, string unidad, string detalles, int rubro_id, string code)
        {
            this.nombre = nombre;
            this.unidad = unidad;
            this.detalles = detalles;
            this.rubro_Id = rubro_id;
            this.code = code;
        }
        #endregion

        #region Conversiones
        public string toCode()
        {
            string code = this.nombre + this.sep + this.unidad + this.sep +
                this.detalles + this.sep + this.rubro_Id.ToString();
            return code;
        }
        public string toKeyNote()
        {
            string key = this.code + "\t" + this.nombre + "\t" + this.getParent().code;
            return key;
        }
        public string toExcelLine()
        {
            string line;
            Rubro rubro = this.getParent();
            line = rubro.nombre + "\t" + this.nombre + "\t" + this.unidad + "\t" + this.detalles;
            return line;
        }
        public string toLine()
        {
            string cadena = string.Format("Nombre: {0} [{1}]",
                nombre, unidad);
            return cadena;
        }

        public string toNodeText()
        {
            string cadena = string.Format("{0} [{1}]", nombre, unidad);
            return cadena;
        }
        #endregion

        #region Base de Datos
        public void insert()
        {
            using (var datos = new DataAccess())
            {
                datos.InsertTarea(this);
            }
        }
        public void delete()
        {
            //Borrar Recursos
            foreach (ConsumoRecurso cr in getConsumos())
            {
                cr.delete();
            }

            //Borrar Tarea
            using (var datos = new DataAccess())
            {
                datos.DeleteTarea(this);
            }
        }
        public void update()
        {
            using (var datos = new DataAccess())
            {
                datos.UpdateTarea(this);
            }
        }
        #endregion

        #region Get
        public static Tarea getById(int id)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetTareas().FirstOrDefault(xx => xx.id == id);
            }
        }
        public static Tarea getByNombre(string nombre)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetTareas().FirstOrDefault(xx => xx.nombre == nombre);
            }
        }
        public Rubro getParent()
        {
            Rubro rubro = Rubro.read().Find(x => x.id == this.rubro_Id);
            return rubro;
        }
        public static Tarea getLast()
        {
            using (var datos = new DataAccess())
            {
                return datos.GetTareas().Last();
            };
        }
        #endregion

        #region Listas
        public static List<Tarea> read()
        {
            using (var datos = new DataAccess())
            {
                return datos.GetTareas();
            }
        }
        public List<ConsumoRecurso> getConsumos()
        {
            List<ConsumoRecurso> lst = new List<ConsumoRecurso>();
            foreach (ConsumoRecurso cm in ConsumoRecurso.read())
            {
                if (cm.tarea_id == this.id)
                {
                    lst.Add(cm);
                }
            }
            return lst;
        }
        public List<ConsumoItem> getConsumoItems()
        {
            List<ConsumoItem> lst = new List<ConsumoItem>();
            foreach (ConsumoRecurso cr in this.getConsumos())
            {
                ConsumoItem item = cr.toConsumoItem();
                lst.Add(item);
            }
            return lst;
        }
        #endregion

        #region Calculos
        public double GetCostoUnitario()
        {
            double total = 0;
            foreach (ConsumoRecurso cr in getConsumos())
            {
                total += cr.consumo * cr.coeficiente * cr.getRecurso().precio;
            }
            return total;
        }
#endregion
    }
}
