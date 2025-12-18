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
    public partial class frmAgregar_EOQ : Form
    {
        public frmAgregar_EOQ()
        {
            InitializeComponent();
        }
        Inventario inv = new Inventario();
        private void frmAgregar_EOQ_Load(object sender, EventArgs e)
        {
            cmbNivelDificultad.DataSource = Enum.GetValues(typeof(Dificultad));

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Inventario inv = new Inventario()
                {
                    Texto = txtEnunciado.Text,
                    Titulo = txtTitulo.Text,
                    DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),
                    CostoPorColocarOrden = decimal.Parse(txtValorCo.Text),
                    CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),
                    TiempoDeEntrega = ushort.Parse(txtValorL.Text),
                    DiasLaboradosAño = ushort.Parse(txtValorY.Text),



                };
                //N2, N0 y C son formatos de salida
                lblCAO.Text = inv.CostoAnualXOrdenar.ToString("C");
                lblDurCicloPedido.Text = inv.DuracionDelCiclo.ToString("N2") + " días";
                lblCT.Text = inv.CostoTotalXUnidadTiempo.ToString("C");
                lblCAA.Text = inv.CostoAnualXAlmacenar.ToString("C");
                lblLe.Text = inv.TiempoEfectivo.ToString("N2") + " días";
                lblCLE.Text = inv.CantidadDeLoteEconomico.ToString("N2") + " unidades";
                lblPntReorden.Text = inv.PuntoDeReorden.ToString("N0") + " unidades";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}