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
        public Problemario ReferenciaVer { get; set; } = new Problemario();
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
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
