using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deudas.Entidades.Dominio;
using Deudas.Entidades.Helpers;
using Newtonsoft.Json;

namespace Deudas.Datos
{
    public class PagoMapper
    {
        

        public PagoMapper()
        {
            
        }

        public List<Pago> GetPagos()
        {
            string json = WebHelper.Get("PagoMorosos/890175");
            List<Pago> _pagos = PagoMap(json);
            return _pagos;
        }

        private List<Pago> PagoMap(string json)
        {
            return JsonConvert.DeserializeObject<List<Pago>>(json);
        }

        public TransactionResult PostPago(Pago pago)
        {
            NameValueCollection resultado = ReverseMap(pago);
            string json = WebHelper.Post("PagoMorosos",resultado);
            TransactionResult r = JsonConvert.DeserializeObject<TransactionResult>(json);
            return r;
           
        }

        private NameValueCollection ReverseMap(Pago pago)
        {
            NameValueCollection collection = new NameValueCollection();
            collection.Add("id","0");
            collection.Add("idCliente", "0");
            collection.Add("idServicio", pago.IdServicio.ToString());
            collection.Add("FechaVencimiento",pago.FechaVencimiento.ToString());
            collection.Add("FechaPago", pago.FechaPago.ToString());
            collection.Add("ImporteAdeudado", pago.ImporteAdeudado.ToString());
            collection.Add("InteresPunitario", pago.InteresPunitario.ToString());
            collection.Add("Usuario", pago.Usuario.ToString());
            return collection;

        }
    }
}
