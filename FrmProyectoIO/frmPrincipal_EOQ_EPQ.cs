using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Guna.UI2.Native.WinApi;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FrmProyectoIO
{
    public partial class frmPrincipal_EOQ_EPQ : Form
    {
        public frmPrincipal_EOQ_EPQ()
        {
            InitializeComponent();
        }
        /*
         * NOMBRE DEL DATA GRID VIEW: dgvEjercicios
         * NOMBRE DEL ENUNCIADO: txtEnunciado
         */
        public Almacenamiento principal { get; set; } = new Almacenamiento();
        List<Inventario> ejercicios = new List<Inventario>();
        private void frmPrincipal_EOQ_EPQ_Load(object sender, EventArgs e)
        {
            principal.Leer();

            cmbNivelDificultad.DataSource = Enum.GetValues(typeof(Dificultad));

            dgvEjercicios.AutoGenerateColumns = false;
            rdbEOQ.Checked = true;
            principal.AlCambiar += RefrescarGrid;
            RefrescarGrid();


        }
        private void cmbNivelDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefrescarGrid();
        }

        private void RefrescarGrid()
        {
            dgvEjercicios.DataSource = null;

            var dificultad = (Dificultad)cmbNivelDificultad.SelectedItem;

            if (!principal.Ejercicios.ContainsKey(dificultad))
                return;

            if (rdbEOQ.Checked)
            {
                dgvEjercicios.DataSource = principal.Ejercicios[dificultad]
                    .Where(e => e.Tipo == TipoEjercicio.EOQ)
                    .ToList();

            }
            else if (rdbEPQ.Checked)
            {
                dgvEjercicios.DataSource = principal.Ejercicios[dificultad]
                    .Where(e => e.Tipo == TipoEjercicio.EPQ)
                    .ToList();

            }
        }
        private void dgvEjercicios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEjercicios.CurrentRow == null)
                return;

            if (dgvEjercicios.CurrentRow.DataBoundItem is not Inventario ej)
                return;

            txtTitulo.Text = ej.Titulo;
            txtEnunciado.Text = ej.Texto;
        }
        private void dgvEjercicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvEjercicios.Rows[e.RowIndex].DataBoundItem is Inventario ej)
            {
                txtTitulo.Text = ej.Titulo;
                txtEnunciado.Text = ej.Texto;
            }
        }

        private void frmPrincipal_EOQ_EPQ_FormClosing(object sender, FormClosingEventArgs e)
        {
            principal.AlCambiar -= RefrescarGrid;
            principal.Guardar();
        }



        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ESTE BOTON NO EXISTE ↓↓
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgvEjercicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        // BOTON DE FORMULARIO ( LIMPIAR ), TRABAJAR AQUI: ↓↓↓
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEnunciado.Clear();
            txtTitulo.Clear();
        }

        private void btnGenerarExamen_Click(object sender, EventArgs e)
        {

        }

        // BOTON DE FORMULARIO (ELIMINAR), TRABAJAR AQUI: ↓↓↓
        private void button_Click(object sender, EventArgs e)
        {
            if (dgvEjercicios.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un ejercicio primero");
                return;
            }

            if (dgvEjercicios.CurrentRow.DataBoundItem is not Inventario ej)
                return;

            var dificultad = (Dificultad)cmbNivelDificultad.SelectedItem;

            principal.Ejercicios[dificultad].Remove(ej);

            principal.Guardar();

            RefrescarGrid();

            txtTitulo.Clear();
            txtEnunciado.Clear();
        }




        // BOTON DE FORMULARIO (GENERAR EXAMEN), TRABAJAR AQUI: ↓↓↓
        private void btnGenerarExamen_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmGenerarExamen FrmExam = new();
                FrmExam.Rprincipal = principal;
                FrmExam.ShowDialog();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // BOTON DE FORMULARIO (AGREGAR), TRABAJAR AQUI: ↓↓↓
        private void btnAgregarEjercicio_Click(object sender, EventArgs e)
        {
            var dificultadActual = (Dificultad)cmbNivelDificultad.SelectedItem;

            if (rdbEOQ.Checked)
            {
                frmAgregar_EOQ registrarEOQ = new frmAgregar_EOQ();
                registrarEOQ.referenciaAlmacenamiento = principal;
                registrarEOQ.DificultadSeleccionada = dificultadActual;
                registrarEOQ.ShowDialog();

            }
            else if (rdbEPQ.Checked)
            {
                frmAgregar_EPQ registrarEPQ = new frmAgregar_EPQ();
                registrarEPQ.referenciaAlmacenamiento = principal;
                registrarEPQ.DificultadSeleccionada = dificultadActual;
                registrarEPQ.ShowDialog();

            }
        }
        // BOTON DE FORMULARIO (AÑADIR A IMPRESION), TRABAJAR AQUI: ↓↓↓
        private void btnAñadirImpresion_Click(object sender, EventArgs e)
        {
            foreach (var inv in principal.Ejercicios)
            {
                foreach (var ej in inv.Value)
                {

                    if (ej.Titulo == txtTitulo.Text)
                    {

                        if (ejercicios.Contains(ej))
                        {
                            MessageBox.Show("Ese ejercicio ya se encuentra registrado...", "Duplicado en la seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            ejercicios.Add(ej);
                        }
                        return;
                    }
                }
            }
        }
        // BOTON DE FORMULARIO (IMPRIMIR EJERCICIOS), TRABAJAR AQUI: ↓↓↓
        private void btnImprimirEjercicios_Click(object sender, EventArgs e)
        {
            if (ejercicios.Count == 0)
            {
                MessageBox.Show("No hay ejercicios para imprimir");
                return;
            }
            SaveFileDialog Guardar = new();
            string Nombre = DateTime.Now.ToString("yyyy-MM-dd_HH-mm");
            Guardar.Filter = "PDF (.pdf)|.pdf";
            Guardar.FileName = Nombre;
            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                principal.CrearPdf(Guardar.FileName, ejercicios);
                MessageBox.Show("PDF creado correctamente");
                ejercicios = new();
            }
        }

        private void rdbEOQ_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarGrid();
        }

        private void rdbEPQ_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarGrid();
        }
    }
}