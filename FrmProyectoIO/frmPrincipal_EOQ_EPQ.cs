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
    public partial class frmPrincipal_EOQ_EPQ : Form
    {
        public frmPrincipal_EOQ_EPQ()
        {
            InitializeComponent();
        }
        public Almacenamiento principal { get; set; } = new Almacenamiento();
        private void frmPrincipal_EOQ_EPQ_Load(object sender, EventArgs e)
        {
            principal.Leer();
            cmbNivelDificultad.DataSource = Enum.GetValues(typeof(Dificultad));
        }

        private void frmPrincipal_EOQ_EPQ_FormClosing(object sender, FormClosingEventArgs e)
        {
            principal.Guardar();
        }



        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvEjercicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEnunciado.Clear();
            txtTitulo.Clear();
        }
    }
}
