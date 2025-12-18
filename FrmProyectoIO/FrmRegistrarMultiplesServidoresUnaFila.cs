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
    public partial class FrmRegistrarMultiplesServidoresUnaFila : Form
    {
        public FrmRegistrarMultiplesServidoresUnaFila()
        {
            InitializeComponent();
        }
        public Problemario referenciaRegistarMultiples = new();


        private void FrmRegistrarMultiplesServidoresUnaFila_Load(object sender, EventArgs e)
        {
            cmbNivelDificultad.DataSource = Enum.GetValues(typeof(FrmProyectoIO.Properties.Dificultad));
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                referenciaRegistarMultiples.AgregarProblema(txtTitulo.Text, txtEnunciado.Text,
                    double.Parse(txtLambda.Text), double.Parse(txtMew.Text), int.Parse(txtM.Text), (FrmProyectoIO.Properties.Dificultad)cmbNivelDificultad.SelectedItem);
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            ModeloMultiplesServidores modeloServidores = new()
            {
                TasaLlegada = double.Parse(txtLambda.Text),
                TasaServicio = double.Parse(txtMew.Text),
                Servidores = int.Parse(txtM.Text)
            };

            txtPo.Text = modeloServidores.ProbabilidadSistemaVacio().ToString();
            txtLs.Text = modeloServidores.NumeroPromedioEnServicio.ToString();
            txtWs.Text = modeloServidores.TiempoPromedioEnServicio.ToString();
            txtWq.Text = modeloServidores.TiempoPromedioEnFila.ToString();
            txtLq.Text = modeloServidores.NumeroPromedioEnFila.ToString();
        }
    }
}
