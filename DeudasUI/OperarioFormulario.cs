using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deudas.Entidades.Dominio;

namespace DeudasUI
{
    public  class OperarioFormulario
    {
        private  List<Pago> _pagos;
        private  double PromedioInteres;
        private  double PromedioDias;

        public  OperarioFormulario()
        {
        }

        public  OperarioFormulario(List<Pago> pagos) 
        {
            _pagos = new List<Pago>();
            _pagos = pagos;

        }
        public double PromediDias()
        {

            int acumulador = 0;

            foreach (Pago pago in _pagos)
            {
               
                if ((pago.FechaPago - pago.FechaVencimiento).Days > 0) //esta atrasado
                {
                    
                    acumulador += (pago.FechaPago - pago.FechaVencimiento).Days;
                }
            }
            PromedioDias = acumulador / _pagos.Count();
            return  PromedioDias;
        }
        public double Interesdias()
        {
            double acumulador = 0;

            foreach (Pago pago in _pagos)
            {
                acumulador += pago.InteresPunitario;
                
            }
            PromedioInteres = acumulador / _pagos.Count();
            return PromedioInteres;
        }
    }
}
