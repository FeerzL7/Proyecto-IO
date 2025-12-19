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
        public Almacenamiento almacenamiento = new();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            try{
                FrmEjerciciosLDE lineas = new();
                lineas.problema = problemario;
                lineas.ShowDialog();
            }
            catch (ArgumentException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2ImageBtnEOQ_Click(object sender, EventArgs e)
        {
            frmPrincipal_EOQ_EPQ alma = new();
            alma.principal = almacenamiento;
            alma.ShowDialog();
        }
    }
}
