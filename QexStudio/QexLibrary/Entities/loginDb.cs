using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qex
{
    public class loginDb
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public DateTime fechaInicio { get; set; }

        public loginDb()
        {
            user = string.Empty;
            password = string.Empty;
            fechaInicio = DateTime.Now;
        }
        public loginDb(string user, string pass, DateTime fechaInicio)
        {
            this.user = user;
            this.password = pass;
            this.fechaInicio = fechaInicio;
        }
        /// <summary>
        /// Insert the LoginDb to the DataBase
        /// </summary>
        public void insert()
        {
            using (var datos = new DataAccess())
            {
                datos.insertLoginDb(this);
            };
        }
        /// <summary>
        /// Update the LoginDb properties in the DataBase
        /// </summary>
        public void update()
        {
            using (var datos = new DataAccess())
            {
                datos.updateLoginDb(this);
            };
        }
        /// <summary>
        /// Delete the LoginDb in the DataBase
        /// </summary>
        public void delete()
        {
            using (var datos = new DataAccess())
            {
                datos.deleteLoginDb(this);
            };
        }
    }
}
