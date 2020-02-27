using PruebaSwagger.Models.ModelsEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Models.ModelsResponse
{
    public class DTBResponseEntity
    {
        public string TipoDiagnostico { get; set; }
        public string SuscriberID { get; set; }
        public string AddressId { get; set; }
        public DTBProductoReferencia Productos { get; set; }
    }
}
