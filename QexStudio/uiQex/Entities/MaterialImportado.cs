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
    public class MaterialImportado
    {
        public string id { get; set; }
        public string nombre { get; set; }

        public MaterialImportado()
        {
            id = string.Empty;
            nombre = string.Empty;
        }
    }
    public class RecursoImportadoExcel
    {
        public string Group { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Unit { get; set; }
        public string CommercialUnit { get; set; }
        public double CommercialCost { get; set; }
        public double Equivalence { get; set; }
        public string Categoria { get; set; }

        public RecursoImportadoExcel()
        {
            Group = string.Empty;
            Name = string.Empty;
            Unit = string.Empty;
            Cost = 0;
            CommercialUnit = string.Empty;
            CommercialCost = 0;
            Equivalence = 1;
            Categoria = "Material";
        }
    }
}
