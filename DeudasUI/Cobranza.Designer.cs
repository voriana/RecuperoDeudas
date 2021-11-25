
namespace DeudasUI
{
    partial class Cobranza
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbImporteTotal = new System.Windows.Forms.Label();
            this.lbIntPunitario = new System.Windows.Forms.Label();
            this.lbfecPago = new System.Windows.Forms.Label();
            this.txtFecPago = new System.Windows.Forms.TextBox();
            this.lbFecVen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPunitario = new System.Windows.Forms.Label();
            this.lbServicio = new System.Windows.Forms.Label();
            this.lbTituloPago = new System.Windows.Forms.Label();
            this.cbServicio = new System.Windows.Forms.ComboBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtImporteTotal = new System.Windows.Forms.TextBox();
            this.txtInteresPuni = new System.Windows.Forms.TextBox();
            this.txtfecVenc = new System.Windows.Forms.TextBox();
            this.txtImporteAde = new System.Windows.Forms.TextBox();
            this.txtPunitario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbInteresProm = new System.Windows.Forms.Label();
            this.lbAtraso = new System.Windows.Forms.Label();
            this.lbTituloMora = new System.Windows.Forms.Label();
            this.lstPagos = new System.Windows.Forms.ListBox();
            this.txtInteresProm = new System.Windows.Forms.TextBox();
            this.diasAtrasoProm = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbImporteTotal);
            this.panel1.Controls.Add(this.lbIntPunitario);
            this.panel1.Controls.Add(this.lbfecPago);
            this.panel1.Controls.Add(this.txtFecPago);
            this.panel1.Controls.Add(this.lbFecVen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbPunitario);
            this.panel1.Controls.Add(this.lbServicio);
            this.panel1.Controls.Add(this.lbTituloPago);
            this.panel1.Controls.Add(this.cbServicio);
            this.panel1.Controls.Add(this.btnPagar);
            this.panel1.Controls.Add(this.btCalcular);
            this.panel1.Controls.Add(this.txtImporteTotal);
            this.panel1.Controls.Add(this.txtInteresPuni);
            this.panel1.Controls.Add(this.txtfecVenc);
            this.panel1.Controls.Add(this.txtImporteAde);
            this.panel1.Controls.Add(this.txtPunitario);
            this.panel1.Location = new System.Drawing.Point(22, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 347);
            this.panel1.TabIndex = 0;
            // 
            // lbImporteTotal
            // 
            this.lbImporteTotal.AutoSize = true;
            this.lbImporteTotal.Location = new System.Drawing.Point(16, 286);
            this.lbImporteTotal.Name = "lbImporteTotal";
            this.lbImporteTotal.Size = new System.Drawing.Size(69, 13);
            this.lbImporteTotal.TabIndex = 19;
            this.lbImporteTotal.Text = "Importe Total";
            // 
            // lbIntPunitario
            // 
            this.lbIntPunitario.AutoSize = true;
            this.lbIntPunitario.Location = new System.Drawing.Point(16, 251);
            this.lbIntPunitario.Name = "lbIntPunitario";
            this.lbIntPunitario.Size = new System.Drawing.Size(83, 13);
            this.lbIntPunitario.TabIndex = 18;
            this.lbIntPunitario.Text = "Interes Punitario";
            // 
            // lbfecPago
            // 
            this.lbfecPago.AutoSize = true;
            this.lbfecPago.Location = new System.Drawing.Point(13, 193);
            this.lbfecPago.Name = "lbfecPago";
            this.lbfecPago.Size = new System.Drawing.Size(80, 13);
            this.lbfecPago.TabIndex = 17;
            this.lbfecPago.Text = "Fecha de Pago";
            // 
            // txtFecPago
            // 
            this.txtFecPago.Location = new System.Drawing.Point(178, 186);
            this.txtFecPago.Name = "txtFecPago";
            this.txtFecPago.Size = new System.Drawing.Size(100, 20);
            this.txtFecPago.TabIndex = 16;
            // 
            // lbFecVen
            // 
            this.lbFecVen.AutoSize = true;
            this.lbFecVen.Location = new System.Drawing.Point(13, 160);
            this.lbFecVen.Name = "lbFecVen";
            this.lbFecVen.Size = new System.Drawing.Size(112, 13);
            this.lbFecVen.TabIndex = 15;
            this.lbFecVen.Text = "Fecha de vencimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Importe Adeudado";
            // 
            // lbPunitario
            // 
            this.lbPunitario.AutoSize = true;
            this.lbPunitario.Location = new System.Drawing.Point(13, 92);
            this.lbPunitario.Name = "lbPunitario";
            this.lbPunitario.Size = new System.Drawing.Size(83, 13);
            this.lbPunitario.TabIndex = 13;
            this.lbPunitario.Text = "Punitario por dia";
            // 
            // lbServicio
            // 
            this.lbServicio.AutoSize = true;
            this.lbServicio.Location = new System.Drawing.Point(13, 56);
            this.lbServicio.Name = "lbServicio";
            this.lbServicio.Size = new System.Drawing.Size(45, 13);
            this.lbServicio.TabIndex = 12;
            this.lbServicio.Text = "Servicio";
            // 
            // lbTituloPago
            // 
            this.lbTituloPago.AutoSize = true;
            this.lbTituloPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPago.Location = new System.Drawing.Point(54, 14);
            this.lbTituloPago.Name = "lbTituloPago";
            this.lbTituloPago.Size = new System.Drawing.Size(224, 22);
            this.lbTituloPago.TabIndex = 11;
            this.lbTituloPago.Text = "Formulario de Pago Tardio";
            this.lbTituloPago.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbServicio
            // 
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Location = new System.Drawing.Point(178, 53);
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(100, 21);
            this.cbServicio.TabIndex = 7;
            this.cbServicio.SelectedIndexChanged += new System.EventHandler(this.cbServicio_SelectedIndexChanged);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(19, 312);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(259, 23);
            this.btnPagar.TabIndex = 6;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(16, 219);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(262, 23);
            this.btCalcular.TabIndex = 5;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Enabled = false;
            this.txtImporteTotal.Location = new System.Drawing.Point(178, 286);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.Size = new System.Drawing.Size(100, 20);
            this.txtImporteTotal.TabIndex = 4;
            // 
            // txtInteresPuni
            // 
            this.txtInteresPuni.Enabled = false;
            this.txtInteresPuni.Location = new System.Drawing.Point(178, 248);
            this.txtInteresPuni.Name = "txtInteresPuni";
            this.txtInteresPuni.Size = new System.Drawing.Size(100, 20);
            this.txtInteresPuni.TabIndex = 3;
            // 
            // txtfecVenc
            // 
            this.txtfecVenc.Location = new System.Drawing.Point(178, 153);
            this.txtfecVenc.Name = "txtfecVenc";
            this.txtfecVenc.Size = new System.Drawing.Size(100, 20);
            this.txtfecVenc.TabIndex = 2;
            // 
            // txtImporteAde
            // 
            this.txtImporteAde.Location = new System.Drawing.Point(178, 120);
            this.txtImporteAde.Name = "txtImporteAde";
            this.txtImporteAde.Size = new System.Drawing.Size(100, 20);
            this.txtImporteAde.TabIndex = 1;
            // 
            // txtPunitario
            // 
            this.txtPunitario.Enabled = false;
            this.txtPunitario.Location = new System.Drawing.Point(178, 87);
            this.txtPunitario.Name = "txtPunitario";
            this.txtPunitario.Size = new System.Drawing.Size(100, 20);
            this.txtPunitario.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbInteresProm);
            this.panel2.Controls.Add(this.lbAtraso);
            this.panel2.Controls.Add(this.lbTituloMora);
            this.panel2.Controls.Add(this.lstPagos);
            this.panel2.Controls.Add(this.txtInteresProm);
            this.panel2.Controls.Add(this.diasAtrasoProm);
            this.panel2.Location = new System.Drawing.Point(412, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 347);
            this.panel2.TabIndex = 1;
            // 
            // lbInteresProm
            // 
            this.lbInteresProm.AutoSize = true;
            this.lbInteresProm.Location = new System.Drawing.Point(40, 317);
            this.lbInteresProm.Name = "lbInteresProm";
            this.lbInteresProm.Size = new System.Drawing.Size(86, 13);
            this.lbInteresProm.TabIndex = 21;
            this.lbInteresProm.Text = "Interes Promedio";
            // 
            // lbAtraso
            // 
            this.lbAtraso.AutoSize = true;
            this.lbAtraso.Location = new System.Drawing.Point(40, 289);
            this.lbAtraso.Name = "lbAtraso";
            this.lbAtraso.Size = new System.Drawing.Size(121, 13);
            this.lbAtraso.TabIndex = 20;
            this.lbAtraso.Text = "Dias de atraso promedio";
            // 
            // lbTituloMora
            // 
            this.lbTituloMora.AutoSize = true;
            this.lbTituloMora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloMora.Location = new System.Drawing.Point(84, 14);
            this.lbTituloMora.Name = "lbTituloMora";
            this.lbTituloMora.Size = new System.Drawing.Size(153, 22);
            this.lbTituloMora.TabIndex = 12;
            this.lbTituloMora.Text = "Reporte de Moras";
            this.lbTituloMora.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstPagos
            // 
            this.lstPagos.FormattingEnabled = true;
            this.lstPagos.Location = new System.Drawing.Point(43, 53);
            this.lstPagos.Name = "lstPagos";
            this.lstPagos.Size = new System.Drawing.Size(258, 212);
            this.lstPagos.TabIndex = 10;
            // 
            // txtInteresProm
            // 
            this.txtInteresProm.Location = new System.Drawing.Point(201, 312);
            this.txtInteresProm.Name = "txtInteresProm";
            this.txtInteresProm.Size = new System.Drawing.Size(100, 20);
            this.txtInteresProm.TabIndex = 9;
            // 
            // diasAtrasoProm
            // 
            this.diasAtrasoProm.Location = new System.Drawing.Point(201, 277);
            this.diasAtrasoProm.Name = "diasAtrasoProm";
            this.diasAtrasoProm.Size = new System.Drawing.Size(100, 20);
            this.diasAtrasoProm.TabIndex = 8;
            // 
            // Cobranza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Cobranza";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Cobranza_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbImporteTotal;
        private System.Windows.Forms.Label lbIntPunitario;
        private System.Windows.Forms.Label lbfecPago;
        private System.Windows.Forms.TextBox txtFecPago;
        private System.Windows.Forms.Label lbFecVen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPunitario;
        private System.Windows.Forms.Label lbServicio;
        private System.Windows.Forms.Label lbTituloPago;
        private System.Windows.Forms.ComboBox cbServicio;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox txtImporteTotal;
        private System.Windows.Forms.TextBox txtInteresPuni;
        private System.Windows.Forms.TextBox txtfecVenc;
        private System.Windows.Forms.TextBox txtImporteAde;
        private System.Windows.Forms.TextBox txtPunitario;
        private System.Windows.Forms.Label lbInteresProm;
        private System.Windows.Forms.Label lbAtraso;
        private System.Windows.Forms.Label lbTituloMora;
        private System.Windows.Forms.ListBox lstPagos;
        private System.Windows.Forms.TextBox txtInteresProm;
        private System.Windows.Forms.TextBox diasAtrasoProm;
    }
}

