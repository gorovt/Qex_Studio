using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using System.Data;

namespace Qex
{
    public class ConsumoRecurso
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public int tarea_id { get; set; }
        public int recurso_id { get; set; }
        public double consumo { get; set; }
        public double coeficiente { get; set; }
        //public string categoria { get; set; }
        public string sep = ";";

        public ConsumoRecurso()
        {
            tarea_id = 0;
            recurso_id = 0;
            consumo = 1;
            coeficiente = 1;
            //categoria = string.Empty;
        }
        public ConsumoRecurso(int tarea_id, int recurso_id, double consumo, double coeficiente)
        {
            this.tarea_id = tarea_id;
            this.recurso_id = recurso_id;
            this.consumo = consumo;
            this.coeficiente = coeficiente;
            //this.categoria = categoria;
        }
        public string toCode()
        {
            string code = this.tarea_id + this.sep + this.recurso_id.ToString() + this.sep +
                this.consumo.ToString() + this.sep + this.coeficiente.ToString();// + this.sep + this.categoria;
            return code;
        }
        public string toExcelLine()
        {
            string line;
            Tarea tarea = this.getTarea();
            Recurso rec = this.getRecurso();
            line = tarea.nombre + "\t" + rec.nombre + "\t" + this.consumo + "\t" +
                    rec.unidad;
            return line;
        }
        public string toNodeText()
        {
            Recurso rec = this.getRecurso();
            string text = string.Format("{0} [{1} {2}]", rec.nombre, this.consumo, rec.unidad);
            return text;
        }
        public void insert()
        {
            using (var datos = new DataAccess())
            {
                datos.InsertConsumoRecurso(this);
            };
        }
        public void delete()
        {
            using (var datos = new DataAccess())
            {
                datos.DeleteConsumoRecurso(this);
            };
        }
        public void update()
        {
            using (var datos = new DataAccess())
            {
                datos.UpdateConsumoRecurso(this);
            };
        }
        public static ConsumoRecurso getByCodigos(int tarea_id, int recurso_id) //, string categoria)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetConsumoRecurso().FirstOrDefault(xx => xx.tarea_id == tarea_id &&
                xx.recurso_id == recurso_id); // && xx.categoria == categoria);
            };
        }
        public static List<ConsumoRecurso> read()
        {
            using (var datos = new DataAccess())
            {
                return datos.GetConsumoRecurso();
            };
        }

        public Recurso getRecurso()
        {
            Recurso obj = Recurso.read().Find(x => x.id == this.recurso_id);
            return obj;
        }
        public string getCategoria()
        {
            return getRecurso().categoria;
        }

        public Tarea getTarea()
        {
            Tarea obj = Tarea.read().Find(x => x.id == this.tarea_id);
            return obj;
        }
        public ConsumoItem toConsumoItem()
        {
            ConsumoItem item = new ConsumoItem();
            Recurso rec = Recurso.getById(this.recurso_id);

            item.tarea_id = this.tarea_id;
            item.recurso_id = this.recurso_id;
            item.recurso_nombre = rec.nombre;
            item.consumo = this.consumo;
            item.consumo_unidad = rec.unidad;
            item.recurso_precio = rec.precio;
            item.coeficiente = this.coeficiente;
            item.subTotal = this.consumo * rec.precio;
            item.categoria = rec.categoria;

            return item;
        }
    }
}