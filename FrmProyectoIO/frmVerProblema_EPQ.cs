using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmProyectoIO
{
    public partial class frmVerProblema_EPQ : Form
    {

      

        public frmVerProblema_EPQ()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void frmVerProblema_EPQ_Load(object sender, EventArgs e)
        {

        }

    
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
    

               

            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message, "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
