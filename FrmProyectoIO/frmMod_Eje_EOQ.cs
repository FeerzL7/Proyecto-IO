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
    public partial class frmMod_Eje_EOQ : Form
    {
        public Inventario Ejercicio { get; set; }
        public Dificultad DificultadSeleccionada { get; set; }
        public Almacenamiento ReferenciaAlmacenamiento { get; set; }

        public frmMod_Eje_EOQ()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void frmMod_Eje_EOQ_Load(object sender, EventArgs e)
        {
            cmbNivelDificultad.DataSource = Enum.GetValues(typeof(Dificultad));
            cmbNivelDificultad.SelectedItem = Ejercicio.Dificultad;


            txtTitulo.Text = Ejercicio.Titulo;
            txtEnunciado.Text = Ejercicio.Texto;

            txtValorD.Text = Ejercicio.DemandaXunidadTiempo.ToString();
            txtValorCoCs.Text = Ejercicio.CostoPorColocarOrden.ToString();
            txtValorCh.Text = Ejercicio.CostoPorAlmacenar.ToString();
            txtValorL.Text = Ejercicio.TiempoDeEntrega.ToString();
            txtValorY.Text = Ejercicio.DiasLaboradosAño.ToString();
            txtValorDemandaDiaria.Text = Ejercicio.DemandaDiaria.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        //TRABAJAR AQUI: ↓↓↓
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ReferenciaAlmacenamiento == null)
                    throw new Exception("Almacenamiento no inicializado");

                Inventario modificado = new Inventario
                {
                    Id = Ejercicio.Id,
                    Titulo = txtTitulo.Text,
                    Texto = txtEnunciado.Text,
                    Dificultad = Ejercicio.Dificultad,
                    DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),
                    CostoPorColocarOrden = decimal.Parse(txtValorCoCs.Text),
                    CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),
                    TiempoDeEntrega = ushort.Parse(txtValorL.Text),
                    DiasLaboradosAño = ushort.Parse(txtValorY.Text),
                    DemandaDiaria = ushort.Parse(txtValorDemandaDiaria.Text)
                };

                ReferenciaAlmacenamiento.Modificar(
    Ejercicio.Dificultad,
    modificado
);

                MessageBox.Show("Ejercicio EOQ modificado correctamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ushort.TryParse(txtValorD.Text, out var demanda))
                {
                    MessageBox.Show("La demanda debe ser numérica");
                    return;
                }


                if (!decimal.TryParse(txtValorCoCs.Text, out var costoOrden))
                {
                    MessageBox.Show("El costo por ordenar debe ser numérico");
                    return;
                }

                if (!decimal.TryParse(txtValorCh.Text, out var costoAlmac))
                {
                    MessageBox.Show("El costo por almacenar debe ser numérico");
                    return;
                }

                if (!ushort.TryParse(txtValorY.Text, out var dias))
                {
                    MessageBox.Show("Los días laborados deben ser numéricos");
                    return;
                }

                if (!ushort.TryParse(txtValorL.Text, out var tiempoEntrega))
                {
                    MessageBox.Show("El tiempo de entrega debe ser numérico");
                    return;
                }
                if (!ushort.TryParse(txtValorDemandaDiaria.Text, out var demandadiaria))
                {
                    MessageBox.Show("La demanda diaria debe ser numerica");
                    return;
                }
                Inventario reactivo = new Inventario()
                {
                    DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),

                    CostoPorColocarOrden = decimal.Parse(txtValorCoCs.Text),
                    CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),
                    TiempoDeEntrega = ushort.Parse(txtValorL.Text),
                    DiasLaboradosAño = ushort.Parse(txtValorY.Text),
                    DemandaDiaria = ushort.Parse(txtValorDemandaDiaria.Text),
                };
                lblValorCAO.Text = reactivo.CostoAnualXOrdenar.ToString();
                lblValort0.Text = reactivo.DuracionDelCiclo.ToString();
                lblValorCT.Text = reactivo.CostoTotalXUnidadTiempo.ToString();
                lblValorCAA.Text = reactivo.CostoAnualXAlmacenar.ToString();
                lblValorCLE.Text = reactivo.CantidadDeLoteEconomico.ToString();
                lblValorLe.Text = reactivo.CostoAnualXOrdenar.ToString();// este esta raro, dice que es CAO, pero el nombre del label es lblLe
                lblPuntoDeReorden.Text = reactivo.PuntoDeReorden.ToString();
                lblDuracionCiclPedido.Text = reactivo.DuracionDelCiclo.ToString(); //
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
