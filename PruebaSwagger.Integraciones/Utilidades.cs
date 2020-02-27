using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace PruebaSwagger.Integraciones
{
    public class Utilidades
    {
        public static string GetResponse(string url)
        {
            try
            {
                HttpClient client = new HttpClient();

                ServicePointManager.ServerCertificateValidationCallback += (se, cert, chain, sslerror) =>
                {
                    return true;
                };

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.Timeout = 60000;

                string result = "";

                using (WebResponse svcResponse = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(svcResponse.GetResponseStream()))
                    {
                        result = sr.ReadToEnd();
                    }
                }
                return result;
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    string errorJson = new System.IO.StreamReader(e.Response.GetResponseStream()).ReadToEnd();

                    return errorJson;
                }
                else
                {
                    throw e;
                }
            }
        }
    }
}
