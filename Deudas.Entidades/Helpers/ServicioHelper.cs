using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deudas.Entidades.Dominio;

namespace Deudas.Entidades.Helpers
{
    public static class ServicioHelper
    {
        private static List<Servicio> _lstServicio;
        static ServicioHelper()
        {
            //inicializo la lista
            _lstServicio = new List<Servicio>();
            Servicio servicio0 = new Servicio(0, "--SELECCIONE--",0);
            Servicio servicio1 = new Servicio(1, "Edenor", 8.45);
            Servicio servicio2 = new Servicio(2, "Expensa", 5.20);
            Servicio servicio3 = new Servicio(3, "Telecom", 2.21);

            _lstServicio.Add(servicio0);
            _lstServicio.Add(servicio1);
            _lstServicio.Add(servicio2);
            _lstServicio.Add(servicio3);
        }
        public static List<Servicio> CargarServicio()
        {
            return  _lstServicio;
        }

        public static Servicio ServicioPorId(int cod)
        {
            Servicio servicio = null;
            foreach(Servicio serv in _lstServicio)
            {
                if (serv.Id == cod)
                {
                    servicio = serv;
                }
            }
            return servicio;

        }

        
       
    }
}
