using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deudas.Entidades.Dominio;
using Deudas.Entidades.Modelo;
using Newtonsoft.Json;

namespace Deudas.Datos
{
    public class PagoMapper
    {
        public List<Pago> GetPagos()
        {
            string json = WebHelper.Get("PagoMorosos/890175");
            List<Pago> Lst = PagoMap(json);
            return Lst;
        }

        private List<Pago> PagoMap(string json)
        {
            List<Pago> _pagos = JsonConvert.DeserializeObject<List<Pago>>(json);
            return _pagos;
        }

        public TransactionResult NuevoPago(Pago pago)
        {
            NameValueCollection obj = reverseMap(pago);
            string json = WebHelper.Post("PagoMorosos", obj);
            TransactionResult respuesta=JsonConvert.DeserializeObject<TransactionResult>(json);
            return respuesta;
        }

        private NameValueCollection reverseMap(Pago pago)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id",pago.Id.ToString());
            n.Add("idCliente", pago.IdCliente.ToString());
            n.Add("idServicio", pago.IdServicio.ToString());
            n.Add("FechaVencimiento", pago.FechaVenc.ToString());
            n.Add("FechaPago", pago.FechaPago.ToString());
            n.Add("ImporteAdeudado", pago.ImporteAdeudado.ToString("0.00"));
            n.Add("InteresPunitario", pago.InteresPunitario.ToString("0.00"));
            n.Add("Usuario", pago.Usuario);
            return n;

        }
    }
}
