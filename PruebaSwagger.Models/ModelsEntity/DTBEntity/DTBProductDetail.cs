using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Models.ModelsEntity.DTBEntity
{
    public class DTBProductDetail
    {
        public string productId { get; set; }
        public int productTypeId { get; set; }
        public string productType { get; set; }
        public int productStatusId { get; set; }
        public string productStatus { get; set; }
        public DateTime creationDate { get; set; }
        public int commercialPlanId { get; set; }
        public string commercialPlan { get; set; }
        public int companyId { get; set; }
        public string company { get; set; }
        public int addressId { get; set; }
        public DTBComponent components { get; set; }
        public string promotions { get; set; }
    }
}
