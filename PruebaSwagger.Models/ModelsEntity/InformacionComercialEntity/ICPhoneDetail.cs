using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Models.ModelsEntity.InformacionComercialEntity
{
    public class ICPhoneDetail
    {
        public int id { get; set; }
        public string countryCode { get; set; }
        public string areaCode { get; set; }
        public string phone { get; set; }
        public string companyPhone { get; set; }
        public int phoneTypeId { get; set; }
        public string phoneType { get; set; }
        public string technicalSms { get; set; }
        public string administrativeSms { get; set; }
        public string commercialSms { get; set; }
    }
}
