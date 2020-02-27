using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace PruebaSwagger.Common
{
    public class RecuperadorDatos
    {
        public static string GetValueConfig(string key)
        {
            try
            {
                string[] Claves = ConfigurationManager.AppSettings.AllKeys;
                int i = 0;
                while (Claves[i].ToLower() != key.ToLower() && i < Claves.Length)
                {
                    i++;
                }
                return ConfigurationManager.AppSettings[Claves[i]];
            }
            catch (Exception ex)
            {

                throw new Exception("No se encuentra la clave: <b>" + key + "</b> ");
            }

        }
    }
}
