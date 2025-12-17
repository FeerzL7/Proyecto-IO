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
            cmbDificultad.DataSource = Enum.GetValues(typeof(Dificultad));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Inventario inv = new Inventario()
                {
                    Texto = txtEnunciado.Text,
                    Titulo = txtTitulo.Text,
                    DemandaXunidadTiempo = ushort.Parse(txtDemanda.Text),
                    CostoPorColocarOrden = decimal.Parse(txtCostoOrdenar.Text),
                    CostoPorAlmacenar = decimal.Parse(txtCostoAlmacenar.Text),
                    TiempoDeEntrega = ushort.Parse(txtTiempoEntrega.Text),
                    DiasLaboradosAño = ushort.Parse(txtDiasLaborados.Text),



                };
                lblCostoXOrdenar.Text = inv.CostoAnualXOrdenar.ToString();
                lblDuracionDelCiclo.Text = inv.DuracionDelCiclo.ToString();
                lblCostoXUnidadTiempo.Text = inv.CostoTotalXUnidadTiempo.ToString();
                lblCostoAnualXAlmacenar.Text = inv.CostoAnualXAlmacenar.ToString();
                lblTiempoEntregaEfectivo.Text = inv.TiempoEfectivo.ToString();
                lblCantidadLoteEconomico.Text = inv.CantidadDeLoteEconomico.ToString();
                lblPuntoReorden.Text = inv.PuntoDeReorden.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
