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
using Deudas.Entidades.Helpers;
using Deudas.Negocio;

namespace DeudasUI
{
    public partial class Cobranza : Form
    {
        private List<Pago> _pagos;
        private PagoNegocio _PagoServicio;
        private List<Servicio> _servicios;
        string usuario = "890175";
        public Cobranza()
        {
            InitializeComponent();
            _pagos = new List<Pago>();
            _PagoServicio = new PagoNegocio();
        }

        private void Cobranza_Load(object sender, EventArgs e)
        {
            CargaLista();
            CargaComboServicio();
            Limpiar();
        }

        private void CargaLista()
        {
            _pagos = _PagoServicio.ListarPagos();
            lstPagos.DataSource = null;
            lstPagos.DataSource = _pagos;
            lstPagos.DisplayMember = "MostrarEnLista";
        }

        private void CargaComboServicio()
        {
            _servicios = ServicioHelper.CargarServicio();
            cbServicio.DataSource = null;
            cbServicio.DataSource = _servicios;
            cbServicio.DisplayMember = "Nombre";
        }
     
        //boton calcular
        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones();
                Pago p = Pago();
                txtPunitario.Text = p.InteresPunitario.ToString();
                txtImporteTotal.Text = p.ImporteTotal.ToString("0.00");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //validaciones
        private void Validaciones()
        {
            Servicio servicio = (Servicio)cbServicio.SelectedItem;
            double importe;
            DateTime fechaVenc;
            DateTime fechaPago;

            if (servicio.Id==0)
            {
                throw new Exception("Debe seleccionar un servicio");
            }
            if (txtImporteAde.Text==""||txtfecVenc.Text==""||txtFecPago.Text=="")
            {
                throw new Exception("Debe completar todos los campos");
            }
            else
            {
                if(!double.TryParse(txtImporteAde.Text, out double salida))
                {
                    throw new Exception("Debe ingresar un valor numerico");
                }
                else
                {
                    importe = Convert.ToDouble(txtImporteAde.Text);
                }
            }
            if(!DateTime.TryParse(txtfecVenc.Text, out DateTime  vencimiento)|| !DateTime.TryParse(txtFecPago.Text, out DateTime pago))
            {
                throw new Exception("Formato de fecha invalido");
            }
            else
            {
                fechaVenc = vencimiento;
                fechaPago = pago;
            }
        }
        private void cbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servicio servicio = (Servicio)cbServicio.SelectedItem;
            txtInteresPuni.Text = servicio.PunitarioDiario.ToString("0.00");
        }
        private void Limpiar()
        {
            cbServicio.SelectedIndex =0;
            txtFecPago.Clear();
            txtfecVenc.Clear();
            txtImporteAde.Clear();
        }
        private void Calculos()
        {
            try
            {
                OperarioFormulario operario = new OperarioFormulario(_pagos);
                diasAtrasoProm.Text = operario.PromediDias().ToString();
                txtInteresProm.Text = operario.Interesdias().ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                Pago pago = Pago();
                pago.Usuario = usuario;
                pago.IdServicio = pago.Servicio.Id;
                TransactionResult resultado = _PagoServicio.EnviarNuevoPago(pago);
                MessageBox.Show("Pago exitoso");
                Refrescar();
                Limpiar();
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        //metodo para setear valores de un pago
        private Pago Pago()
        {
            Pago p = new Pago();
            p.ImporteAdeudado = double.Parse(txtImporteAde.Text.ToString());
            p.FechaVencimiento = DateTime.Parse(txtfecVenc.Text);
            p.FechaPago = DateTime.Parse(txtFecPago.Text);
            p.FechaPago = DateTime.Parse(txtFecPago.Text);
            p.Servicio = new Servicio();
            p.Servicio = ServicioHelper.ServicioPorId(((Servicio)cbServicio.SelectedItem).Id);
            
            p.InteresPunitario = double.Parse(txtInteresPuni.Text);
            
            
            return p;
        }
  
        private void Refrescar()
        {   _pagos= _PagoServicio.ListarPagos();
            lstPagos.DataSource = _pagos;
            Calculos();
        }
    }
}
