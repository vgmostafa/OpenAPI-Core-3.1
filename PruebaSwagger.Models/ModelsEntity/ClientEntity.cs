using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Models
{
    public class ClientEntity
    {
        private string idSuscriber;

        public string IdSuscriber
        {
            get { return idSuscriber; }
            set { idSuscriber = value; }
        }

        private string addressId;

        public string AddressId
        {
            get { return addressId; }
            set { addressId = value; }
        }

        private string serviceNumber;
        public string ServiceNumber
        {
            get { return serviceNumber; }
            set { serviceNumber = value; }
        }

        private string serviceNumberType;
        public string ServiceNumberType
        {
            get { return serviceNumberType; }
            set { serviceNumberType = value; }
        }

        private string json;
        public string Json
        {
            get { return json; }
            set { json = value; }
        }
    }
}
