using FrmProyectoIO.Properties;

namespace FrmProyectoIO
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        public Problemario problemario = new();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            FrmEjerciciosLDE lineas = new();
            lineas.problema = problemario;
            lineas.ShowDialog();
        }

        private void guna2ImageBtnEOQ_Click(object sender, EventArgs e)
        {
            frmPrincipal_EOQ_EPQ frm = new frmPrincipal_EOQ_EPQ();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
