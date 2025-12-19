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

        public Problemario problema { get; set; } = new();
        private void FrmEjerciciosLDE_Load(object sender, EventArgs e)
        {
            dgvEjercicios.AutoGenerateColumns = false;
            problema.SeActualizoLista += Problema_SeActualizoLista1;
            problema.CargarDatos();
            dgvEjercicios.DataSource = problema.ReactivosMM1.SelectMany(x => x.Value).ToList();


        }

        private void Problema_SeActualizoLista1()
        {
            dgvEjercicios.DataSource = null;
            if (tscmbModelo.Text == "MUCHAS")
            {

                dgvEjercicios.DataSource = problema.ReactivosMMS.SelectMany(x => x.Value).ToList();
                // Primero, limpiar los items existentes
                tscmbDificultad.Items.Clear();
                // Agregar las keys del diccionario como objetos (convertir a array, porque solo acepta arrays la sobrecarga de AddRange) 
                tscmbDificultad.Items.AddRange(problema.ReactivosMMS.Keys.Cast<object>().ToArray());
            }


            dgvEjercicios.DataSource = problema.ReactivosMM1.SelectMany(x => x.Value).ToList();

            tscmbDificultad.Items.Clear();
            tscmbDificultad.Items.AddRange(problema.ReactivosMM1.Keys.Cast<object>().ToArray());
            if (tscmbDificultad.Items.Count >= 1) {
                tscmbDificultad.SelectedIndex = 0; 
            }
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
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
                    MessageBox.Show("Seleccione 1 de los 2 modelos matematicos", "Advertencia", MessageBoxButtons.OK);

                }

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
            var listaEjercicios = problema.ReactivosMM1.SelectMany(x => x.Value);

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
            if (tscmbModelo.Text == "MUCHAS")
            {
               
                ModeloMultiplesServidores? ejercicioSeleccionado = dgvEjercicios.CurrentRow.DataBoundItem as ModeloMultiplesServidores;
                if (ejercicioSeleccionado == null)
                    return;
                var confirmar = MessageBox.Show("¿Deseas eliminar este ejercicio?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar == DialogResult.Yes)
                {
                    problema.Eliminar(ejercicioSeleccionado);
                }
                return;
            }
            else if (tscmbModelo.Text == "UNA")
            {
                var ejercicioSeleccionado = (ModeloUnSoloServidor)dgvEjercicios.CurrentRow.DataBoundItem;

                if (ejercicioSeleccionado == null)
                    return;

                var confirmar = MessageBox.Show("¿Deseas eliminar este ejercicio?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmar == DialogResult.Yes)
                {
                    problema.Eliminar(ejercicioSeleccionado);
                }
            }
        }

        private void dgvEjercicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvEjercicios.SelectedRows.Count == 1)
            {
                if (dgvEjercicios.Columns[e.ColumnIndex].HeaderText == "Ver más")
                {
                    if (tscmbModelo.Text == "MUCHAS")
                    {
                        ModeloMultiplesServidores? ejercicioSeleccionado = dgvEjercicios.CurrentRow.DataBoundItem as ModeloMultiplesServidores;
                        FrmVerEjercicioModeloMultiplesServidoresUnaSolaFila verEjercicio = new();
                        verEjercicio.ModeloMMSVer = ejercicioSeleccionado;
                        verEjercicio.ShowDialog();

                    }
                    else
                    {
                        var ejercicioSeleccionado = (ModeloUnSoloServidor)dgvEjercicios.CurrentRow.DataBoundItem;
                        FrmVerEjercicioModeloServidorUnaSolaFila verEjercicio = new();
                        verEjercicio.ModeloVer = ejercicioSeleccionado;
                        verEjercicio.ShowDialog();
                    }
                }
            }
        }

        private void dgvEjercicios_DoubleClick(object sender, EventArgs e)
        {
            if(tscmbModelo.Text == "MUCHAS")
            {
                ModeloMultiplesServidores? ejercicioSeleccionado = dgvEjercicios.CurrentRow.DataBoundItem as ModeloMultiplesServidores;
                FrmVerEjercicioModeloMultiplesServidoresUnaSolaFila verEjercicio = new();
                verEjercicio.ModeloMMSVer = ejercicioSeleccionado;
                verEjercicio.ShowDialog();
            }
            else
            {
                var ejercicioSeleccionado = (ModeloUnSoloServidor)dgvEjercicios.CurrentRow.DataBoundItem;
                FrmVerEjercicioModeloServidorUnaSolaFila verEjercicio = new();
                verEjercicio.ModeloVer = ejercicioSeleccionado;
                verEjercicio.ShowDialog();
            }
        }

        private void tsmiModelo_Click(object sender, EventArgs e)
        {

        }

        private void tscmbModelo_Click(object sender, EventArgs e)
        {

        }

        private void tscmbModelo_TextChanged(object sender, EventArgs e)
        {

            if (tscmbModelo.Text == "UNA")
            {
                dgvEjercicios.DataSource = problema.ReactivosMM1.SelectMany(x => x.Value).ToList();
            }
            else if (tscmbModelo.Text == "MUCHAS")
            {
                dgvEjercicios.DataSource = problema.ReactivosMMS.SelectMany(x => x.Value).ToList();
            }


        }

        private void tsmiDificultad_Click(object sender, EventArgs e)
        {

        }

        private void tscmbDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscmbDificultad.SelectedItem != null)
            {

                if (tscmbModelo.Text == "UNA")
                {
                    dgvEjercicios.DataSource = null;
                    dgvEjercicios.DataSource = problema.GetReactivosMM1ByDificultad((Properties.Dificultad)tscmbDificultad.SelectedItem);
                }
                else if (tscmbModelo.Text == "MUCHAS")
                {
                    dgvEjercicios.DataSource = null;
                    dgvEjercicios.DataSource = problema.GetReactivosMMSByDificultad((Properties.Dificultad)tscmbDificultad.SelectedItem);

                }
            }
        }
    }
}
