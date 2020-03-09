using PruebaSwagger.Integraciones;
using PruebaSwagger.Models;
using PruebaSwagger.Models.ModelsEntity.DTBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Business.Integraciones
{
    public class Integraciones
    {
        //private static ClientEntity Integraciones_OPEN(string idSuscriber, string IDdomicilio, string Servicio)
        //{
        //    ClientEntity intOpen = IntegracionOPEN.GetServiciosActivosForDTB(idSuscriber, IDdomicilio, Servicio);
        //    return intOpen;
        //}

        public static DTBResponseEntity Integracion_DTB_Programado(string idSuscriber, string IDdomicilio)
        {
            DTBRequestEntity dTBRequestEntity = IntegracionOPEN.GetServiciosActivosForDTB(idSuscriber);
            DTBResponseEntity dTBResponseEntity = IntegracionesBL.GetDTBResponseEntity(dTBRequestEntity, idSuscriber, IDdomicilio);

            return dTBResponseEntity;
        }
    }
}
