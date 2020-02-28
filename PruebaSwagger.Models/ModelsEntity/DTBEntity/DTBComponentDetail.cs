using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Models.ModelsEntity.DTBEntity
{
    public class DTBComponentDetail
    {
        public string componentId { get; set; }
        public string serviceNumber { get; set; }
        public string parentComponentId { get; set; }
        public string comboId { get; set; }
        public int componentTypeId { get; set; }
        public string componentType { get; set; }
        public int classServiceId { get; set; }
        public string classService { get; set; }
        public int componentStatusId { get; set; }
        public string componentStatus { get; set; }
        public DateTime creationDate { get; set; }
        public bool isMain { get; set; }
    }
}
