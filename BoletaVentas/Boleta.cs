﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletaVentas
{
    public class Boleta
    {
        public int numero { get; set; }
        public string nombrecliente { get; set; }
        public string direccioncliente { get; set; }
        public string cedulacliente { get; set; }
        public DateTime fecharegistro { get; set; }
        public string descripcionproducto { get; set; }
        public int cantidadproducto { get; set; }

        //metodo de determinacion de precio
        public double DeterminaPrecio()
        {
            switch (descripcionproducto)
            {
                case "PS5 + 1 MANDO DS5": return 500;
                case "PS4(1TB) + 1 MANDO DS4": return 619;
                case "MANDO PS5/DS5": return 69;
                case "MANDO PS4/DS4": return 60;
            }
            return 0;
        }

        //determinar importe
        public  double CalculaImporte()
        {
            return cantidadproducto * DeterminaPrecio();
        }

    }
}
