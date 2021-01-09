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
