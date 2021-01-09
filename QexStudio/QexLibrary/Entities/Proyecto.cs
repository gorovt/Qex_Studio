using System;
using System.Collections.Generic;
using System.Data;
using SQLite.Net.Attributes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qex
{
    public class Proyecto
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
        public string ubicacion { get; set; }
        public string propietario { get; set; }

        public Proyecto()
        {
            id = 0;
            nombre = string.Empty;
            ubicacion = string.Empty;
            propietario = string.Empty;
        }

        public Proyecto(string nombre, string ubicacion, string propietario)
        {
            this.id = 0;
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            this.propietario = propietario;
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
                datos.InsertProyecto(this);
            };
        }

        public void delete()
        {
            using (var datos = new DataAccess())
            {
                datos.DeleteProyecto(this);
            };
        }

        public void update()
        {
            using (var datos = new DataAccess())
            {
                datos.UpdateProyecto(this);
            };
        }

        public static Proyecto getById(int id)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetProyectoById(id);
            };
        }

        public static Proyecto getByNombre(string nombre)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetProyectos().FirstOrDefault(xx => xx.nombre == nombre);
            };
        }

        public static List<Proyecto> read()
        {
            using (var datos = new DataAccess())
            {
                return datos.GetProyectos();
            };
        }
        public List<Presupuesto> getChilds()
        {
            List<Presupuesto> lst = new List<Presupuesto>();
            foreach (Presupuesto pres in Presupuesto.read())
            {
                if (pres.proyecto_id == this.id)
                {
                    lst.Add(pres);
                }
            }
            lst = lst.OrderBy(x => x.nombre).ToList();
            return lst;
        }
    }
}
