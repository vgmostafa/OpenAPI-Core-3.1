using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PruebaSwagger.Repository
{
    public class ServiceGenericRepository : ServiceRepository
    {
        public ServiceGenericRepository() : base()
        {

        }

        public HttpResponseMessage GetResponse(string url)
        {
            return Client.GetAsync(url).Result;
        }

        //public HttpResponseMessage GetResponse(string url, int param)
        //{
        //    return Client.GetAsync(url + "?idDistrict=" + param).Result;
        //}

        //public HttpResponseMessage GetResponse(string url, string parameterName, int param)
        //{
        //    return Client.GetAsync(url + "?" + parameterName + "=" + param).Result;
        //}

        //public HttpResponseMessage PutResponse(string url, object model)
        //{
        //    return Client.PutAsJsonAsync(url, model).Result;
        //}

        //public HttpResponseMessage PostResponse(string url, object model)
        //{
        //    return Client.PostAsJsonAsync(url, model).Result;
        //}

        //public HttpResponseMessage DeleteResponse(string url)
        //{
        //    return Client.DeleteAsync(url).Result;
        //}
    }
}
