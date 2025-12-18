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
    public partial class FrmModificarModeloMultiplesServidoresUnaSolaFila : Form
    {
        public FrmModificarModeloMultiplesServidoresUnaSolaFila()
        {
            InitializeComponent();
        }
        public Problemario ReferenciaModificar { get; set; } = new Problemario();
        public ModeloMultiplesServidores ModeloMMSAnterior { get; set; } = new ModeloMultiplesServidores();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ModeloMultiplesServidores modelo = new ModeloMultiplesServidores()
            {
                TasaLlegada = double.Parse(txtLambda.Text),
                TasaServicio = double.Parse(txtMew.Text),
                Titulo = txtTitulo.Text,
                Enunciado = txtEnunciado.Text,
                Servidores = int.Parse(txtM.Text)
            };

            ReferenciaModificar.ModificarProblema(modelo, (FrmProyectoIO.Properties.Dificultad)cmbNivelDificultad.SelectedItem);
            //Eliminar el problema antiguo por si cambio su nivel de dificultad
            var elim = ReferenciaModificar.Reactivo.SelectMany(x => x.Value).Where(x => x.Titulo == modelo.Titulo).First();
            ReferenciaModificar.Eliminar(elim);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Actualizar los datos del modelo, para lq, ws, etc...
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

        private void FrmModificarModeloMultiplesServidoresUnaSolaFila_Load(object sender, EventArgs e)
        {
            cmbNivelDificultad.DataSource = Enum.GetValues(typeof(FrmProyectoIO.Properties.Dificultad));
            if (ModeloMMSAnterior != null)
            {
                //Cargar los datos 
                //Datos generales (Texto)
                txtEnunciado.Text = ModeloMMSAnterior.Enunciado;
                txtTitulo.Text = ModeloMMSAnterior.Titulo;
                cmbNivelDificultad.SelectedItem = ModeloMMSAnterior.NivelDificultad;

                //Datos del problemario
                txtMew.Text = ModeloMMSAnterior.TasaServicio.ToString();
                txtLambda.Text = ModeloMMSAnterior.TasaLlegada.ToString();
                txtM.Text = ModeloMMSAnterior.Servidores.ToString();


            }
        }
    }
}
