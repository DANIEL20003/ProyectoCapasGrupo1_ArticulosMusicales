﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class Instrumento
    {
        public string codInstru { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public decimal precio { get; set; }
        public int anioFabrica { get; set; }
        public int idIva { get; set; }
        public Int64 cantidad { get; set; }
        public int idCatego { get; set; }
        public string proveedor { get; set; }
        public string color { get; set; }
        public string material { get; set; }
        public string dimension { get; set; }
        public byte[] foto { get; set; }

    }
}
