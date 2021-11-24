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
        private int _idServicio;
        private int _idCliente;
        private DateTime _fechaVencimiento;
        private DateTime _fechaPago;
        private double _importeAdeudado;
        private double _interesPunitario;
        private double _importeTotal;
        private string _usuario;
        private Servicio _servicio;
       

        public Pago(int id, int idServicio, int idCliente, DateTime fechaVencimiento, DateTime fechaPago, double importeAdeudado, double interesPunitario, double importeTotal, string usuario)
        {
            _id = id;
            _idServicio = idServicio;
            _idCliente = idCliente;
            _fechaVencimiento = fechaVencimiento;
            _fechaPago = fechaPago;
            _importeAdeudado = importeAdeudado;
            _interesPunitario = interesPunitario;
            _importeTotal = importeTotal;
            _usuario = usuario;

            
        }

        public int Id { get => _id; set => _id = value; }
        public int IdServicio { get => _idServicio; set => _idServicio = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public DateTime FechaVencimiento { get => _fechaVencimiento; set => _fechaVencimiento = value; }
        public DateTime FechaPago { get => _fechaPago; set => _fechaPago = value; }
        public double ImporteAdeudado { get => _importeAdeudado; set => _importeAdeudado = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public Servicio Servicio { get => _servicio; set => _servicio = value; }

        //autocalculables
        public double InteresPunitario { get => _interesPunitario; set => _interesPunitario = (FechaPago - FechaVencimiento).TotalDays * Servicio.PunitarioDiario; }
        public double ImporteTotal { get => _importeTotal; set => _importeTotal = ImporteAdeudado + InteresPunitario; }

        public override string ToString()
        {
            return $"id{Id}-{Servicio}- Importe total: {ImporteTotal}";
        }


    }

}
