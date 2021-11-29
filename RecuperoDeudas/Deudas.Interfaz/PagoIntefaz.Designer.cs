
namespace Deudas.Interfaz
{
    partial class PagoIntefaz
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
            this.label1 = new System.Windows.Forms.Label();
            this._cbServicio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtPunXdia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtAdeudado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtFecVenc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtFecPago = new System.Windows.Forms.TextBox();
            this._btnCalcular = new System.Windows.Forms.Button();
            this._txtIntPunitario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._txtImpTotal = new System.Windows.Forms.TextBox();
            this._btnAlta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._lstPagos = new System.Windows.Forms.ListBox();
            this._txtPromAtraso = new System.Windows.Forms.TextBox();
            this._txtIntProm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Servicio";
            // 
            // _cbServicio
            // 
            this._cbServicio.FormattingEnabled = true;
            this._cbServicio.Location = new System.Drawing.Point(148, 35);
            this._cbServicio.Name = "_cbServicio";
            this._cbServicio.Size = new System.Drawing.Size(121, 21);
            this._cbServicio.TabIndex = 1;
            this._cbServicio.SelectedIndexChanged += new System.EventHandler(this._cbServicio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Punitario por dia";
            // 
            // _txtPunXdia
            // 
            this._txtPunXdia.Location = new System.Drawing.Point(148, 69);
            this._txtPunXdia.Name = "_txtPunXdia";
            this._txtPunXdia.Size = new System.Drawing.Size(121, 20);
            this._txtPunXdia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Importe Adeudado";
            // 
            // _txtAdeudado
            // 
            this._txtAdeudado.Location = new System.Drawing.Point(148, 113);
            this._txtAdeudado.Name = "_txtAdeudado";
            this._txtAdeudado.Size = new System.Drawing.Size(121, 20);
            this._txtAdeudado.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // _txtFecVenc
            // 
            this._txtFecVenc.Location = new System.Drawing.Point(148, 157);
            this._txtFecVenc.Name = "_txtFecVenc";
            this._txtFecVenc.Size = new System.Drawing.Size(121, 20);
            this._txtFecVenc.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Pago";
            // 
            // _txtFecPago
            // 
            this._txtFecPago.Location = new System.Drawing.Point(148, 203);
            this._txtFecPago.Name = "_txtFecPago";
            this._txtFecPago.Size = new System.Drawing.Size(121, 20);
            this._txtFecPago.TabIndex = 9;
            // 
            // _btnCalcular
            // 
            this._btnCalcular.Location = new System.Drawing.Point(34, 239);
            this._btnCalcular.Name = "_btnCalcular";
            this._btnCalcular.Size = new System.Drawing.Size(235, 23);
            this._btnCalcular.TabIndex = 10;
            this._btnCalcular.Text = "CALCULAR";
            this._btnCalcular.UseVisualStyleBackColor = true;
            this._btnCalcular.Click += new System.EventHandler(this._btnCalcular_Click);
            // 
            // _txtIntPunitario
            // 
            this._txtIntPunitario.Location = new System.Drawing.Point(148, 278);
            this._txtIntPunitario.Name = "_txtIntPunitario";
            this._txtIntPunitario.Size = new System.Drawing.Size(121, 20);
            this._txtIntPunitario.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Interes Punitario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Importe Total";
            // 
            // _txtImpTotal
            // 
            this._txtImpTotal.Location = new System.Drawing.Point(148, 328);
            this._txtImpTotal.Name = "_txtImpTotal";
            this._txtImpTotal.Size = new System.Drawing.Size(121, 20);
            this._txtImpTotal.TabIndex = 14;
            // 
            // _btnAlta
            // 
            this._btnAlta.Location = new System.Drawing.Point(39, 368);
            this._btnAlta.Name = "_btnAlta";
            this._btnAlta.Size = new System.Drawing.Size(230, 23);
            this._btnAlta.TabIndex = 15;
            this._btnAlta.Text = "ALTA";
            this._btnAlta.UseVisualStyleBackColor = true;
            this._btnAlta.Click += new System.EventHandler(this._btnAlta_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._btnAlta);
            this.panel1.Controls.Add(this._cbServicio);
            this.panel1.Controls.Add(this._txtImpTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this._txtPunXdia);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this._txtIntPunitario);
            this.panel1.Controls.Add(this._txtAdeudado);
            this.panel1.Controls.Add(this._btnCalcular);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this._txtFecPago);
            this.panel1.Controls.Add(this._txtFecVenc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(36, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 409);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._lstPagos);
            this.panel2.Location = new System.Drawing.Point(425, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 306);
            this.panel2.TabIndex = 16;
            // 
            // _lstPagos
            // 
            this._lstPagos.FormattingEnabled = true;
            this._lstPagos.Location = new System.Drawing.Point(0, 0);
            this._lstPagos.Name = "_lstPagos";
            this._lstPagos.Size = new System.Drawing.Size(333, 303);
            this._lstPagos.TabIndex = 0;
            // 
            // _txtPromAtraso
            // 
            this._txtPromAtraso.Location = new System.Drawing.Point(640, 360);
            this._txtPromAtraso.Name = "_txtPromAtraso";
            this._txtPromAtraso.Size = new System.Drawing.Size(121, 20);
            this._txtPromAtraso.TabIndex = 16;
            // 
            // _txtIntProm
            // 
            this._txtIntProm.Location = new System.Drawing.Point(640, 400);
            this._txtIntProm.Name = "_txtIntProm";
            this._txtIntProm.Size = new System.Drawing.Size(121, 20);
            this._txtIntProm.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Dias De atraso Promedio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Interes Promedio";
            // 
            // PagoIntefaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._txtIntProm);
            this.Controls.Add(this._txtPromAtraso);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PagoIntefaz";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtPunXdia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtAdeudado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtFecVenc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtFecPago;
        private System.Windows.Forms.Button _btnCalcular;
        private System.Windows.Forms.TextBox _txtIntPunitario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _txtImpTotal;
        private System.Windows.Forms.Button _btnAlta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox _lstPagos;
        private System.Windows.Forms.TextBox _txtPromAtraso;
        private System.Windows.Forms.TextBox _txtIntProm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

