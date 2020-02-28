using PruebaSwagger.Models.ModelsEntity;
using PruebaSwagger.Models.ModelsEntity.DTBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Business.Integraciones
{
    public class IntegracionesBL
    {
        public static DTBResponseEntity GetDTBResponseEntity(DTBRequestEntity dTBRequestEntity, string idSuscriber, string IDdomicilio)
        {
            List<DTBProductDetail> dTBProductDetailList = dTBRequestEntity.subscriptions.subscription[0].products.product;
            List<DTBProducto> dTBProductoList = new List<DTBProducto>();
            DTBProducto dTBProducto;
            DTBProductoReferencia dTBProductoReferencia = new DTBProductoReferencia();

            for (int i = 0; i < dTBProductDetailList.Count; i++)
            {
                if (dTBProductDetailList[i].addressId.ToString() == IDdomicilio &&
                    dTBProductDetailList[i].productType != "FLOW APP") 
                {
                    List<DTBComponentDetail> dTBComponentDetailList = dTBProductDetailList[i].components.component;
                    string servicio = dTBProductDetailList[i].productType;
                    List<DTBEquipoReferencia> dTBEquipoReferenciaList = new List<DTBEquipoReferencia>();
                    DTBEquipoReferencia dTBEquipoReferencia;
                    DTBEquipo dTBEquipo = new DTBEquipo();

                    for (int j = 0; j < dTBComponentDetailList.Count; j++)
                    {
                        if (dTBComponentDetailList[j].componentType == "Equipo")
                        {
                            string nroLinea = "";
                            if (servicio == "TELEFONÍA")
                            {
                                nroLinea = dTBComponentDetailList[j].serviceNumber;
                            }

                            dTBEquipoReferencia = new DTBEquipoReferencia()
                            {
                                Serial = dTBComponentDetailList[j].serviceNumber,
                                NroLinea = nroLinea,
                                TipoEquipo = dTBComponentDetailList[j].classService,
                                MAC = "",
                                Marca = "",
                                Modelo = ""
                            };

                            dTBEquipoReferenciaList.Add(dTBEquipoReferencia);
                            dTBEquipo.EquipoRef = dTBEquipoReferenciaList;
                        }
                    }

                    dTBProducto = new DTBProducto()
                    {
                        Equipos = dTBEquipo,
                        Servicio = servicio
                    };
                    dTBProductoList.Add(dTBProducto);
                    dTBProductoReferencia.ProductRef = dTBProductoList;
                }
            }

            DTBResponseEntity dTBResponseEntity = new DTBResponseEntity() 
            {
                AddressId = dTBRequestEntity.subscriptions.subscription[0].addressId.ToString(),
                SuscriberID = idSuscriber,
                TipoDiagnostico = "DTB",
                Productos = dTBProductoReferencia
            };

            return dTBResponseEntity;
        }
    }
}
