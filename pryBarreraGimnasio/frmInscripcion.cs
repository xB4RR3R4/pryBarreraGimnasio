namespace pryBarreraGimnasio
{

    public partial class frmInscripcion : Form
    {
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

        #region declaracion de constantes
        public const double PLAN_NATACION = 1500;
        public const decimal PRECIO_NATACION = 1000;
        public const float PRECIO_CASILLERO = 500;

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
        }
    }

}

