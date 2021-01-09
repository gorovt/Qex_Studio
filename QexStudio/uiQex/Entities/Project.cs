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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Qex
{
    public class Project
    {
        public int SaveVersion { get; set; }
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }
        // public string  { get; set; }

        public Project()
        {
            SaveVersion = 0;
            Name = string.Empty;
        }

        public string XmlHeader()
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }

        /// <summary>
        /// Converts the Estimate to an Xml file
        /// </summary>
        public void SaveToXml(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Project));
            TextWriter tw = new StreamWriter(path); // @"c:\temp\presupuesto.xml"
            xs.Serialize(tw, this);
        }
    }
}
