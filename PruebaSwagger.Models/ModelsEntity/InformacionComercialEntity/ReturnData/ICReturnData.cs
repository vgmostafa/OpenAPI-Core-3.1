using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Models.ModelsEntity.InformacionComercialEntity.ReturnData
{
    public class ICReturnData
    {
        public ICReturnClient datosCliente { get; set; }
        public ICReturnAddress direccion { get; set; }
        public List<ICReturnMail> mails { get; set; }
        public List<ICReturnPhone> telefono { get; set; }
        public List<ICReturnProduct> productos { get; set; }
    }
}
