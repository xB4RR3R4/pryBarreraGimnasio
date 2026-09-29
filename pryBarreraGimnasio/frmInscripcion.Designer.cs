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
            groupBox1 = new GroupBox();
            cboPlan = new ComboBox();
            lblPlan = new Label();
            lblTurno = new Label();
            cboTurno = new ComboBox();
            lblMeses = new Label();
            textBox1 = new TextBox();
            chkCasillero = new CheckBox();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            groupBox2 = new GroupBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            lblNombre = new Label();
            chkEstudiante = new CheckBox();
            groupBox3 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkCasillero);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lblMeses);
            groupBox1.Controls.Add(cboTurno);
            groupBox1.Controls.Add(lblTurno);
            groupBox1.Controls.Add(lblPlan);
            groupBox1.Controls.Add(cboPlan);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(198, 160);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Location = new Point(79, 34);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(100, 23);
            cboPlan.TabIndex = 5;
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
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(22, 72);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(42, 15);
            lblTurno.TabIndex = 7;
            lblTurno.Text = "Turno:";
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Location = new Point(79, 69);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(100, 23);
            cboTurno.TabIndex = 8;
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
            // textBox1
            // 
            textBox1.Location = new Point(78, 103);
            textBox1.MaxLength = 2;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
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
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(70, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 28);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 15;
            label1.Text = "Cuotas:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(13, 418);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 16;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(139, 418);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkEstudiante);
            groupBox2.Controls.Add(txtEdad);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(lblEdad);
            groupBox2.Controls.Add(lblNombre);
            groupBox2.Location = new Point(6, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(201, 120);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
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
            // groupBox3
            // 
            groupBox3.Controls.Add(rbtTarjeta);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(rbtEfectivo);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(201, 104);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(13, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(257, 238);
            tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(249, 210);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(249, 210);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(249, 210);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label lblMeses;
        private ComboBox cboTurno;
        private Label lblTurno;
        private Label lblPlan;
        private ComboBox cboPlan;
        private Label label1;
        private ComboBox comboBox1;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private CheckBox chkCasillero;
        private Button btnLimpiar;
        private Button btnCalcular;
        private GroupBox groupBox2;
        private CheckBox chkEstudiante;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label lblEdad;
        private Label lblNombre;
        private GroupBox groupBox3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
    }
}
