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

namespace Qex
{
    public class ConsumoItem
    {
        public int tarea_id { get; set; }
        public int recurso_id { get; set; }
        public string recurso_nombre { get; set; }
        public double consumo { get; set; }
        public string consumo_unidad { get; set; }
        public double recurso_precio { get; set; }
        public double coeficiente { get; set; }
        public double subTotal { get; set; }
        public string categoria { get; set; }

        public ConsumoItem()
        {
            tarea_id = 0;
            recurso_id = 0;
            recurso_nombre = string.Empty;
            consumo = 0;
            consumo_unidad = string.Empty;
            recurso_precio = 0;
            coeficiente = 0;
            subTotal = 0;
            categoria = string.Empty;
        }
    }
    public class ConsumoItemExcel
    {
        public string tarea { get; set; }
        public string recurso { get; set; }
        public double consumo { get; set; }
        public string consumo_unidad { get; set; }

        public ConsumoItemExcel()
        {
            tarea = string.Empty;
            recurso = string.Empty;
            consumo = 0;
            consumo_unidad = string.Empty;
        }
    }
}
