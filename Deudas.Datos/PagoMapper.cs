using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deudas.Entidades.Dominio;
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
    }
}
