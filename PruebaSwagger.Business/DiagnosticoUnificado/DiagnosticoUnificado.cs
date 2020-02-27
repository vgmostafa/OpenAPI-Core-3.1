using PruebaSwagger.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Business.DiagnosticoUnificado
{
    public class DiagnosticoUnificado
    {
        //static public string GetDiagnostico(string idSuscriber, string IDdomicilio, string Servicio)
        //{
        //    try
        //    {
        //        ClientEntity intOpen = new ClientEntity();

        //        intOpen = Integraciones_OPEN(idSuscriber, IDdomicilio, Servicio);
        //        ClientEntity intVecinos = new ClientEntity();
        //        if (Servicio != "Test")
        //        {
        //            if (intOpen.ServiceNumber != "" && intOpen.ServiceNumber != null)
        //            {

        //                intVecinos = Integraciones_MU(intOpen.ServiceNumber);

        //                //string js= consultaDireccionVecinos("{"+intVecinos.Json+ "}");

        //                return "[" + intOpen.Json + ",{" + intVecinos.Json + "}]";
        //                //return "[" + intOpen.Json + ",{" + js + "}]";
        //            }
        //            else
        //                return intOpen.Json;
        //        }
        //        else
        //        {
        //            return intOpen.Json;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public static string Integraciones_DTB_Programado(string idSuscriber, string IDdomicilio)
        {
            ClientEntity dtb = Integraciones.Integracion_OPEN.GetServiciosActivosForDTB(idSuscriber, IDdomicilio);
            return dtb.Json;
        }
    }
}
