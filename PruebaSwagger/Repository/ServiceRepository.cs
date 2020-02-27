using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PruebaSwagger.Repository
{
    public class ServiceRepository
    {
        public HttpClient Client;

        public ServiceRepository()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri("");
        }
    }
}
