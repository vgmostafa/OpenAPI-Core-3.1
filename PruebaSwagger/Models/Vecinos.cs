using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaSwagger.Models
{
    public class Vecinos
    {
        public Element element { get; set; }
        public List<Relationships> relationships { get; set; }
        public Error error { get; set; }
    }
}
