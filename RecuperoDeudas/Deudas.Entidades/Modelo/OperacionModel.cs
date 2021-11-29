using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deudas.Entidades.Dominio;

namespace Deudas.Entidades.Modelo
{
    public class OperacionModel
    {
        private List<Pago> _pagos;
        private double _promAtraso = 0;
        private double _promInteres = 0;

        public OperacionModel(List<Pago> pagos)
        {
            _pagos = new List<Pago>();
            _pagos = pagos;
        }

        public Double PromedioAtraso
        {
            get
            {
                double acumulador = 0;

                if (_pagos != null)
                {
                    foreach (Pago pago in _pagos)
                    {
                        int dias = (pago.FechaPago - pago.FechaVenc).Days;
                        if (dias > 0)
                        {
                            acumulador += dias;
                        }
                    }
                    _promAtraso = acumulador / _pagos.Count;
                }
                else
                {
                    return 0;
                }
                return _promAtraso;
            }
        }

        public Double TotalInteresPunitario
        { get 
            {
                double acumulador = 0;
                if (_pagos != null)
                {
                    foreach(Pago pago in _pagos)
                    {
                        acumulador += pago.InteresPunitario;
                    }
                    _promInteres = acumulador / _pagos.Count;
                }
                else
                {
                    return 0;
                }
                return _promInteres;
            } 
        }
    }
}
