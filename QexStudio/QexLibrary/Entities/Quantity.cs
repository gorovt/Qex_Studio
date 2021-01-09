using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Qex
{
    public class Quantity
    {
        public string qId { get; set; }
        public int typeId { get; set; }
        public string category { get; set; }
        public string name { get; set; }
        public string medicion { get; set; }
        public double totalCost { get; set; }
        public string phaseCreated { get; set; }
        public string grupo { get; set; }
        public string libro { get; set; }

        public Quantity()
        {
            qId = string.Empty;
            typeId = 0;
            category = string.Empty;
            name = string.Empty;
            medicion = "";
            totalCost = 0;
            phaseCreated = string.Empty;
            grupo = "";
            libro = "";
        }

        public Quantity(string qId, int typeId, string category, string name, string medicion,
            double totalCost, string phaseCreated, string grupo, string libro)
        {
            this.qId = qId;
            this.typeId = typeId;
            this.category = category;
            this.name = name;
            this.medicion = medicion;
            this.totalCost = totalCost;
            this.phaseCreated = phaseCreated;
            this.grupo = grupo;
            this.libro = libro;
        }

        public static string toStringLine(Quantity q)
        {
            string line = "";
            line += q.qId + ";";
            line += q.typeId + ";";
            line += q.category + ";";
            line += q.name + ";";
            line += q.medicion + ";";
            line += q.totalCost + ";";
            line += q.phaseCreated + ";";
            line += q.grupo + ";";
            line += q.libro + ";";
            return line;
        }
        public double getConsumo()
        {
            string[] values = Regex.Split(this.medicion, " ");
            double medicion = Convert.ToDouble(values[0]);
            return medicion;
        }
        public string getUnidad()
        {
            string[] values = Regex.Split(this.medicion, " ");
            string unidad = values[1];
            return unidad;
        }
        public TareaPres toTareaPres(int rubroPresId)
        {
            TareaPres tarea = new TareaPres();
            tarea.nombre = this.name;
            tarea.consumo = this.getConsumo();
            tarea.unidad = this.getUnidad();
            tarea.rubropres_id = rubroPresId;
            return tarea;
        }
    }
}
