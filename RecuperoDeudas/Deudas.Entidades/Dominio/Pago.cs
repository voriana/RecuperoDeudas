using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deudas.Entidades.Dominio
{
    public class Pago
    {
        private int _id;
        private int _idCliente;
        private int _idServicio;
        private DateTime _fechaVenc;
        private DateTime _fechaPago;
        private double _importeAdeudado;
        private string _usuario;
        private Servicio _servicio;

        public Pago()
        {
        }

        public Pago(int id, int idCliente, int idServicio, DateTime fechaVenc, DateTime fechaPago, double importeAdeudado, string usuario, Servicio servicio)
        {
            _id = id;
            _idCliente = idCliente;
            _idServicio = idServicio;
            _fechaVenc = fechaVenc;
            _fechaPago = fechaPago;
            _importeAdeudado = importeAdeudado;
            _usuario = usuario;
            _servicio = servicio;
        }

        public int Id { get => _id; set => _id = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdServicio { get => _idServicio; set => _idServicio = value; }
        public DateTime FechaVenc { get => _fechaVenc; set => _fechaVenc = value; }
        public DateTime FechaPago { get => _fechaPago; set => _fechaPago = value; }
        public double ImporteAdeudado { get => _importeAdeudado; set => _importeAdeudado = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public Servicio Servicio { get => _servicio; set => _servicio = value; }

        //autocalculable
        public double InteresPunitario
        {
            get { return (this.FechaPago - this.FechaVenc).Days*Servicio.Punitario; }
        }
        public double ImporteTotal
        {
            get { return ImporteAdeudado + InteresPunitario; }
        }

        public override string ToString()
        {
            return $"{this.Id}-{this.Servicio.Nombre}-{this.ImporteTotal}dias atraso: {this.FechaPago-this.FechaVenc}";
        }
        public string MostrarEnLista
        {
            get { return $"{this.Id}- {this.Servicio.Nombre}-{this.ImporteTotal}- dias atraso: {((short)((this.FechaPago - this.FechaVenc).Days))}"; }
        }

    }
}
