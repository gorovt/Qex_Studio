using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using System.Data;

namespace Qex
{
    public class Recurso
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
        // There are 3 Categories: Material, Labor and Equipment
        public string categoria { get; set; }
        public double precio { get; set; }
        public string unidad { get; set; }
        public DateTime ultima_actualizacion { get; set; }
        public int proveedor_id { get; set; }
        public double venta_cantidad { get; set; }
        public string venta_unidad { get; set; }
        public double precio_venta { get; set; }
        public int grupo_id { get; set; }
        public string codigo_comercial { get; set; }
        public string nombre_comercial { get; set; }
        public string sep = ";";

        #region Constructores
        public Recurso()
        {
            nombre = string.Empty;
            categoria = string.Empty;
            precio = 0;
            unidad = string.Empty;
            ultima_actualizacion = DateTime.Now;
            proveedor_id = 0;
            venta_cantidad = 1;
            venta_unidad = string.Empty;
            precio_venta = 0;
            grupo_id = 0;
            codigo_comercial = string.Empty;
            nombre_comercial = string.Empty;
        }
        public Recurso(string nombre, string categoria, double precio, string unidad, 
            DateTime ultima_actualizacion, int proveedor_id, double venta_cantidad, string venta_unidad,
            double precio_venta, int grupo_id, string codigo_comercial, string nombre_comercial)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.precio = precio;
            this.unidad = unidad;
            this.ultima_actualizacion = ultima_actualizacion;
            this.proveedor_id = proveedor_id;
            this.venta_cantidad = venta_cantidad;
            this.venta_unidad = venta_unidad;
            this.precio_venta = precio_venta;
            this.grupo_id = grupo_id;
            this.codigo_comercial = codigo_comercial;
            this.nombre_comercial = nombre_comercial;
        }
        #endregion
        #region Conversiones
        public string toCode()
        {
            string code = "";
            code = this.id.ToString() + this.sep + this.nombre + this.sep + this.categoria + this.sep +
                this.precio.ToString() + this.sep + this.unidad + this.sep + this.ultima_actualizacion.ToString() +
                this.sep + this.proveedor_id.ToString() + this.sep + this.venta_cantidad.ToString() + this.sep +
                this.venta_unidad + this.sep + this.precio_venta.ToString() + this.sep + this.grupo_id.ToString() +
                this.sep + this.codigo_comercial + this.sep + this.nombre_comercial;
            return code;
        }

        public string toLine()
        {
            string cadena = string.Format("Nombre: {0} [{1}]", nombre, unidad);
            
            return cadena;
        }
        public string toExcelLine()
        {
            string line;
            GrupoRecurso grupo = this.getParent();
            line = grupo.nombre + "\t" + this.nombre + "\t" + this.precio + "\t" +
                    this.unidad + "\t" + this.venta_unidad + "\t" + this.precio_venta +
                    "\t" + this.venta_cantidad + "\t" + this.categoria;
            return line;
        }
        public string toNodeText()
        {
            string cadena = string.Format("{0} [{1}]", nombre, unidad);
            return cadena;
        }
#endregion
        public void insert()
        {
            using (var datos = new DataAccess())
            {
                datos.InsertRecurso(this);
            };
        }
        public void delete()
        {
            using (var datos = new DataAccess())
            {
                datos.DeleteRecurso(this);
            };
        }
        public void update()
        {
            using (var datos = new DataAccess())
            {
                datos.UpdateRecurso(this);
            };
        }
        public static Recurso getById(int id)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetRecursoById(id);
            };
        }
        public static Recurso getByNombre(string nombre)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetRecursos().FirstOrDefault(xx => xx.nombre == nombre);
            };
        }
        public static List<Recurso> read()
        {
            using (var datos = new DataAccess())
            {
                return datos.GetRecursos();
            };
        }
        public GrupoRecurso getParent()
        {
            GrupoRecurso grupo = GrupoRecurso.getById(this.grupo_id);
            return grupo;
        }
        public List<ConsumoRecurso> getConsumos()
        {
            List<ConsumoRecurso> lst = new List<ConsumoRecurso>();
            foreach (ConsumoRecurso cm in ConsumoRecurso.read())
            {
                if (cm.recurso_id == this.id)
                {
                    lst.Add(cm);
                }
            }
            return lst;
        }
        public bool isUsed()
        {
            //Verifica si el recurso es usado en algún Item del Item Catalog
            if (ConsumoRecurso.read().Exists(xx => xx.recurso_id == this.id))
            {
                return true;
            }
            //Verifica si el recurso es usado en algún Item de las Estimaciones
            if (ConsumoPres.read().Exists(xx => xx.recurso_id == this.id))
            {
                return true;
            }
            return false;
        }
        public List<Tarea> getTareaUsed()
        {
            List<Tarea> lst = new List<Tarea>();
            List<ConsumoRecurso> lstConsumos = ConsumoRecurso.read().FindAll(xx => xx.recurso_id == this.id);
            foreach (ConsumoRecurso cons in lstConsumos)
            {
                if (!lst.Exists(xx => xx.id == cons.tarea_id))
                {
                    lst.Add(cons.getTarea());
                }
            }
            return lst;
        }
        public List<TareaPres> getTareaPresUsed()
        {
            List<TareaPres> lst = new List<TareaPres>();
            List<ConsumoPres> lstConsumos = ConsumoPres.read().FindAll(xx => xx.recurso_id == this.id);
            foreach (ConsumoPres cp in lstConsumos)
            {
                if (!lst.Exists(xx => xx.id == cp.tareapres_id))
                {
                    lst.Add(cp.getTareaPres());
                }
            }
            return lst;
        }
        public static Recurso getLast()
        {
            using (var datos = new DataAccess())
            {
                return datos.GetRecursos().Last();
            };
        }
    }
}