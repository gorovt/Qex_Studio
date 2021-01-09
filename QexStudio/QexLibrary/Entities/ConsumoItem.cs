﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qex
{
    public class ConsumoItem
    {
        public int tarea_id { get; set; }
        public int recurso_id { get; set; }
        public string recurso_nombre { get; set; }
        public double consumo { get; set; }
        public string consumo_unidad { get; set; }
        public double recurso_precio { get; set; }
        public double coeficiente { get; set; }
        public double subTotal { get; set; }
        public string categoria { get; set; }

        public ConsumoItem()
        {
            tarea_id = 0;
            recurso_id = 0;
            recurso_nombre = string.Empty;
            consumo = 0;
            consumo_unidad = string.Empty;
            recurso_precio = 0;
            coeficiente = 0;
            subTotal = 0;
            categoria = string.Empty;
        }
    }
    public class ConsumoItemExcel
    {
        public string tarea { get; set; }
        public string recurso { get; set; }
        public double consumo { get; set; }
        public string consumo_unidad { get; set; }

        public ConsumoItemExcel()
        {
            tarea = string.Empty;
            recurso = string.Empty;
            consumo = 0;
            consumo_unidad = string.Empty;
        }
    }
}