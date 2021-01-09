/*   Qex Studio License
*******************************************************************************
*                                                                             *
*    Copyright (c) 2017-2021 Luciano Gorosito <lucianogorosito@hotmail.com>   *
*                                                                             *
*    This file is part of Qex Studio                                          *
*                                                                             *
*    Qex Studio is free software: you can redistribute it and/or modify       *
*    it under the terms of the GNU General Public License as published by     *
*    the Free Software Foundation, either version 3 of the License, or        *
*    (at your option) any later version.                                      *
*                                                                             *
*    Qex Studio is distributed in the hope that it will be useful,            *
*    but WITHOUT ANY WARRANTY; without even the implied warranty of           *
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the            *
*    GNU General Public License for more details.                             *
*                                                                             *
*    You should have received a copy of the GNU General Public License        *
*    along with this program.  If not, see <https://www.gnu.org/licenses/>.   *
*                                                                             *
*******************************************************************************
*/

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
