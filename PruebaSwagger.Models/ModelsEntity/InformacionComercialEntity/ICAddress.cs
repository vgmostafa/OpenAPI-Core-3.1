using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Models.ModelsEntity.InformacionComercialEntity
{
    public class ICAddress
    {
        public string addressId { get; set; }
        public string address { get; set; }
        public string locationId { get; set; }
        public string location { get; set; }
        public string departmentId { get; set; }
        public string department { get; set; }
        public string provinceId { get; set; }
        public string province { get; set; }
        public string zoneId { get; set; }
        public string zone { get; set; }
        public string countryId { get; set; }
        public string country { get; set; }
        public string isUrban { get; set; }
    }
}
