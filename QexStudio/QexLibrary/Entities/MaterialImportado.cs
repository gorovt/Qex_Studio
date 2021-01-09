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
