using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Models.ModelsEntity.InformacionComercialEntity.ReturnData
{
    public class ICReturnClient
    {
        public string subscriber { get; set; }
        public string identificador { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string segmento { get; set; }
        public string estado { get; set; }
        public string cicloFacturacion { get; set; }
        public string antiguedad { get; set; }
    }
}
