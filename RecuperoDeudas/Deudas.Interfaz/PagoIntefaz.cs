using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deudas.Entidades.Dominio;
using Deudas.Entidades.Modelo;
using Deudas.Negocio;

namespace Deudas.Interfaz
{
    public partial class PagoIntefaz : Form
    {
        //private OperacionModel _operaciones;
        private PagoNegocio _pagoNegocio;
        private List<Servicio> _servicios;
        private List<Pago> _pagos;
        public PagoIntefaz()
        {
            InitializeComponent();
            _pagoNegocio = new PagoNegocio();
            _servicios = new List<Servicio>();
            _pagos = new List<Pago>();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargoComboServicio();
            InhabiilitarCampos();
            CargarLista();
            RefrescarCalculos();
        }

        private void RefrescarCalculos()
        {
            OperacionModel operacion = new OperacionModel(_pagos);
            _txtPromAtraso.Text = operacion.PromedioAtraso.ToString("0.00");
            _txtIntProm.Text = operacion.TotalInteresPunitario.ToString("0.00");

        }

        private void CargarLista()
        {
            _pagos = _pagoNegocio.TraerpagosConServicio();
            _lstPagos.DataSource = null;
            _lstPagos.DataSource = _pagos;
            _lstPagos.DisplayMember = "MostrarEnLista";
        }

        private void InhabiilitarCampos()
        {
            _txtPunXdia.Enabled = false;
            _txtIntPunitario.Enabled = false;
            _txtPromAtraso.Enabled = false;
            _txtIntProm.Enabled = false;
            _txtImpTotal.Enabled = false;
        }

        private void CargoComboServicio()
        {
            _servicios = ServicioHelper.ListaServicios();
            _cbServicio.DataSource = _servicios;
            _cbServicio.DisplayMember = "MostrarEnCombo";
        }

        private void _btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones();
                Servicio servicio = ServicioHelper.Servicio(((Servicio)_cbServicio.SelectedItem).Id) ;
                double importe = Convert.ToDouble(_txtAdeudado.Text);
                DateTime fecVenc = Convert.ToDateTime(_txtFecVenc.Text);
                DateTime fecPago = Convert.ToDateTime(_txtFecPago.Text);
                double interesPunitario = Convert.ToDouble(_txtIntPunitario.Text);
                Pago pago = _pagoNegocio.Calcular(servicio, importe, fecPago, fecVenc);
                _txtPunXdia.Text = pago.InteresPunitario.ToString("0.00");
                _txtImpTotal.Text = pago.ImporteTotal.ToString("0.00");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _cbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Servicio)_cbServicio.SelectedItem).Id != 0)
            {
                _txtIntPunitario.Text = ((Servicio)_cbServicio.SelectedItem).Punitario.ToString("0.00");
            }
            //else
            //{
            //    throw new Exception("Debe seleccionar un servicio");
            //}
        }

        private void Validaciones()
        {
            if (((Servicio)_cbServicio.SelectedItem).Id == 0)
            {
                throw new Exception("Debe seleccionar un servicio");
            }

                if (_txtAdeudado.Text != "")
                {
                    if(!double.TryParse(_txtAdeudado.Text, out double salida))
                    {
                        throw new Exception("Debe ingresar un valor numerico");
                    }
                }else
                {
                    throw new Exception("El campo no es obligatorio");
                }
                
            if (_txtFecVenc.Text != "")
            {
                if (!DateTime.TryParse(_txtFecVenc.Text, out DateTime fechaVenc))
                {
                    throw new Exception("Debe ingresar un formato de fecha");
                }
            }
            else
            {
                throw new Exception("El campo no es obligatorio");
            }
            if (_txtFecPago.Text != "")
            {
                if (!DateTime.TryParse(_txtFecPago.Text, out DateTime fechaPago))
                {
                    throw new Exception("Debe ingresar un formato de fecha");
                }
            }
            else
            {
                throw new Exception("El campo  es obligatorio");
            }

        }

        private void Limpiar()
        {
            _cbServicio.SelectedItem = 0;
            _txtPunXdia.Clear();
            _txtAdeudado.Clear();
            _txtFecVenc.Clear();
            _txtFecPago.Clear();
            _txtIntPunitario.Clear();
            _txtImpTotal.Clear();
            _txtPromAtraso.Clear();
            _txtIntProm.Clear();
        }

        private void _btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones();
                Pago pago = new Pago();
                pago.IdServicio = ((Servicio)_cbServicio.SelectedItem).Id;
                pago.FechaVenc = Convert.ToDateTime(_txtFecVenc.Text);
                pago.FechaPago = Convert.ToDateTime(_txtFecPago.Text);
                pago.ImporteAdeudado = Convert.ToDouble(_txtAdeudado.Text);
                pago.Usuario = "890175";
                TransactionResult resultado = _pagoNegocio.Alta(pago);
                if (!resultado.IsOk)
                {
                    MessageBox.Show($"{resultado.Error}");
                }
                else
                {
                    MessageBox.Show($"Pago agregado con ID {resultado.Id}");
                    CargarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
