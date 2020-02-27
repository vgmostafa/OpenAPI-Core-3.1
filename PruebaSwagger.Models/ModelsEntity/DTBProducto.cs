using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Models.ModelsEntity
{
    public class DTBProducto
    {
        public string Servicio { get; set; }
        public DTBEquipo Equipos { get; set; }
    }
}
