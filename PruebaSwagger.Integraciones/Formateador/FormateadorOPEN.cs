using PruebaSwagger.Common.Helpers;
using PruebaSwagger.Models.ModelsEntity.DTBEntity;
using PruebaSwagger.Models.ModelsEntity.InformacionComercialEntity;
using PruebaSwagger.Models.ModelsEntity.InformacionComercialEntity.ReturnData;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSwagger.Integraciones.Formateador
{
    public class FormateadorOPEN
    {
        public static ICReturnData GetInformacionComercial(ICResponseClient iCResponseClient, DTBRequestEntity dTBRequestEntity, ICResponseAddress iCResponseAddress, ICResponseMail iCResponseMail, string idDomicilio)
        {
            List<ICReturnProduct> iCReturnProductList = GetServiciiosActivosById(dTBRequestEntity, idDomicilio);

            ICReturnClient iCReturnClient = new ICReturnClient()
            {
                subscriber = iCResponseClient.subscriber[0].id.ToString(),
                identificador = iCResponseClient.subscriber[0].identification,
                nombre = iCResponseClient.subscriber[0].name,
                apellido = iCResponseClient.subscriber[0].lastName,
                segmento = iCResponseClient.subscriber[0].marketingSegment,
                estado = iCResponseClient.subscriber[0].statusId.ToString(),
                cicloFacturacion = iCResponseClient.subscriber[0].subscriptions.subscription[0].cycle.ToString(),
                antiguedad = DataMemoryHelper.Instance().Antiguedad
            };

            ICReturnAddress iCReturnAddress = new ICReturnAddress()
            {
                id = iCResponseAddress.address.addressId,
                domicilio = iCResponseAddress.address.address,
                ciudad = iCResponseAddress.address.location,
                departamento = iCResponseAddress.address.department,
                provincia = iCResponseAddress.address.province,
                zona = iCResponseAddress.address.zone,
                pais = iCResponseAddress.address.country
            };

            ICReturnData iCReturnData = new ICReturnData()
            {
                datosCliente = iCReturnClient,
                direccion = iCReturnAddress,
                productos = iCReturnProductList,
                mails = GetMailByIdFormat(iCResponseMail),
                telefono = GetPhoneByIdFormat(iCResponseMail)
            };

            return iCReturnData;
        }

        private static List<ICReturnProduct> GetServiciiosActivosById(DTBRequestEntity model, string idDomicilio)
        {
            DateTime fechaFinal = DateTime.Now;
            List<ICReturnProduct> iCReturnProductList = new List<ICReturnProduct>(); ;
            ICReturnProduct iCReturnProduct = new ICReturnProduct();
            string serie = "";
            string tipo = "";

            int sizei = model.subscriptions.subscription[0].products.product.Count;
            for (int i = 0; i < sizei; i++)
            {
                List<ICProductDetail> iCProductDetailList = new List<ICProductDetail>();
                ICProductDetail iCProductDetail;
                DTBProductDetail dTBProductDetail = model.subscriptions.subscription[0].products.product[i];
                if (dTBProductDetail.addressId.ToString() == idDomicilio)
                {
                    if (dTBProductDetail.creationDate < fechaFinal)
                    {
                        fechaFinal = dTBProductDetail.creationDate;
                    }

                    int sizej = model.subscriptions.subscription[0].products.product[i].components.component.Count;
                    for (int j = 0; j < sizej; j++)
                    {
                        DTBComponentDetail dTBComponentDetail = dTBProductDetail.components.component[j];
                        if (dTBProductDetail.productType == "INTERNET CABLEMODEM")
                        {
                            if (dTBComponentDetail.isMain)
                            {
                                serie = dTBComponentDetail.serviceNumber;
                                tipo = dTBComponentDetail.componentType;
                            }
                        }

                        iCProductDetail = new ICProductDetail()
                        {
                            elemento = dTBComponentDetail.serviceNumber,
                            descripcion = dTBComponentDetail.componentType,
                            tipoServicio = dTBComponentDetail.classService,
                            estado = dTBComponentDetail.componentStatus,
                            principal = dTBComponentDetail.isMain
                        };
                        iCProductDetailList.Add(iCProductDetail);
                    }

                    iCReturnProduct = new ICReturnProduct()
                    {
                        producto = dTBProductDetail.productType,
                        estado = dTBProductDetail.productStatus,
                        detalle = iCProductDetailList
                    };

                    iCReturnProductList.Add(iCReturnProduct);
                }
            }

            var yearsOld = DateTime.Now - fechaFinal;
            int years = (int)(yearsOld.TotalDays / 365.35);
            DataMemoryHelper.Instance().Antiguedad = years.ToString();

            return iCReturnProductList;
        }

        private static List<ICReturnMail> GetMailByIdFormat(ICResponseMail model)
        {
            List<ICReturnMail> iCReturnMailList = new List<ICReturnMail>();
            ICReturnMail iCReturnMail = new ICReturnMail();

            int sizei = model.contactData.mails.mail.Count;
            for (int i = 0; i < sizei; i++)
            {
                ICMailDetail iCMailDetail = model.contactData.mails.mail[i];
                iCReturnMail = new ICReturnMail()
                {
                    mail = iCMailDetail.mail,
                    tipoContanctoMail = iCMailDetail.contactType,
                    tipoMail = iCMailDetail.useType
                };

                iCReturnMailList.Add(iCReturnMail);
            }

            return iCReturnMailList;
        } 

        private static List<ICReturnPhone> GetPhoneByIdFormat(ICResponseMail model)
        {
            List<ICReturnPhone> iCReturnPhoneList = new List<ICReturnPhone>();
            ICReturnPhone iCReturnMail = new ICReturnPhone();

            int sizei = model.contactData.mails.mail.Count;
            for (int i = 0; i < sizei; i++)
            {
                ICPhoneDetail iCPhoneDetail = model.contactData.phones.phone[i];
                iCReturnMail = new ICReturnPhone()
                {
                    codigoPais = iCPhoneDetail.countryCode,
                    codigoArea = iCPhoneDetail.areaCode,
                    telefono = iCPhoneDetail.phone,
                    tipoTelefono = iCPhoneDetail.phoneType
                };

                iCReturnPhoneList.Add(iCReturnMail);
            }

            return iCReturnPhoneList;
        }
    }
}
