﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deudas.Datos;
using Deudas.Entidades.Dominio;
using Deudas.Entidades.Helpers;

namespace Deudas.Negocio
{
    public class PagoNegocio
    {
        private PagoMapper _pagoMapper;
        private List<Servicio> _servicios;
        private List<Pago> _pagos;

        public PagoNegocio()
        {
            _pagoMapper = new PagoMapper();
            _pagos = new List<Pago>();
            _servicios = new List<Servicio>();
        }

       public List<Pago> ListarPagos()
       {
            _pagos = _pagoMapper.GetPagos();
            foreach(Pago pago in _pagos)
            {
                pago.Servicio = ServicioHelper.ServicioPorId(pago.IdServicio);
            }
            return _pagos;
       } 
       public TransactionResult EnviarNuevoPago(Pago pago)
        {
        TransactionResult resultado = _pagoMapper.PostPago(pago);
            return resultado;
        }
       
    }
}
