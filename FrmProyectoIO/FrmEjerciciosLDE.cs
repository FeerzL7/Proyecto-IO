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
    public partial class FrmEjerciciosLDE : Form
    {
        public FrmEjerciciosLDE()
        {
            InitializeComponent();
        }

        public Problemario problema = new();
        private void FrmEjerciciosLDE_Load(object sender, EventArgs e)
        {
            dgvEjercicios.AutoGenerateColumns = false;
            problema.SeActualizoLista += Problema_SeActualizoLista1;
            problema.CargarDatos();
            dgvEjercicios.DataSource = problema.Reactivo.SelectMany(x => x.Value).ToList();


        }

        private void Problema_SeActualizoLista1()
        {

            dgvEjercicios.DataSource = null;
            dgvEjercicios.DataSource = problema.Reactivo.SelectMany(x => x.Value).ToList();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {


            if (tscmbModelo.Text == "UNA")
            {
                FrmModeloServidorUnaSolaFila modelo1 = new();
                modelo1.referenciaAgregar = problema;
                modelo1.ShowDialog();
            }
            else if (tscmbModelo.Text == "MUCHAS")
            {
                FrmRegistrarMultiplesServidoresUnaFila modelo2 = new();
                modelo2.referenciaRegistarMultiples = problema;
                modelo2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione uno de los 2");

            }
        }

        private void FrmEjerciciosLDE_FormClosed(object sender, FormClosedEventArgs e)
        {
            problema.GuardarDatos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnConsultas_Click(object sender, EventArgs e)
        {
            var listaEjercicios = problema.Reactivo.SelectMany(x => x.Value);

            string titulo = txtTitulo.Text.Trim().ToUpper();
            string enunciado = txtEnunciado.Text.Trim().ToUpper();

            if (titulo != "")
            {
                listaEjercicios = listaEjercicios.Where(p => p.Titulo.ToUpper().Contains(titulo));
            }
            if (enunciado != "")
            {
                listaEjercicios = listaEjercicios.Where(p => p.Enunciado.ToUpper().Contains(enunciado));
            }

            dgvEjercicios.DataSource = null;
            dgvEjercicios.DataSource = listaEjercicios.ToList();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEjercicios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un problema");
                return;
            }

            var ejercicioSeleccionado = (ModeloUnSoloServidor)dgvEjercicios.CurrentRow.DataBoundItem;

            if (ejercicioSeleccionado == null)
                return;

            var confirmar = MessageBox.Show("¿Deseas eliminar este ejercicio?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                problema.Eliminar(ejercicioSeleccionado);
            }
        }

        private void dgvEjercicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvEjercicios.SelectedRows.Count == 1)
            {
                if (dgvEjercicios.Columns[e.ColumnIndex].HeaderText == "Ver mas")
                {
                    var ejercicioSeleccionado = (ModeloUnSoloServidor)dgvEjercicios.CurrentRow.DataBoundItem;
                    FrmVerEjercicioModeloServidorUnaSolaFila verEjercicio = new();
                    verEjercicio.ModeloVer = ejercicioSeleccionado;
                    verEjercicio.ShowDialog();
                }
            }
        }

        private void dgvEjercicios_DoubleClick(object sender, EventArgs e)
        {
            //Agarrar el objeto seleccionado al hacer doble click
            var ejercicioSeleccionado = (ModeloUnSoloServidor)dgvEjercicios.CurrentRow.DataBoundItem;
            FrmModificarModeloServidorUnaSolaFila modificarEjercicio = new();
            modificarEjercicio.ReferenciaModificar = problema;
            modificarEjercicio.ModeloMM1Anterior = ejercicioSeleccionado;
            modificarEjercicio.ShowDialog();
        }
    }
}
