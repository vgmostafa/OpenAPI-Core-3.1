using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaSwagger.Models;
using PruebaSwagger.Models.ModelsEntity;
using PruebaSwagger.Models.ModelsEntity.DTBEntity;
using PruebaSwagger.Business.Integraciones;
using PruebaSwagger.Integraciones.ServiceRepository;
using PruebaSwagger.Models.ModelsEntity.InformacionComercialEntity;
using PruebaSwagger.Integraciones;
using PruebaSwagger.Models.ModelsEntity.InformacionComercialEntity.ReturnData;
using PruebaSwagger.Business.DiagnosticoUnificado;

namespace PruebaSwagger.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        //[Route("GetVecino")]
        //[HttpGet]
        //public ActionResult<Vecinos> GetVecino()
        //{
        //    return Ok(new Vecinos()
        //    {
        //        element = new Element()
        //        {
        //            elementName = "Prueba",
        //            elementRole = "Prueba",
        //            relationshipType = "Prueba"
        //        },
        //        error = new Error()
        //        {
        //            code = "Prueba error",
        //            description = "Descripcion error",
        //            message = "mensaje error"
        //        }
        //    });
        //}

        //[Route("ConsultaDTB")]
        //[HttpGet]
        //public ActionResult<DTBResponseEntity> GetDTB(string idSuscriber, string IDdomicilio)
        //{
        //    DTBResponseEntity dTBResponseEntity = new DTBResponseEntity();
        //    //"9987991", "33186068"
        //    //1789977, 33228538
        //    try
        //    {dTBResponseEntity = Business.Integraciones.Integraciones.Integracion_DTB_Programado(idSuscriber, IDdomicilio);
        //        dTBResponseEntity = Business.Integraciones.Integraciones.Integracion_DTB_Programado(idSuscriber, IDdomicilio);
        //    }
        //    catch (Exception e)
        //    {
        //        return StatusCode(400);
        //    }

        //    return dTBResponseEntity;
        //}

        [Route("ConsultaDTB")]
        [HttpGet]
        public ActionResult<DTBResponseEntity> GetDTB(string idSubscriber, string idDomicilio)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            DTBResponseEntity dTBResponseEntity = new DTBResponseEntity();
            dTBResponseEntity = Business.Integraciones.Integraciones.Integracion_DTB_Programado(idSubscriber, idDomicilio);

            return dTBResponseEntity;
        }

        [Route("ConsultaDiagnosticoUnificado")]
        [HttpGet]
        public ActionResult<ICReturnData> GetDiagnosticoUnificado(string idSubscriber, string idDomicilio, string servicio)
        {
            ICReturnData iCReturnData = new ICReturnData();
            iCReturnData = DiagnosticoUnificadoBusiness.GetDiagnostico(idSubscriber, idDomicilio, servicio);

            return iCReturnData;
        }
    }
}