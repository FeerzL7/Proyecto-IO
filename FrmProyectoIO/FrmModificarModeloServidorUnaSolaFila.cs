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
    public partial class FrmModificarModeloServidorUnaSolaFila : Form
    {
        public FrmModificarModeloServidorUnaSolaFila()
        {
            InitializeComponent();
        }
        public Problemario ReferenciaModicar { get; set; } = new Problemario();
        public ModeloUnSoloServidor ModeloMM1Anterior { get; set; } = new ModeloUnSoloServidor();
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ModeloUnSoloServidor modelo = new ModeloUnSoloServidor
            {
                TasaLlegada = double.Parse(txtLambda.Text),
                TasaServicio = double.Parse(txtMew.Text),
                Titulo = txtTitulo.Text,
                Enunciado = txtEnunciado.Text,
                //NivelDificultad = (FrmProyectoIO.Properties.Dificultad)cmbNivelDificultad.SelectedItem
            };

            ReferenciaModicar.ModificarProblema(modelo, (FrmProyectoIO.Properties.Dificultad)cmbNivelDificultad.SelectedItem);
            //Eliminar el problema antiguo por si cambio su nivel de dificultad
            var elim = ReferenciaModicar.Reactivo.SelectMany(x => x.Value).Where(x => x.Titulo == modelo.Titulo);
            ReferenciaModicar.Eliminar(elim.First());
        }

        private void cmbNivelDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void FrmModificarModeloServidorUnaSolaFila_Load(object sender, EventArgs e)
        {
            cmbNivelDificultad.DataSource = Enum.GetValues(typeof(FrmProyectoIO.Properties.Dificultad));

            //Datos generales (Texto)
            txtTitulo.Text = ModeloMM1Anterior.Titulo;
            txtEnunciado.Text = ModeloMM1Anterior.Enunciado;
            //Datos
            txtLambda.Text = ModeloMM1Anterior.TasaLlegada.ToString();
            txtMew.Text = ModeloMM1Anterior.TasaServicio.ToString();

        }
    }
}
