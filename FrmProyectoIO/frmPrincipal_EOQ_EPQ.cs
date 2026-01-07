using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
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
        public Almacenamiento principal { get; set; } = new Almacenamiento();
        List<Inventario> ejercicios = new List<Inventario>();
        private void CargarEjercicios()
        {
            IEnumerable<Inventario> ejercicios = principal.TodosEjercicios();

            if (rdbEOQ.Checked)
            {
                ejercicios = ejercicios.Where(x => x.Tipo == TipoEjercicio.EOQ);
            }
            if (rdbEPQ.Checked)
            {
                ejercicios = ejercicios.Where(z => z.Tipo == TipoEjercicio.EPQ);
            }

            //if(cmbNivelDificultad.SelectedItem!=null)
            //{
            //    Dificultad difi =(Dificultad) cmbNivelDificultad.SelectedItem;

            //}
            dgvEjercicios.DataSource = ejercicios.ToList();
        }
        private void frmPrincipal_EOQ_EPQ_Load(object sender, EventArgs e)
        {
            principal.Leer();
            cmbNivelDificultad.DataSource = Enum.GetValues(typeof(Dificultad));
            CargarEjercicios();

            //rellena el data great view
            dgvEjercicios.AutoGenerateColumns = false;
            dgvEjercicios.Columns.Clear();

            DataGridViewTextBoxColumn colTitulo = new DataGridViewTextBoxColumn();
            colTitulo.HeaderText = "Titulo";
            colTitulo.DataPropertyName = "Titulo";
            colTitulo.ReadOnly = true;
            dgvEjercicios.Columns.Add(colTitulo);

            DataGridViewLinkColumn columVer = new DataGridViewLinkColumn();
            columVer.HeaderText = "Ver";
            columVer.Text = "Ver Ejercicio";
            columVer.UseColumnTextForLinkValue = true;
            dgvEjercicios.Columns.Add(columVer);
        }

        private void frmPrincipal_EOQ_EPQ_FormClosing(object sender, FormClosingEventArgs e)
        {
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
            if (e.RowIndex < 0) return;
            if (dgvEjercicios.Columns[e.ColumnIndex].Name != "Ver")
            {
                Inventario seleccionado = (Inventario)dgvEjercicios.Rows[e.RowIndex].DataBoundItem;

                if (seleccionado.Tipo==TipoEjercicio.EPQ)
                {
                    frmVerProblema_EPQ frmVerProblema = new();
                    frmVerProblema.Ejercicio = (InventarioProduccion)seleccionado;
                    frmVerProblema.ReferenciaAlmacenamiento = principal;
                    frmVerProblema.ShowDialog();
                }
                else
                {
                    frmVerProblema_EOQ frmVerEOQ = new();
                    frmVerEOQ.Ejercicio = seleccionado;
                    frmVerEOQ.referenciaAlmacenamiento = principal;
                    frmVerEOQ.ShowDialog();
                }
            }
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
            if (rdbEOQ.Checked)
            {
                frmAgregar_EOQ registrarEOQ = new frmAgregar_EOQ();
                registrarEOQ.referenciaAlmacenamiento = principal;
                registrarEOQ.ShowDialog();
            }
            else if (rdbEPQ.Checked)
            {
                frmAgregar_EPQ registrarEPQ = new frmAgregar_EPQ();
                registrarEPQ.referenciaAlmacenamiento = principal;
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
            CargarEjercicios();
        }

        private void rdbEPQ_CheckedChanged(object sender, EventArgs e)
        {
            CargarEjercicios();
        }
    }
}