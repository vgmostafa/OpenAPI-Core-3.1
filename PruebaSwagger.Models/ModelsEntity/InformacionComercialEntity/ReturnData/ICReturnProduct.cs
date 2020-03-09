using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Models.ModelsEntity.InformacionComercialEntity.ReturnData
{
    public class ICReturnProduct
    {
        public string producto { get; set; }
        public string estado { get; set; }
        public List<ICProductDetail> detalle { get; set; }
    }
}
