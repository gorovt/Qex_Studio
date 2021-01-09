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
