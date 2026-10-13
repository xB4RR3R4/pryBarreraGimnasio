using static pryBarreraGimnasio.frmInscripcion;

namespace pryBarreraGimnasio
{

    public partial class frmInscripcion : Form
    {
        string[] arrayClientes = new string[3];
        int indiceClientes = 0;
        public struct SOCIO
        {
            public string nombre;
            public int edad;
            public int meses;
            public decimal precioMensual;
            public decimal subtotal;
            public decimal porcentajeDescuento;
            public decimal porcentajeAjuste;
            public decimal total;
            public decimal valorCuota;
            
        }
        SOCIO sOCIO; 

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
            
            sOCIO.nombre = txtNombre.Text;
            sOCIO.edad = int.Parse(txtEdad.Text);
            sOCIO.meses = int.Parse(txtMeses.Text);
            sOCIO.precioMensual = cboPlan.SelectedIndex switch
            {
                0 => PRECIO_NATACION,
                1 => PRECIO_GIMNASIO,
                2 => PRECIO_FUNCIONAL,
                _ => 0m
            };
            sOCIO.subtotal = sOCIO.precioMensual * sOCIO.meses;



            #region calculo de precio mensual segun plan
            if (chkCasillero.Checked)
            {
                sOCIO.subtotal += PRECIO_CASILLERO * sOCIO.meses;
            }
            sOCIO.total = sOCIO.subtotal;

            if (rbtTarjeta.Checked && cboCuotas.SelectedIndex != -1)
            {
                decimal porcentajeAjuste = sOCIO.subtotal * (PORCENTAJE_RECARGO / 100m);
                sOCIO.total += porcentajeAjuste;
            }
            if (cboCuotas.Enabled && cboCuotas.SelectedIndex != -1)
            {
                int cuotas = int.Parse(cboCuotas.SelectedItem.ToString());
                sOCIO.valorCuota = sOCIO.total / cuotas;
            }
            #endregion
            #region validacion edad y mes
            if (sOCIO.edad < EDAD_MINIMA)
            {
                MessageBox.Show($"El cliente {sOCIO.nombre} no cumple con la edad mínima de {EDAD_MINIMA} años para inscribirse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EstadoInicial();
                return;
            }
            if (sOCIO.meses >= 12)
            {
                MessageBox.Show($"El cliente {sOCIO.nombre} no puede inscribirse por más de 12 meses.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EstadoInicial();
                return;
            }
            #endregion
            #region turno seleccionado
            string horarioSeleccionado = cboTurno.SelectedItem.ToString();
            switch (horarioSeleccionado)
            {
                case "Mañana":
                    horarioSeleccionado = "Mañana";
                    break;
                case "Tarde":
                    horarioSeleccionado = "Tarde";
                    break;
                case "Noche":
                    horarioSeleccionado = "Noche";
                    break;

            }
            #endregion
            #region descuento por edad y estudiante
            sOCIO.total = sOCIO.subtotal;
            if (sOCIO.edad < 18)
            {
                sOCIO.porcentajeDescuento = sOCIO.subtotal * 0.25m;
                sOCIO.total -= sOCIO.porcentajeDescuento;
            }
            else
            {
                if (sOCIO.edad >= 65)
                {
                    sOCIO.porcentajeDescuento = sOCIO.subtotal * 0.30m;
                    sOCIO.total -= sOCIO.porcentajeDescuento;
                }
                else
                {
                    if (chkEstudiante.Checked)
                    {
                        sOCIO.porcentajeDescuento = sOCIO.subtotal * 0.15m;
                        sOCIO.total -= sOCIO.porcentajeDescuento;
                    }
                    else
                    {
                        sOCIO.porcentajeDescuento = 0;
                    }
                }
            }
            #endregion

            MessageBox.Show($"Resumen de inscripcion\n" +
                    $"Cliente: {sOCIO.nombre}\n" +
                    $"Edad: {sOCIO.edad}\n" +
                    $"Meses: {sOCIO.meses}\n" +
                    $"Subtotal: ${sOCIO.subtotal}\n" +
                    $"Descuento aplicado: ${sOCIO.porcentajeDescuento}\n" +
                    $"Total a pagar: ${sOCIO.total}",
                    "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            arrayClientes[indiceClientes] = $"Cliente: {sOCIO.nombre}, Edad: {sOCIO.edad}, Meses: {sOCIO.meses}, Subtotal: ${sOCIO.subtotal}, Descuento aplicado: ${sOCIO.porcentajeDescuento}, Total a pagar: ${sOCIO.total}";
            indiceClientes++;

            EstadoInicial();
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

        private void btnConsultar_Click(object sender, EventArgs e)          
        {
            
            ltsConsulta.Items.Clear();

            
            ltsConsulta.Items.Add("Resumen de inscripción");
            ltsConsulta.Items.Add($"Cliente: {sOCIO.nombre}");
            ltsConsulta.Items.Add($"Edad: {sOCIO.edad}");
            ltsConsulta.Items.Add($"Meses: {sOCIO.meses}");
            ltsConsulta.Items.Add($"Subtotal: ${sOCIO.subtotal}");
            ltsConsulta.Items.Add($"Descuento aplicado: ${sOCIO.porcentajeDescuento}");
            ltsConsulta.Items.Add($"Total a pagar: ${sOCIO.total}");
        }
    }
}

