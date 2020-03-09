using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Models.ModelsEntity.InformacionComercialEntity.ReturnData
{
    public class ICReturnAddress
    {
        public string id { get; set; }
        public string domicilio { get; set; }
        public string ciudad { get; set; }
        public string departamento { get; set; }
        public string provincia { get; set; }
        public string zona { get; set; }
        public string pais { get; set; }
    }
}
