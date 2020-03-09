using Newtonsoft.Json;
using PruebaSwagger.Integraciones.Formateador;
using PruebaSwagger.Integraciones.ServiceRepository;
using PruebaSwagger.Models;
using PruebaSwagger.Models.ModelsEntity.DTBEntity;
using PruebaSwagger.Models.ModelsEntity.InformacionComercialEntity;
using PruebaSwagger.Models.ModelsEntity.InformacionComercialEntity.ReturnData;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSwagger.Integraciones
{
    public class IntegracionOPEN
    {
        private static string urlConsulta = "http://esbp.corp.cablevision.com.ar:8000/customerManagement/";
        //private static string urlConsulta = "https://webgestionmoviltesting/servicesAPI.aspx?servicio=DTB&";

        public static ICReturnData GetInformacionComercial(string idSubscriber, string idDomicilio, string servicio)
        {
            ICReturnData iCReturnData = new ICReturnData();
            ICResponseClient iCResponseClient = new ICResponseClient();
            DTBRequestEntity dTBRequestEntity = new DTBRequestEntity();
            ICResponseAddress iCResponseAddress = new ICResponseAddress();
            ICResponseMail iCResponseMail = new ICResponseMail();
            try
            {
                Parallel.Invoke(() => { iCResponseClient = OPENServiceRepository.GetClienteByID(idSubscriber, idDomicilio); },
                                () => { dTBRequestEntity = OPENServiceRepository.GetServiciosActivosByID(idSubscriber, idDomicilio); },
                                () => { iCResponseAddress = OPENServiceRepository.GetAddress(idDomicilio); },
                                () => { iCResponseMail = OPENServiceRepository.GetMailbyId(idSubscriber); });

                iCReturnData = FormateadorOPEN.GetInformacionComercial(iCResponseClient, dTBRequestEntity, iCResponseAddress, iCResponseMail, idDomicilio); 
            }
            catch (Exception e)
            {
                throw;
            }

            return iCReturnData;
        }

        static public DTBRequestEntity GetServiciosActivosForDTB(string idSuscriber)
        {
            string jsonResponse = "";
            try
            {
                string url = urlConsulta + "products/installedBase?subscriberId=" + idSuscriber + "&isActive=true";
                jsonResponse = Utilidades.GetResponse(url);

                DTBRequestEntity dTBRequestEntity = JsonConvert.DeserializeObject<DTBRequestEntity>(jsonResponse);

                return dTBRequestEntity;
            }
            catch (Exception ex)
            {
                //WebGestionMovil.Common.Mailer.SendMail(WebGestionMovil.Common.Excepciones.Format(ex), "Error en la ejecución OPEN");
                throw ex;
            }
        }
    }
}
