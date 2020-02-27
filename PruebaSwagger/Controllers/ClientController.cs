using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaSwagger.Integraciones;
using PruebaSwagger.Models;
using PruebaSwagger.Models.ModelsEntity;
using PruebaSwagger.Models.ModelsResponse;

namespace PruebaSwagger.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        [Route("GetVecino")]
        [HttpGet]
        //[Route("GetVecinos")]
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
        public ActionResult<DTBResponseEntity> GetDTB()
        {
            DTBResponseEntity dTBResponseEntity = IntegracionOPEN.GetServiciosActivosForDTB("9987991", "33186068");

            return dTBResponseEntity;
        }

        [Route("GetEquipos")]
        [HttpGet]
        public ActionResult<DTBEquipoReferencia> GetEquipo() => new DTBEquipoReferencia() { };
    }
}