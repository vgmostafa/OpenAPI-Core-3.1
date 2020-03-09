using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Models.ModelsEntity.InformacionComercialEntity
{
    public class ICSubscriber
    {
        public int id { get; set; }
        public int typeId { get; set; }
        public string type { get; set; }
        public string identification { get; set; }
        public string identificationTypeId { get; set; }
        public string identificationType { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int statusId { get; set; }
        public string status { get; set; }
        public int marketingSegmentId { get; set; }
        public string marketingSegment { get; set; }
        public int categoryId { get; set; }
        public string category { get; set; }
        public string taxPayerTypeId { get; set; }
        public string taxPayerType { get; set; }
        public ICSubscription subscriptions { get; set; }
    }
}
