using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qex
{
    public class Task
    {
        // public string  { get; set; }
        public int UID { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public int IsNull { get; set; }
        public int OutlineLevel { get; set; }

        public Task()
        {
            UID = 0;
            ID = 0;
            Name = string.Empty;
            IsNull = 0;
            OutlineLevel = 0;
        }


    }
}
