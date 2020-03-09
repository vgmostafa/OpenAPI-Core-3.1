using PruebaSwagger.Business.Integraciones;
using PruebaSwagger.Integraciones;
using PruebaSwagger.Models;
using PruebaSwagger.Models.ModelsEntity.DTBEntity;
using PruebaSwagger.Models.ModelsEntity.InformacionComercialEntity.ReturnData;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Business.DiagnosticoUnificado
{
    public class DiagnosticoUnificadoBusiness
    {
        public static ICReturnData GetDiagnostico(string idSubscriber, string idDomicilio, string servicio)
        {
			ICReturnData iCReturnData = new ICReturnData();
			try
			{
				iCReturnData = IntegracionOPEN.GetInformacionComercial(idSubscriber, idDomicilio, servicio);
			}
			catch (Exception e)
			{
				throw;
			}

			return iCReturnData;
		}

		public static DTBResponseEntity Integracion_DTB_Programado(string idSuscriber, string IDdomicilio)
		{
			DTBRequestEntity dTBRequestEntity = IntegracionOPEN.GetServiciosActivosForDTB(idSuscriber);
			DTBResponseEntity dTBResponseEntity = IntegracionesBL.GetDTBResponseEntity(dTBRequestEntity, idSuscriber, IDdomicilio);

			return dTBResponseEntity;
		}
	}
}
