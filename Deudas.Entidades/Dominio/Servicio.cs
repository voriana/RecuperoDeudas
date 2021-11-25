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
            this._id = id;
            this._punitarioDiario = punitarioDiario;
            this._nombre = nombre;
        }


        public Servicio()
        {
           
        }

        public int Id { get => this._id; set => this._id = value; }
        public double PunitarioDiario { get => this._punitarioDiario; set => this._punitarioDiario = value; }
        public string Nombre { get => this._nombre; set => this._nombre = value; }

        public override string ToString()
        {
            return $"Id{this._id}-{this._nombre}";
        }
    }
}
