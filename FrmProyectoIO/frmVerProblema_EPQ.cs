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

        public InventarioProduccion ReferenciaEPQ { get; internal set; }

        public frmVerProblema_EPQ()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void frmVerProblema_EPQ_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //ENTRADAS
                ReferenciaEPQ.Texto = txtEnunciado.Text;
                ReferenciaEPQ.DemandaXunidadTiempo = ushort.Parse(txtValorD.Text);
                ReferenciaEPQ.DemandaDiaria = ushort.Parse(txtValordd.Text);
                ReferenciaEPQ.TasaDeProduccion = ushort.Parse(txtValorp.Text);
                ReferenciaEPQ.CostoPorColocarOrden = decimal.Parse(txtValorCoCs.Text);
                ReferenciaEPQ.CostoPorAlmacenar = decimal.Parse(txtValorCh.Text);

                //SALIDAS
                //N2, N0 y C son formatos de salida
                lblValorQ.Text = ReferenciaEPQ.CantidadDeLoteEconomico.ToString("N2");

                lblValorImax.Text = ReferenciaEPQ.InventarioMaximo.ToString("N0") + " unidades";
                lblValorIprom.Text = ReferenciaEPQ.InventarioPromedio.ToString("N0") + " unidades";

                lblValorCalm.Text = ReferenciaEPQ.CostoAnualXAlmacenar.ToString("C");

                lblNumCorridxAño.Text = ReferenciaEPQ.NumeroDeLotes.ToString("N2");

                lblValort.Text = ReferenciaEPQ.TiempoDelCiclo.ToString("N2");

                lblValort0.Text = ReferenciaEPQ.DuracionDelCiclo.ToString("N2");

                lblValorCprep.Text = ReferenciaEPQ.CostoAnualXPreparacion.ToString("C");

                lblValorCT.Text = ReferenciaEPQ.CostoTotalXUnidadTiempo.ToString("C");

                // falta crear tp en la clase de InventarioProduccion

            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message, "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
