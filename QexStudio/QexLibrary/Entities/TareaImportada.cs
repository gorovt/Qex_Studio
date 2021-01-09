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
