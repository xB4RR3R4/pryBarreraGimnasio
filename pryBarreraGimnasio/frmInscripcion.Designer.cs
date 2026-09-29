namespace pryBarreraGimnasio
{
    partial class frmInscripcion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpPlan = new GroupBox();
            chkCasillero = new CheckBox();
            txtMeses = new TextBox();
            lblMeses = new Label();
            cboTurno = new ComboBox();
            lblTurno = new Label();
            lblPlan = new Label();
            cboPlan = new ComboBox();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            cboCuotas = new ComboBox();
            lblCuotas = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            grpDatosPersonales = new GroupBox();
            chkEstudiante = new CheckBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            lblNombre = new Label();
            grpFormaDePago = new GroupBox();
            tbcGimansio = new TabControl();
            tbpDatos = new TabPage();
            tbpPlan = new TabPage();
            tbpPago = new TabPage();
            grpPlan.SuspendLayout();
            grpDatosPersonales.SuspendLayout();
            grpFormaDePago.SuspendLayout();
            tbcGimansio.SuspendLayout();
            tbpDatos.SuspendLayout();
            tbpPlan.SuspendLayout();
            tbpPago.SuspendLayout();
            SuspendLayout();
            // 
            // grpPlan
            // 
            grpPlan.Controls.Add(chkCasillero);
            grpPlan.Controls.Add(txtMeses);
            grpPlan.Controls.Add(lblMeses);
            grpPlan.Controls.Add(cboTurno);
            grpPlan.Controls.Add(lblTurno);
            grpPlan.Controls.Add(lblPlan);
            grpPlan.Controls.Add(cboPlan);
            grpPlan.Location = new Point(6, 6);
            grpPlan.Name = "grpPlan";
            grpPlan.Size = new Size(198, 160);
            grpPlan.TabIndex = 0;
            grpPlan.TabStop = false;
            grpPlan.Text = "Plan";
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(22, 132);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(145, 19);
            chkCasillero.TabIndex = 11;
            chkCasillero.Text = "Casillero ($ 3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(78, 103);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(100, 23);
            txtMeses.TabIndex = 10;
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(21, 106);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(43, 15);
            lblMeses.TabIndex = 9;
            lblMeses.Text = "Meses:";
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(79, 69);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(100, 23);
            cboTurno.TabIndex = 8;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(22, 72);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(42, 15);
            lblTurno.TabIndex = 7;
            lblTurno.Text = "Turno:";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(22, 37);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(33, 15);
            lblPlan.TabIndex = 6;
            lblPlan.Text = "Plan:";
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación ", "Funcional", "Natación" });
            cboPlan.Location = new Point(79, 34);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(100, 23);
            cboPlan.TabIndex = 5;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(13, 54);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 12;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(13, 79);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 13;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(70, 25);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(100, 23);
            cboCuotas.TabIndex = 14;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(13, 28);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(47, 15);
            lblCuotas.TabIndex = 15;
            lblCuotas.Text = "Cuotas:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(11, 116);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 16;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(115, 116);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // grpDatosPersonales
            // 
            grpDatosPersonales.Controls.Add(chkEstudiante);
            grpDatosPersonales.Controls.Add(txtEdad);
            grpDatosPersonales.Controls.Add(txtNombre);
            grpDatosPersonales.Controls.Add(lblEdad);
            grpDatosPersonales.Controls.Add(lblNombre);
            grpDatosPersonales.Location = new Point(6, 17);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Size = new Size(201, 120);
            grpDatosPersonales.TabIndex = 1;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "Datos Personales";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(11, 82);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 8;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(68, 53);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(68, 16);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 6;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(11, 56);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 5;
            lblEdad.Text = "Edad:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(11, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // grpFormaDePago
            // 
            grpFormaDePago.Controls.Add(rbtTarjeta);
            grpFormaDePago.Controls.Add(lblCuotas);
            grpFormaDePago.Controls.Add(rbtEfectivo);
            grpFormaDePago.Controls.Add(cboCuotas);
            grpFormaDePago.Location = new Point(6, 6);
            grpFormaDePago.Name = "grpFormaDePago";
            grpFormaDePago.Size = new Size(201, 104);
            grpFormaDePago.TabIndex = 18;
            grpFormaDePago.TabStop = false;
            grpFormaDePago.Text = "Forma de Pago";
            // 
            // tbcGimansio
            // 
            tbcGimansio.Controls.Add(tbpDatos);
            tbcGimansio.Controls.Add(tbpPlan);
            tbcGimansio.Controls.Add(tbpPago);
            tbcGimansio.Location = new Point(4, 3);
            tbcGimansio.Name = "tbcGimansio";
            tbcGimansio.SelectedIndex = 0;
            tbcGimansio.Size = new Size(257, 238);
            tbcGimansio.TabIndex = 0;
            // 
            // tbpDatos
            // 
            tbpDatos.Controls.Add(grpDatosPersonales);
            tbpDatos.Location = new Point(4, 24);
            tbpDatos.Name = "tbpDatos";
            tbpDatos.Padding = new Padding(3);
            tbpDatos.Size = new Size(249, 210);
            tbpDatos.TabIndex = 0;
            tbpDatos.Text = "Datos";
            tbpDatos.UseVisualStyleBackColor = true;
            // 
            // tbpPlan
            // 
            tbpPlan.Controls.Add(grpPlan);
            tbpPlan.Location = new Point(4, 24);
            tbpPlan.Name = "tbpPlan";
            tbpPlan.Padding = new Padding(3);
            tbpPlan.Size = new Size(249, 210);
            tbpPlan.TabIndex = 1;
            tbpPlan.Text = "Plan";
            tbpPlan.UseVisualStyleBackColor = true;
            // 
            // tbpPago
            // 
            tbpPago.Controls.Add(grpFormaDePago);
            tbpPago.Controls.Add(btnLimpiar);
            tbpPago.Controls.Add(btnCalcular);
            tbpPago.Location = new Point(4, 24);
            tbpPago.Name = "tbpPago";
            tbpPago.Padding = new Padding(3);
            tbpPago.Size = new Size(249, 210);
            tbpPago.TabIndex = 2;
            tbpPago.Text = "Pago";
            tbpPago.UseVisualStyleBackColor = true;
            // 
            // frmInscripcion
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 244);
            Controls.Add(tbcGimansio);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción";
            Load += this.frmInscripcion_Load;
            grpPlan.ResumeLayout(false);
            grpPlan.PerformLayout();
            grpDatosPersonales.ResumeLayout(false);
            grpDatosPersonales.PerformLayout();
            grpFormaDePago.ResumeLayout(false);
            grpFormaDePago.PerformLayout();
            tbcGimansio.ResumeLayout(false);
            tbpDatos.ResumeLayout(false);
            tbpPlan.ResumeLayout(false);
            tbpPago.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPlan;
        private TextBox txtMeses;
        private Label lblMeses;
        private ComboBox cboTurno;
        private Label lblTurno;
        private Label lblPlan;
        private ComboBox cboPlan;
        private Label lblCuotas;
        private ComboBox cboCuotas;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private CheckBox chkCasillero;
        private Button btnLimpiar;
        private Button btnCalcular;
        private GroupBox grpDatosPersonales;
        private CheckBox chkEstudiante;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label lblEdad;
        private Label lblNombre;
        private GroupBox grpFormaDePago;
        private TabControl tbcGimansio;
        private TabPage tbpDatos;
        private TabPage tbpPlan;
        private TabPage tbpPago;
    }
}
