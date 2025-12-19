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
        public Problemario referenciaAgregar { get; set; } = new Problemario();

        private void FrmModeloServidorUnaSolaFila_Load(object sender, EventArgs e)
        {
            cmbNivelDificultad.DataSource = Enum.GetValues(typeof(FrmProyectoIO.Properties.Dificultad));
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                referenciaAgregar.AgregarProblema(txtTitulo.Text, txtEnunciado.Text, double.Parse(txtLambda.Text),
                    double.Parse(txtMew.Text), (Properties.Dificultad)cmbNivelDificultad.SelectedItem);
               
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
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
            ModeloUnSoloServidor modeloUnaFila = new()
            {
                TasaLlegada = double.Parse(txtLambda.Text),
                TasaServicio = double.Parse(txtMew.Text),
            };

            txtP.Text = modeloUnaFila.UtilizacionPromedioSistema.ToString();// P
            txtPn.Text = modeloUnaFila.ProbabilidadClientesSistema.ToString(); //P(n)
            txtLs.Text = modeloUnaFila.NumeroPromedioEnServicio.ToString(); //LS
            txtWs.Text = modeloUnaFila.TiempoPromedioEnServicio.ToString();//Ws
            txtWq.Text = modeloUnaFila.TiempoPromedioEnFila.ToString(); //Wq
            txtLq.Text = modeloUnaFila.NumeroPromedioEnFila.ToString(); //Lq
        }
    }
}
