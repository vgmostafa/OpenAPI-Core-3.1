using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Models.ModelsEntity.InformacionComercialEntity
{
    public class ICSubscriptionDetail
    {
        public int id { get; set; }
        public int typeId { get; set; }
        public int cycle { get; set; }
        public int addressId { get; set; }
        public string paymentMethod { get; set; }
        public string paymentMethodType { get; set; }
        public string company { get; set; }
    }
}
