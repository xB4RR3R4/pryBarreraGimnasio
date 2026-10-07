namespace pryBarreraGimnasio
{

    public partial class frmInscripcion : Form
    {
        private void ActivarBotonCalcularFormulario()
        {
            if (txtNombre.Text != "" && txtEdad.Text != "" && txtMeses.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }

        }
        private void EstadoInicial()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtMeses.Text = "1";
            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;
            txtNombre.Focus();
        }

        #region declaracion de constante
        public const decimal PRECIO_NATACION = 1000m;
        public const decimal PRECIO_GIMNASIO = 1500m;
        public const decimal PRECIO_FUNCIONAL = 1800m;
        public const decimal PRECIO_CASILLERO = 3000m;
        public const int EDAD_MINIMA = 18;
        public const decimal PORCENTAJE_RECARGO = 20m;
        
        #endregion

        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            int ascii = (int)e.KeyChar;

            if ((ascii < 48 || ascii > 57) && ascii != 8)
            {
                e.Handled = true;
            }
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial();
            ActivarBotonCalcularFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            cboCuotas.Enabled = rbtTarjeta.Checked;
            if (!rbtTarjeta.Checked)
                cboCuotas.SelectedIndex = -1;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            #region declaracion de variables
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);
            decimal precioMensual = PRECIO_NATACION;
            decimal subtotal = 0;
            decimal porcentajeDescuento = 0;
            decimal porcentajeAjuste = 0;
            decimal total = 0;
            decimal valorCuota = 0;
            subtotal = precioMensual * meses;
            #endregion
            #region calculo de precio mensual segun plan
            if (chkCasillero.Checked)
            {
                subtotal += PRECIO_CASILLERO * meses;
            }
            total = subtotal;

            if (rbtTarjeta.Checked && cboCuotas.SelectedIndex != -1)
            {
                porcentajeAjuste = subtotal * (PORCENTAJE_RECARGO / 100m);
                total += porcentajeAjuste;
            }
            if (cboCuotas.Enabled && cboCuotas.SelectedIndex != -1)
            {
                int cuotas = int.Parse(cboCuotas.SelectedItem.ToString());
                valorCuota = total / cuotas;
            }
            #endregion
            #region validacion edad y mes
            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show($"El cliente {nombre} no cumple con la edad mínima de {EDAD_MINIMA} años para inscribirse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EstadoInicial();
                return;
            }
            if (meses >= 12)
            {
                MessageBox.Show($"El cliente {nombre} no puede inscribirse por más de 12 meses.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EstadoInicial();
                return;
            }
            #endregion
            #region plan seleccionado
            string planSeleccionado = cboPlan.SelectedItem.ToString();
            switch (planSeleccionado)
            {
                case "Natación":
                    precioMensual = PRECIO_NATACION;
                    break;
                case "Gimnasio":
                    precioMensual = PRECIO_GIMNASIO;
                    break;
                case "Funcional":
                    precioMensual = PRECIO_FUNCIONAL;
                    break;
                default:
                    MessageBox.Show("Plan inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            #endregion
            #region turno seleccionado
            string horarioSeleccionado = cboTurno.SelectedItem.ToString();
            switch(horarioSeleccionado)
            {
                case 0:
                    horarioSeleccionado = "Mañana";
                    break;
                case 1:
                    horarioSeleccionado = "Tarde";
                    break;
                case 2:
                    horarioSeleccionado = "Noche";
                    break;
                default:
                    MessageBox.Show("Horario inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            #endregion
            #region descuento por edad y estudiante
            if (edad < 18)
            {
                porcentajeDescuento = subtotal * 0.25m;
                total -= porcentajeDescuento;
            }
            else
            {
                if (edad >=65)
                {
                    porcentajeDescuento = subtotal * 0.30m;
                    total -= porcentajeDescuento;
                }
                else
                {
                    if (chkEstudiante.Checked)
                    {
                        porcentajeDescuento = subtotal * 0.15m;
                        total -= porcentajeDescuento;
                    }
                    else
                    {
                        porcentajeDescuento = 0;
                    }
                }
            }
            #endregion

            MessageBox.Show($"Resumen de inscripcion\n" +
                $"Cliente: {nombre}\n" +
                $"Edad: {edad}\n" +
                $"Meses: {meses}\n" +
                $"Subtotal: {subtotal}\n" +
                $"Total a pagar: {total}\n",
                "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ActivarBotonCalcularFormulario();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            ActivarBotonCalcularFormulario();
        }



    }
}

