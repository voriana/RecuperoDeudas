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
        }

        private void CargaLista()
        {
            _pagos = _PagoServicio.ListaPagos();
            lstPagos.DataSource = null;
            lstPagos.DataSource = _pagos;
        }

        private void CargaComboServicio()
        {
            _servicios = ServicioHelper.CargarServicio();
            cbServicio.DataSource = null;
            cbServicio.DataSource = _servicios;
            cbServicio.DisplayMember = "Nombre";
        }
        private void cbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbServicio.SelectedIndex > -1)
            {
                Servicio servicio = (Servicio)cbServicio.SelectedItem;
                txtInteresPuni.Text = servicio.PunitarioDiario.ToString("0.00");
            }
            else
            {
                throw new Exception("Debe seleccionar un item");
            }
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtImporteAde.Text))
                {   
                
                    if (double.TryParse(txtImporteAde.Text, out double salida))
                    {
                        importeAdeudado = Convert.ToDouble(salida.ToString("0.00"));
                        
                    }
                    else
                    {
                        txtImporteAde.Focus();
                        txtImporteAde.BackColor = Color.Red;
                        throw new Exception("Debe ingresar un valor numerico");
                    }
                }
                else
                {
                    txtImporteAde.Focus();
                    txtImporteAde.BackColor = Color.Red;
                    throw new Exception("El campo no puede estar vacio");
                }
                if (!(txtfecVenc.Text == ""))
                {
                    if (DateTime.TryParse(txtfecVenc.Text, out DateTime resul))
                    {
                        fechaVenc =Convert.ToDateTime(resul.ToString("yyyy-MM-dd"));
                    }
                    else
                    {
                        txtfecVenc.Focus();
                        txtfecVenc.BackColor = Color.Red;
                        throw new Exception("Formato invalido");
                    }
                }
                else
                {
                    txtfecVenc.Focus();
                    txtfecVenc.BackColor = Color.Red;
                    throw new Exception("El campo no puede estar vacio");
                }
                if (!(txtFecPago.Text == ""))
                {
                    if (DateTime.TryParse(txtFecPago.Text, out DateTime resul))
                    {
                        fechaPago = Convert.ToDateTime(resul.ToString("yyyy-MM-dd"));
                    }
                    else
                    {
                        txtFecPago.Focus();
                        txtFecPago.BackColor = Color.Red;
                        throw new Exception("Formato invalido");
                    }
                }
                else
                {
                    txtFecPago.Focus();
                    txtFecPago.BackColor = Color.Red;
                    throw new Exception("El campo no puede estar vacio");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
     
        int id;
        int idServicio;
        int idCliente;
        DateTime fechaVenc;
        DateTime fechaPago;
        double importeAdeudado;
        double interesPunitario =0;
        string usuario="890175";


    }
}
