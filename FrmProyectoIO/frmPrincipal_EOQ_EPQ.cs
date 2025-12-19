using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrmProyectoIO
{
    public partial class frmPrincipal_EOQ_EPQ : Form
    {
        public frmPrincipal_EOQ_EPQ()
        {
            InitializeComponent();
        }
        public Almacenamiento principal = new Almacenamiento();
        List<Inventario> ejercicios=new List<Inventario>();
        private void frmPrincipal_EOQ_EPQ_Load(object sender, EventArgs e)
        {
            principal.Leer();
            cmbNivelDificultad.DataSource = Enum.GetValues(typeof(Dificultad));
        }

        private void frmPrincipal_EOQ_EPQ_FormClosing(object sender, FormClosingEventArgs e)
        {
            principal.Guardar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarExamen_Click(object sender, EventArgs e)
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

        private void btnAgg_Click(object sender, EventArgs e)
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

        private void btnImprimir_Click(object sender, EventArgs e)
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
                ejercicios=new();
            }
        }
    }
}
