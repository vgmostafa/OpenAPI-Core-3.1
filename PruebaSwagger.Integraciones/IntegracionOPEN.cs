using Newtonsoft.Json;
using PruebaSwagger.Models;
using PruebaSwagger.Models.ModelsEntity.DTBEntity;
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
        //static public ClientEntity getInformacionComercial(string idSuscriber, string IDdomicilio, string servicio)
        //{
        //    ClientEntity clienteById = new ClientEntity();
        //    ClientEntity ServiciosActivos = new ClientEntity();
        //    ClientEntity clienteAddress = new ClientEntity();
        //    ClientEntity clienteMail = new ClientEntity();
        //    ClientEntity clientePhone = new ClientEntity();

        //    //Parallel.Invoke(() =>
        //    //{
        //    //    clienteById = GetClienteByID(idSuscriber, IDdomicilio);
        //    //});
        //    //    () =>
        //    //    {
        //    //        ServiciosActivos = GetServiciosActivosByID(idSuscriber, IDdomicilio);
        //    //    },

        //    //    () =>
        //    //    {
        //    //        clienteAddress = GetAddress(IDdomicilio);
        //    //    },

        //    //    () =>
        //    //    {
        //    //        clienteMail = GetMailbyID(idSuscriber);
        //    //    },

        //    //    () =>
        //    //    {
        //    //        clientePhone = GetPhonebyID(idSuscriber);
        //    //    });


        //    ClientEntity Final = new ClientEntity();

        //    if (servicio == "")
        //    {
        //        return ServiciosActivos;
        //    }
        //    else
        //    {

        //        Final = Formateadores.Formateador_OPEN.RespuestaTest(clienteById, clienteAddress.Json, clienteMail.Json, clientePhone.Json, ServiciosActivos, IDdomicilio);

        //        return Final;

        //    }

        //}

        //private static internal ClientEntity GetClienteByID(string idSuscriber, string IDdomicilio)
        //{
        //    string jsonResponse = "";
        //    try
        //    {
        //        HttpClient client = new HttpClient();
        //        //client.BaseAddress = new Uri(urlConsulta);

        //        string url = urlConsulta + "subscribers/" + idSuscriber;
        //        //jsonResponse = Utilidades.GetResponse(url);

        //        HttpResponseMessage response = client.GetAsync(url).Result;

        //        var serializer = new JavaScriptSerializer();
        //        serializer.RegisterConverters(new[] { new DynamicJsonConverter() });
        //        dynamic json = serializer.Deserialize(jsonResponse, typeof(object));


        //        ClientEntity clienteIds = new ClientEntity();
        //        if (json.subscriber[0].subscriptions != null)
        //            clienteIds.AddressId = json.subscriber[0].subscriptions.subscription[0].addressId.ToString();
        //        clienteIds.IdSuscriber = idSuscriber;
        //        clienteIds.Json = jsonResponse;
        //        return clienteIds;

        //    }

        //    catch (Exception ex)
        //    {
        //        //WebGestionMovil.Common.Mailer.SendMail(WebGestionMovil.Common.Excepciones.Format(ex), "Error en la ejecución OPEN");
        //        throw ex;
        //    }
        //}

        static public DTBRequestEntity GetServiciosActivosForDTB(string idSuscriber)
        {
            string jsonResponse = "";
            try
            {
                //string url = urlConsulta + "idSubscriber=" + idSuscriber + "&IDdomicilio=" + IDdomicilio;
                string url = urlConsulta + "products/installedBase?subscriberId=" + idSuscriber + "&isActive=true";
                jsonResponse = Utilidades.GetResponse(url);

                //DTBResponseEntity response = JsonConvert.DeserializeObject<DTBResponseEntity>(jsonResponse);

                DTBRequestEntity dTBRequestEntity = JsonConvert.DeserializeObject<DTBRequestEntity>(jsonResponse);

                return dTBRequestEntity;

                //var serializer = new JavaScriptSerializer();
                //serializer.RegisterConverters(new[] { new DynamicJsonConverter() });
                //dynamic json = serializer.Deserialize(jsonResponse, typeof(object));
                //string serie = "";
                //string tipo = "";
                ////bool encontrado = false;
                //string jsonSalida = "{\n \"TipoDiagnostico\": \"DTB\",\n";
                //jsonSalida += "\"SuscriberID\":\"" + idSuscriber + "\",\n";
                //jsonSalida += "\"AddressId\":\"" + IDdomicilio + "\",\n";
                //jsonSalida += "\"Productos\":{\n";
                //jsonSalida += "\"ProductRef\":[\n";

                //for (int i = 0; i < json.subscriptions.subscription[0].products.product.Count; i++)
                //{
                //    if (json.subscriptions.subscription[0].products.product[i].addressId.ToString() == IDdomicilio && json.subscriptions.subscription[0].products.product[i].productType != "FLOW APP")
                //    {
                //        jsonSalida += "{";
                //        jsonSalida += "\"Servicio\":\"" + json.subscriptions.subscription[0].products.product[i].productType + "\",\n";
                //        jsonSalida += "\"Equipos\": {\n";
                //        jsonSalida += "\"EquipoRef\":[\n ";

                //        for (int x = 0; x < json.subscriptions.subscription[0].products.product[i].components.component.Count; x++)
                //        {
                //            string component = json.subscriptions.subscription[0].products.product[i].components.component[x].componentType;

                //            if (component == "Equipo")
                //            {
                //                jsonSalida += "{\n";
                //                jsonSalida += "\"MAC\":\"\", \n";
                //                jsonSalida += "\"Serial\":\"" + json.subscriptions.subscription[0].products.product[i].components.component[x].serviceNumber + "\",\n";
                //                if (json.subscriptions.subscription[0].products.product[i].productType == "TELEFONÍA")
                //                    jsonSalida += "\"NroLinea\":\"" + json.subscriptions.subscription[0].products.product[i].components.component[x].serviceNumber + "\",\n";
                //                else
                //                    jsonSalida += "\"NroLinea\":\"\",\n";
                //                jsonSalida += "\"Tipo Equipo\":\"" + json.subscriptions.subscription[0].products.product[i].components.component[x].classService + "\",\n";
                //                jsonSalida += "\"Marca\":\"\",\n";
                //                jsonSalida += "\"Modelo\":\"\"\n";

                //                jsonSalida += "},";
                //            }
                //        }

                //        jsonSalida = jsonSalida.Remove(jsonSalida.Length - 1);
                //        jsonSalida += "]}},";
                //    }
                //}
                //jsonSalida = jsonSalida.Remove(jsonSalida.Length - 1);
                //jsonSalida += "]\n";
                //jsonSalida += "}\n";
                //jsonSalida += "}\n";
                //ClientEntity clienteIds = new ClientEntity();
                //clienteIds.AddressId = json.subscriptions.subscription[0].addressId.ToString();
                //clienteIds.IdSuscriber = idSuscriber;
                //clienteIds.Json = jsonSalida;
                //clienteIds.ServiceNumber = serie;
                //clienteIds.ServiceNumberType = tipo;
                //return clienteIds;
            }
            catch (Exception ex)
            {
                //WebGestionMovil.Common.Mailer.SendMail(WebGestionMovil.Common.Excepciones.Format(ex), "Error en la ejecución OPEN");

                throw ex;
            }
        }
    }
}
