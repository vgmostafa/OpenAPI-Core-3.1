using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Models.ModelsEntity.InformacionComercialEntity
{
    public class ICMailDetail
    {
        public int id { get; set; }
        public string mail { get; set; }
        public int useTypeid { get; set; }
        public string useType { get; set; }
        public int contactTypeId { get; set; }
        public string contactType { get; set; }
        public string technicalMail { get; set; }
        public string administrativeMail { get; set; }
        public string commercialMail { get; set; }
        public string electronicInvoiceMail { get; set; }
    }
}
