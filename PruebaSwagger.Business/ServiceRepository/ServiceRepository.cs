using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace PruebaSwagger.Business.ServiceRepository
{
    public class ServiceRepository
    {
        public HttpClient Client;

        public ServiceRepository(string url)
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(url);
        }
    }
}
