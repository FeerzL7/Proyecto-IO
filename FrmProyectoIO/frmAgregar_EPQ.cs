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
    public partial class frmAgregar_EPQ : Form
    {
        public frmAgregar_EPQ()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                InventarioProduccion invProduccion = new InventarioProduccion()
                {
                    //ENTRADAS
                    Texto = txtEnunciado.Text,
                    Titulo = txtTitulo.Text,
                    DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),
                    CostoPorColocarOrden = decimal.Parse(txtValorCoCs.Text),
                    CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),
                    TasaDeProduccion = ushort.Parse(txtValorp.Text),
                    DemandaDiaria = ushort.Parse(txtValorDemDiaria.Text),

                };
                //SALIDAS
                //N2, N0 y C son formatos de salida
                //lblValorQ.Text = invProduccion.CantidadDeLoteEconomico.ToString("N2");
                //lblValorImax.Text = invProduccion.InventarioMaximo.ToString("N0") + " unidades";
                //lblValorIprom.Text = invProduccion.InventarioPromedio.ToString("N0") + " unidades";

                //lblNumCorridxAño.Text = invProduccion.NumeroDeLotes.ToString("N2");

                //lblValorCprep.Text = invProduccion.CostoAnualXPreparacion.ToString("C");
                //lblValorCalm.Text = invProduccion.CostoAnualXAlmacenar.ToString("C");
                //lblValorCT.Text = invProduccion.CostoTotalXUnidadTiempo.ToString("C");

                //lblValort.Text = invProduccion.TiempoDelCiclo.ToString("N2") + " días";
                //lblValort0.Text = invProduccion.DuracionDelCiclo.ToString("N2") + " días";
                //lblValortp.Text = invProduccion.TiempoDelCiclo.ToString("N2") + " días";

            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message, "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}