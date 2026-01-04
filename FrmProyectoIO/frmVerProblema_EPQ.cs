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
    public partial class frmVerProblema_EPQ : Form
    {

        public InventarioProduccion ReferenciaEPQ { get; internal set; } = new();
        public Almacenamiento ReferenciaAlmacenamiento { get; internal set; }

        public frmVerProblema_EPQ()
        {
            InitializeComponent();
        }
        public Inventario Ejercicio { get; internal set; }
        public Almacenamiento referenciaAlmacenamiento { get; internal set; }

        private void label13_Click(object sender, EventArgs e)
        {

        }


        private void frmVerProblema_EPQ_Load(object sender, EventArgs e)
        {
            if (Ejercicio == null) return;

            txtTitulo.Text = Ejercicio.Titulo;
            txtEnunciado.Text = Ejercicio.Texto;
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                InventarioProduccion modificado = new InventarioProduccion
                {

                    Id = Ejercicio.Id,

                    // Texto
                    Titulo = txtTitulo.Text,
                    Texto = txtEnunciado.Text,

                    // Demanda
                    DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),
                    DemandaDiaria = ushort.Parse(txtValordd.Text),

                    // Costos
                    CostoPorColocarOrden = decimal.Parse(txtValorCoCs.Text),
                    CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),

                    // Tiempos

                    DiasLaboradosAño = ushort.Parse(txtValorN.Text),

                    // EPQ
                    TasaDeProduccion = ushort.Parse(txtValorp.Text)
                };


                ReferenciaAlmacenamiento.Modificar(Dificultad.Dificil, modificado);

                DialogResult = DialogResult.OK;
                Close();

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {

        }
    }
}