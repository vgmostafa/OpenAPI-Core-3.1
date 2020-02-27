using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace PruebaSwagger.Business.ServiceRepository
{
    public class ServiceGenericRepository : ServiceRepository
    {
        public ServiceGenericRepository(string url) : base(url)
        {
        }

        public HttpResponseMessage GetResponse(string url)
        {
            return Client.GetAsync(url).Result;
        }
    }
}
