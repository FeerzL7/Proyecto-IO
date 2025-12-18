using FrmProyectoIO.Properties;
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
    public partial class FrmModeloServidorUnaSolaFila : Form
    {
        public FrmModeloServidorUnaSolaFila()
        {
            InitializeComponent();
        }
        public Problemario referenciaAgregar = new Problemario();

        private void FrmModeloServidorUnaSolaFila_Load(object sender, EventArgs e)
        {
            cmbNivelDificultad.DataSource = Enum.GetValues(typeof(FrmProyectoIO.Properties.Dificultad));
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                referenciaAgregar.AgregarProblema(txtTitulo.Text, txtEnunciado.Text, double.Parse(txtLambda.Text), 
                    double.Parse(txtMew.Text), (FrmProyectoIO.Properties.Dificultad)cmbNivelDificultad.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
