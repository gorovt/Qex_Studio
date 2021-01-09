using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace Qex
{
    public class GrOptions
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public GrOptions()
        {
            Name = string.Empty;
            Value = string.Empty;
        }

        public GrOptions(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        public void insert()
        {
            using (var datos = new DataAccess())
            {
                datos.InsertOption(this);
            };
        }
        public void delete()
        {
            using (var datos = new DataAccess())
            {
                datos.DeleteOption(this);
            };
        }
        public void update()
        {
            using (var datos = new DataAccess())
            {
                datos.UpdateOption(this);
            };
        }
        public static GrOptions getById(int id)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetOptionById(id);
            };
        }
        public static GrOptions getByNombre(string nombre)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetOptions().FirstOrDefault(xx => xx.Name == nombre);
            };
        }
        public static List<GrOptions> read()
        {
            using (var datos = new DataAccess())
            {
                return datos.GetOptions();
            };
        }
    }
}
