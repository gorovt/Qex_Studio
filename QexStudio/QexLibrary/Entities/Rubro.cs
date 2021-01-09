using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using System.Data;

namespace Qex
{
    public class Rubro
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
        public string code { get; set; }
        public string sep = ";";

        public Rubro()
        {
            nombre = string.Empty;
            code = string.Empty;
        }
        public Rubro(string nombre, string code)
        {
            this.nombre = nombre;
            this.code = code;
        }
        public string toCode()
        {
            string code = this.nombre;
            return code;
        }
        public string toLine()
        {
            string cadena = string.Format("Nombre: {0}",
                nombre);
            
            return cadena;
        }
        public string toKeyNote()
        {
            string key = this.code + "\t" + this.nombre;
            return key;
        }
        public string toNodeText()
        {
            string cadena = string.Format("{0}", nombre);
            return cadena;
        }
        public void insert()
        {
            using (var datos = new DataAccess())
            {
                datos.InsertRubro(this);
            };
        }
        public void delete()
        {
            using (var datos = new DataAccess())
            {
                datos.DeleteRubro(this);
            };
        }
        public void update()
        {
            using (var datos = new DataAccess())
            {
                datos.UpdateRubro(this);
            };
        }
        public static Rubro getById(int id)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetRubros().FirstOrDefault(xx => xx.id == id);
            };
        }
        public static Rubro getByNombre(string nombre)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetRubros().FirstOrDefault(xx => xx.nombre == nombre);
            };
        }
        public static List<Rubro> read()
        {
            using (var datos = new DataAccess())
            {
                return datos.GetRubros();
            };
        }

        public List<Tarea> getChilds()
        {
            List<Tarea> lst = new List<Tarea>();
            foreach (Tarea tarea in Tarea.read())
            {
                if (tarea.rubro_Id == this.id)
                {
                    lst.Add(tarea);
                }
            }
            lst = lst.OrderBy(x => x.nombre).ToList();
            return lst;
        }
        public static Rubro getLast()
        {
            using (var datos = new DataAccess())
            {
                return datos.GetRubros().Last();
            };
        }
    }
}