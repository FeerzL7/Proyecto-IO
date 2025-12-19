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
    public partial class frmVerProblema_EOQ : Form
    {

        public Inventario Ejercicio { get; internal set; }
        public Almacenamiento ReferenciaAlmacenamiento { get; internal set; }

        public frmVerProblema_EOQ()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmVerProblema_EOQ_Load(object sender, EventArgs e)
        {

            if (Ejercicio == null) return;

            txtTitulo.Text = Ejercicio.Titulo;
            txtEnunciado.Text = Ejercicio.Texto;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se crea el objeto modificado mismo Id
                Inventario modificado = new Inventario
                {
                    Id = Ejercicio.Id,

                    Titulo = txtTitulo.Text,
                    Texto = txtEnunciado.Text,

                    DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),
                    CostoPorColocarOrden = decimal.Parse(txtValorCoCs.Text),
                    CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),
                    TiempoDeEntrega = ushort.Parse(txtValorL.Text),

                };



                ReferenciaAlmacenamiento.Modificar(Dificultad.Facil, modificado);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}