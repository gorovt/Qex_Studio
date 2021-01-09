using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
//using System.Data;

namespace Qex
{
    public class GrupoRecurso
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
        public string sep = ";";

        public GrupoRecurso()
        {
            id = 0;
            nombre = string.Empty;
        }
        public GrupoRecurso(string nombre)
        {
            this.id = 0;
            this.nombre = nombre;
        }
        public string toCode()
        {
            string code = this.id.ToString() + this.sep + this.nombre;
            return code;
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
                datos.InsertGrupoRecurso(this);
            };
        }
        public void delete()
        {
            using (var datos = new DataAccess())
            {
                datos.DeleteGrupoRecurso(this);
            };
        }
        public void update()
        {
            using (var datos = new DataAccess())
            {
                datos.UpdateGrupoRecurso(this);
            };
        }
        public static GrupoRecurso getById(int id)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetGrupoRecursoById(id);
            };
        }
        public static GrupoRecurso getByNombre(string nombre)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetGrupoRecursos().FirstOrDefault(xx => xx.nombre == nombre);
            };
        }
        public static List<GrupoRecurso> read()
        {
            using (var datos = new DataAccess())
            {
                return datos.GetGrupoRecursos();
            };
        }

        public List<Recurso> getChilds()
        {
            List<Recurso> lst = new List<Recurso>();
            foreach (Recurso mat in Recurso.read())
            {
                if (mat.grupo_id == this.id)
                {
                    lst.Add(mat);
                }
            }
            lst = lst.OrderBy(x => x.id).ToList();
            return lst;
        }
        public static GrupoRecurso getLast()
        {
            using (var datos = new DataAccess())
            {
                return datos.GetGrupoRecursos().Last();
            };
        }
    }
}