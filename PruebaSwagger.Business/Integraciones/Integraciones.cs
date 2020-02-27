using PruebaSwagger.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Business.Integraciones
{
    public class Integraciones
    {
        private static internal ClientEntity Integraciones_OPEN(string idSuscriber, string IDdomicilio, string Servicio)
        {
            ClientEntity intOpen = Integraciones.Integracion_OPEN.getInformacionComercial(idSuscriber, IDdomicilio, Servicio);
            return intOpen;
        }
    }
}
