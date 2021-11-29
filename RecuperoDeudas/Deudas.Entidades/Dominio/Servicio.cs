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
        private double _punitario;

        public Servicio()
        {
        }

        public Servicio(int id, string nombre, double punitario)
        {
            _id = id;
            _nombre = nombre;
            _punitario = punitario;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Punitario { get => _punitario; set => _punitario = value; }
        
        public string MostrarEnCombo
        {
            get { return $"{Id}-{this.Nombre}"; }
        }

    }
}
