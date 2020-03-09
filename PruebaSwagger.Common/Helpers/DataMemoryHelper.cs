using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Common.Helpers
{
    public class DataMemoryHelper
    {
        private static DataMemoryHelper _dataMemoryHelper;
        public string Antiguedad { get; set; }

        private DataMemoryHelper()
        {
            
        }

        public static DataMemoryHelper Instance()
        {
            if (_dataMemoryHelper == null)
                _dataMemoryHelper = new DataMemoryHelper();

            return _dataMemoryHelper;
        }

        
    }
}
