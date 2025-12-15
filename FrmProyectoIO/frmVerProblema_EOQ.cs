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
        public Inventario ReferenciaInv { get; internal set; }
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

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //ENTRADAS
                ReferenciaInv.Texto = txtEnunciado.Text;
                ReferenciaInv.DemandaXunidadTiempo = ushort.Parse(txtValorD.Text);
                ReferenciaInv.CostoPorColocarOrden = decimal.Parse(txtValorCoCs.Text);
                ReferenciaInv.CostoPorAlmacenar = decimal.Parse(txtValorCh.Text);
                ReferenciaInv.TiempoDeEntrega = ushort.Parse(txtValorL.Text);
                ReferenciaInv.DiasLaboradosAño = ushort.Parse(txtValorY.Text);
                //txtValorp.Text - p no es de EOQ?

                //SALIDAs
                //N2, N0 y C son formatos de salida
                lblValorCLE.Text = ReferenciaInv.CantidadDeLoteEconomico.ToString("N2");

                lblValorCAO.Text = ReferenciaInv.CostoAnualXOrdenar.ToString("C");
                lblValorCAA.Text = ReferenciaInv.CostoAnualXAlmacenar.ToString("C");

                lblValorCT.Text = ReferenciaInv.CostoTotalXUnidadTiempo.ToString("C");

                lblDuracionCiclPedido.Text = ReferenciaInv.DuracionDelCiclo.ToString("N2") + " días";

                lblPuntoDeReorden.Text = ReferenciaInv.PuntoDeReorden.ToString("N0") + " unidades";

                lblValorLe.Text = ReferenciaInv.TiempoEfectivo.ToString("N2") + " días";

                lblValort0.Text = ReferenciaInv.CantidadPromInventario.ToString("N0") + " unidades";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepción encontrada",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
