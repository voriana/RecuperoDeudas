using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deudas.Entidades.Helpers;

namespace Deudas.Entidades.Dominio
{
    public class Pago
    {
        private int _id;
        private int _idServicio;
        private int _idCliente;
        private DateTime _fechaVencimiento;
        private DateTime _fechaPago;
        private double _importeAdeudado;
        private double _interesPunitario;
        private double _importeTotal;
        private string _usuario;
        private Servicio _servicio;

        public Pago()
        {
        }

        public Pago(int id, int idServicio, int idCliente, DateTime fechaVencimiento, DateTime fechaPago, double importeAdeudado, double interesPunitario, double importeTotal, string usuario)
        {
            this._id = id;
            this._idServicio = idServicio;
            this._idCliente = idCliente;
            this._fechaVencimiento = fechaVencimiento;
            this._fechaPago = fechaPago;
            this._importeAdeudado = importeAdeudado;
            this._interesPunitario = interesPunitario;
            this._importeTotal = importeTotal;
            this._usuario = usuario;
            this._servicio = new Servicio();
        }

        public int Id { get => this._id; set => this._id = value; }
        public int IdServicio { get => this._idServicio; set => this._idServicio = value; }
        public int IdCliente { get => this._idCliente; set => this._idCliente = value; }
        public DateTime FechaVencimiento { get => this._fechaVencimiento; set => this._fechaVencimiento = value; }
        public DateTime FechaPago { get => this._fechaPago; set => this._fechaPago = value; }
        public double ImporteAdeudado { get => this._importeAdeudado; set => this._importeAdeudado = value; }
        public string Usuario { get => this._usuario; set => this._usuario = value; }
        public Servicio Servicio { get => this._servicio; set => this._servicio = value; }

        //autocalculables
        public double InteresPunitario { get => _interesPunitario = (FechaPago - FechaVencimiento).Days * Servicio.PunitarioDiario; set => _interesPunitario = value; }
        public double ImporteTotal { get => (ImporteAdeudado + InteresPunitario); }

        private int AtrasadoDias { get => (FechaPago - FechaVencimiento).Days; }

        public override string ToString()
        {
            return $"idPago{Id}-Servicio {Servicio}";
        }
        public string MostrarEnLista
        {
            get { return $"{Id}- Importe total: {ImporteTotal.ToString("0.00")}"; }
        }

        public Servicio CargarServicio(int idServicio) 
        {
            _servicio = ServicioHelper.ServicioPorId(IdServicio);
            return _servicio;
        }

     
    }

}
