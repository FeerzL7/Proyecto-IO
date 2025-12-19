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
    public partial class FrmVerEjercicioModeloMultiplesServidoresUnaSolaFila : Form
    {
       
        public ModeloMultiplesServidores ModeloMMSVer { get; set; } = new ModeloMultiplesServidores();
        public FrmVerEjercicioModeloMultiplesServidoresUnaSolaFila()
        {
            InitializeComponent();
        }

        private void FrmVerEjercicioModeloMultiplesServidoresUnaSolaFila_Load(object sender, EventArgs e)
        {
            txtMew.Text = ModeloMMSVer.TasaServicio.ToString();
            txtLambda.Text = ModeloMMSVer.TasaLlegada.ToString();
            txtM.Text = ModeloMMSVer.Servidores.ToString();
            
            txtTitulo.Text = ModeloMMSVer.Titulo;
            txtEnunciado.Text = ModeloMMSVer.Enunciado;

            string dificultad = ModeloMMSVer.NivelDificultad == Properties.Dificultad.Dificil ? "Dificil" : ModeloMMSVer.NivelDificultad == Properties.Dificultad.Medio ? "Medio" : "Facil";
            txtNivelDeDificultad.Text = dificultad;

            //Los procesos matematicos
            txtPo.Text = ModeloMMSVer.ProbabilidadSistemaVacio().ToString();
            txtLs.Text = ModeloMMSVer.NumeroPromedioEnServicio.ToString();
            txtWs.Text = ModeloMMSVer.TiempoPromedioEnServicio.ToString();
            txtLq.Text = ModeloMMSVer.NumeroPromedioEnFila.ToString();
            txtWq.Text = ModeloMMSVer.TiempoPromedioEnFila.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
