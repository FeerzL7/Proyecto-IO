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
        public Almacenamiento referenciaAlmacenamiento { get; set; } = new Almacenamiento();

        private void frmAgregar_EOQ_Load(object sender, EventArgs e)
        {
            cmbNivelDificultad.DataSource = Enum.GetValues(typeof(Dificultad));

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Inventario Reactivo = new Inventario()
                {
                    Texto = txtEnunciado.Text,
                    Titulo = txtTitulo.Text,
                    DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),
                    CostoPorColocarOrden = decimal.Parse(txtValorCo.Text),
                    CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),
                    TiempoDeEntrega = ushort.Parse(txtValorL.Text),
                    DiasLaboradosAño = ushort.Parse(txtValorY.Text),
                };
                referenciaAlmacenamiento.Registrar((Dificultad)cmbNivelDificultad.SelectedItem, Reactivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Inventario reactivo = new Inventario()
            {
                DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),
                CostoPorColocarOrden = decimal.Parse(txtValorCo.Text),
                CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),
                TiempoDeEntrega = ushort.Parse(txtValorL.Text),
                DiasLaboradosAño = ushort.Parse(txtValorY.Text),
            }; 
            lblCLE.Text = reactivo.CantidadDeLoteEconomico.ToString();
            lblLe.Text = reactivo.CostoAnualXOrdenar.ToString();// este esta raro, dice que es CAO, pero el nombre del label es lblLe
            lblPntReorden.Text = reactivo.PuntoDeReorden.ToString();
            lblDurCicloPedido .Text = reactivo.DuracionDelCiclo.ToString(); //

        }
    }
}