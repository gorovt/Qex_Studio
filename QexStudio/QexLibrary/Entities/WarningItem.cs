using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qex
{
    public class WarningItem
    {
        public string Category { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }

        public WarningItem()
        {
            Category = string.Empty;
            Id = 0;
            Name = string.Empty;
            Message = string.Empty;
        }

        public WarningItem(string category, int id, string name, string message)
        {
            this.Category = category;
            this.Id = id;
            this.Name = name;
            this.Message = message;
        }
    }
}
