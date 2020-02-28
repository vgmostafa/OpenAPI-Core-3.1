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

namespace PruebaSwagger.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        [Route("GetVecino")]
        [HttpGet]
        public ActionResult<Vecinos> GetVecino()
        {
            return Ok(new Vecinos()
            {
                element = new Element()
                {
                    elementName = "Prueba",
                    elementRole = "Prueba",
                    relationshipType = "Prueba"
                },
                error = new Error()
                {
                    code = "Prueba error",
                    description = "Descripcion error",
                    message = "mensaje error"
                }
            });
        }

        [Route("GetDTB")]
        [HttpGet]
        public ActionResult<DTBResponseEntity> GetDTB(string idSuscriber, string IDdomicilio)
        {
            //DTBResponseEntity dTBResponseEntity = IntegracionOPEN.GetServiciosActivosForDTB(idSuscriber, IDdomicilio);
            //"9987991", "33186068"
            //1789977, 33228538
            DTBResponseEntity dTBResponseEntity = Business.Integraciones.Integraciones.Integracion_DTB_Programado(idSuscriber, IDdomicilio);
            return dTBResponseEntity;
        }

        [Route("GetEquipos")]
        [HttpGet]
        public ActionResult<DTBEquipoReferencia> GetEquipo() => new DTBEquipoReferencia() { };
    }
}