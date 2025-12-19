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
    public partial class FrmVerEjercicioModeloServidorUnaSolaFila : Form
    {
        
        public FrmVerEjercicioModeloServidorUnaSolaFila()
        {
            InitializeComponent();
        }
        public ModeloUnSoloServidor ModeloVer { get; set; } = new ModeloUnSoloServidor();
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVerEjercicioModeloUnaSolaFiala_Load(object sender, EventArgs e)
        {
            txtTitulo.Text = ModeloVer.Titulo;
            txtEnunciado.Text = ModeloVer.Enunciado;
            txtMew.Text = ModeloVer.TasaServicio.ToString();
            txtLambda.Text = ModeloVer.TasaLlegada.ToString();

            string dificultad = ModeloVer.NivelDificultad == Properties.Dificultad.Dificil ? "Dificil" : ModeloVer.NivelDificultad == Properties.Dificultad.Medio ? "Medio" : "Facil";
            txtNivelDeDificultad.Text = dificultad;

            //Procesos matematicos
            txtP.Text = ModeloVer.UtilizacionPromedioSistema.ToString();// P
            txtPn.Text = ModeloVer.ProbabilidadClientesSistema.ToString(); //P(n)
            txtLs.Text = ModeloVer.NumeroPromedioEnServicio.ToString(); //LS
            txtWs.Text = ModeloVer.TiempoPromedioEnServicio.ToString();//Ws
            txtWq.Text = ModeloVer.TiempoPromedioEnFila.ToString(); //Wq
            txtLq.Text = ModeloVer.NumeroPromedioEnFila.ToString(); //Lq
        }
    }
}
