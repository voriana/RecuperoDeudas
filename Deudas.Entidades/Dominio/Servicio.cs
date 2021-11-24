using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deudas.Entidades.Dominio
{
    public class Servicio
    {
        private int _id;
        private string _nombre;
        private double _punitarioDiario;
        public Servicio(int id, string nombre, double punitarioDiario)
        {
            _id = id;
            _punitarioDiario = punitarioDiario;
            _nombre = nombre;
        }


        public Servicio()
        {
           
        }

        

        public int Id { get => _id; set => _id = value; }
        public double PunitarioDiario { get => _punitarioDiario; set => _punitarioDiario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
