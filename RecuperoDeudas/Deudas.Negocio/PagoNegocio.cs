using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deudas.Datos;
using Deudas.Entidades.Dominio;
using Deudas.Entidades.Modelo;

namespace Deudas.Negocio
{
    public class PagoNegocio
    {
        private PagoMapper _pagoMapper;
        public PagoNegocio()
        {
            _pagoMapper = new PagoMapper();
        }

        public Pago Calcular(Servicio servicio, double importe, DateTime fecPago, DateTime fecVen) { 
            Pago pago = new Pago();
            pago.Id = servicio.Id;
            pago.ImporteAdeudado = importe;
            pago.FechaVenc = fecVen;
            pago.FechaPago = fecPago;
            pago.Servicio = servicio;
            return pago;
        }

        public List<Pago> TraerPagos()
        {
            List<Pago> pagos = _pagoMapper.GetPagos();
            return pagos;
        }
        public List<Pago> TraerpagosConServicio()
        {
            List<Pago> pagos = _pagoMapper.GetPagos();
            List<Servicio> servicios = ServicioHelper.ListaServicios();
            if (pagos != null)
            {
                foreach(Pago pago in pagos)
                {
                    foreach(Servicio servicio in servicios)
                    {
                        if (pago.IdServicio == servicio.Id)
                        {
                            pago.Servicio = servicio;
                        }
                    }
                }
            }
            return pagos;
        }

        public TransactionResult Alta(Pago pago)
        {
            pago.Servicio = ServicioHelper.Servicio(pago.IdServicio);
            TransactionResult altaResult = _pagoMapper.NuevoPago(pago);
            return altaResult;
        }
    }
}
