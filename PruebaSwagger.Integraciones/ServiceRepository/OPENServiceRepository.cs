using Newtonsoft.Json;
using PruebaSwagger.Models;
using PruebaSwagger.Models.ModelsEntity.DTBEntity;
using PruebaSwagger.Models.ModelsEntity.InformacionComercialEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Integraciones.ServiceRepository
{
    public class OPENServiceRepository
    {
        private static string urlConsulta = "http://esbp.corp.cablevision.com.ar:8000/customerManagement/";

        public static ICResponseClient GetClienteByID(string idSubscriber, string idDomicilio)
        {
            string jsonResponse = "";
            ICResponseClient dTBRequestEntity;
            try
            {
                string url = urlConsulta + "subscribers/" + idSubscriber;
                jsonResponse = Utilidades.GetResponse(url);

                dTBRequestEntity = JsonConvert.DeserializeObject<ICResponseClient>(jsonResponse);
            }
            catch (Exception e)
            {

                throw;
            }

            return dTBRequestEntity;
        }

        static public DTBRequestEntity GetServiciosActivosByID(string idSuscriber, string idDomicilio)
        {
            string jsonResponse = "";
            DTBRequestEntity dTBRequestEntity = new DTBRequestEntity();
            try
            {
                string url = urlConsulta + "products/installedBase?subscriberId=" + idSuscriber + "&isActive=true";
                jsonResponse = Utilidades.GetResponse(url);

                dTBRequestEntity = JsonConvert.DeserializeObject<DTBRequestEntity>(jsonResponse);
            }
            catch (Exception e)
            {
                throw;
            }

            return dTBRequestEntity;
        }

        public static ICResponseAddress GetAddress(string idAddress)
        {
            string jsonResponse = "";
            ICResponseAddress iCResponseAddress = new ICResponseAddress();
            try
            {
                string url = urlConsulta + "addresses/" + idAddress;
                jsonResponse = Utilidades.GetResponse(url);

                iCResponseAddress = JsonConvert.DeserializeObject<ICResponseAddress>(jsonResponse);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return iCResponseAddress;
        }

        public static ICResponseMail GetMailbyId(string idSubscriber)
        {
            string jsonResponse = "";
            ICResponseMail iCResponseMail = new ICResponseMail();
            try
            {
                string url = urlConsulta + "subscribers/contactData?subscriberId=" + idSubscriber;
                jsonResponse = Utilidades.GetResponse(url);

                iCResponseMail = JsonConvert.DeserializeObject<ICResponseMail>(jsonResponse);
            }
            catch (Exception e)
            {
                throw;
            }

            return iCResponseMail;
        }

        //public static void GetPhoneById(string idSubscriber)
        //{
        //    string jsonResponse = "";
        //    try
        //    {
        //        string url = urlConsulta + "subscribers/contactData?subscriberId=" + idSubscriber;
        //        jsonResponse = Utilidades.GetResponse(url);
        //    }
        //    catch (Exception e)
        //    {
        //        throw;
        //    }
        //}
    }
}
