using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qex
{
    public class RubroImportado
    {
        public string id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }

        public RubroImportado()
        {
            id = string.Empty;
            codigo = string.Empty;
            nombre = string.Empty;
        }
    }
}
