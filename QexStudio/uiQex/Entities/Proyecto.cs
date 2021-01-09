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
