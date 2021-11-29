using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deudas.Entidades.Dominio;

namespace Deudas.Entidades.Modelo
{
    public static class ServicioHelper
    {
        private static List<Servicio> _servicios;

        static ServicioHelper()
        {
            _servicios = new List<Servicio>();
            Servicio servicio1 = new Servicio(0, "Seleccione", 0);
            Servicio servicio2 = new Servicio(1, "Edenor", 8.45);
            Servicio servicio3 = new Servicio(2, "Expensas", 5.20);
            Servicio servicio4 = new Servicio(3, "Telecom", 2.21);

            _servicios.Add(servicio1);
            _servicios.Add(servicio2);
            _servicios.Add(servicio3);
            _servicios.Add(servicio4);

        }
        public static List<Servicio> ListaServicios()
        {
            return _servicios;
        }

        public static Servicio Servicio(int idServicio)
        {
            Servicio serv = new Servicio();
            if (_servicios != null)
            {
                foreach(Servicio servicio in _servicios)
                {
                    if (servicio.Id == idServicio)
                    {
                        serv= servicio;
                    }
                  
                }
            }
            return serv;
        }
    }
}
