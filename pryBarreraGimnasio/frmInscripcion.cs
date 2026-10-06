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
        public const float PRECIO_CASILLERO = 500f;
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
        }
    }

}

