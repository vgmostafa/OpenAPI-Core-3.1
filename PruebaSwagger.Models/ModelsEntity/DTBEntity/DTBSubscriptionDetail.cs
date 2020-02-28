using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Models.ModelsEntity.DTBEntity
{
    public class DTBSubscriptionDetail
    {
        public int id { get; set; }
        public int typeId { get; set; }
        public string type { get; set; }
        public int cycle { get; set; }
        public int addressId { get; set; }
        public int company { get; set; }
        public string paymentMethod { get; set; }
        public string paymentMethodType { get; set; }
        public DTBProduct products { get; set; }
    }
}
