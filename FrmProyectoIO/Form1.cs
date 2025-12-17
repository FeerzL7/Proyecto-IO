namespace FrmProyectoIO
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void guna2ImageBtnEOQ_Click(object sender, EventArgs e)
        {
            
            frmPrincipal_EOQ_EPQ frm = new frmPrincipal_EOQ_EPQ();
            frm.ShowDialog();
        }
    }
}
