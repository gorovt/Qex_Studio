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
    public class TareaImportada
    {
        public string id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }

        public TareaImportada()
        {
            id = string.Empty;
            codigo = string.Empty;
            nombre = string.Empty;
        }
    }
    public class TareaImportadaExcel
    {
        public string grupo { get; set; }
        public string nombre { get; set; }
        public string unidad { get; set; }
        public string detalles { get; set; }

        public TareaImportadaExcel()
        {
            grupo = string.Empty;
            nombre = string.Empty;
            unidad = string.Empty;
            detalles = string.Empty;
        }
    }
}
