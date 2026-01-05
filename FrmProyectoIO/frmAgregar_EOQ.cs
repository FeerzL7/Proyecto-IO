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
        public Dificultad DificultadSeleccionada { get; set; }

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
                    CostoPorAlmacenar = decimal.Parse(txtValorCo.Text),
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
            //this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Inventario reactivo = new Inventario()
            //{
            //    DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),

            //    CostoPorColocarOrden = decimal.Parse(txtValorCo.Text),
            //    CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),
            //    TiempoDeEntrega = ushort.Parse(txtValorL.Text),
            //    DiasLaboradosAño = ushort.Parse(txtValorY.Text),
            //};
            //lblValorCLE.Text = reactivo.CantidadDeLoteEconomico.ToString();
            //lblValorLe.Text = reactivo.CostoAnualXOrdenar.ToString();// este esta raro, dice que es CAO, pero el nombre del label es lblLe
            //lblPuntoDeReorden.Text = reactivo.PuntoDeReorden.ToString();
            //lblDuracionCiclPedido.Text = reactivo.DuracionDelCiclo.ToString(); //

        }

        private void frmAgregar_EOQ_Load_1(object sender, EventArgs e)
        {
            cmbNivelDificultad.DataSource = Enum.GetValues(typeof(Dificultad));
            cmbNivelDificultad.SelectedItem = DificultadSeleccionada;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //BOTON PARA SALIR: ↓↓↓
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON AGREGAR: ↓↓↓
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDACIONES
                if (!ushort.TryParse(txtValorD.Text, out var demanda))
                {
                    MessageBox.Show("La demanda debe ser numérica");
                    return;
                }

                if (!decimal.TryParse(txtValorCo.Text, out var costoOrden))
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


                // CREAR MODELO EOQ
                Inventario inventario = new Inventario
                {
                    Titulo = txtTitulo.Text,
                    Texto = txtEnunciado.Text,
                    DemandaXunidadTiempo = demanda,
                    CostoPorColocarOrden = costoOrden,
                    CostoPorAlmacenar = costoAlmac,
                    DiasLaboradosAño = dias,
                    TiempoDeEntrega = tiempoEntrega,
                    DemandaDiaria = demandadiaria
                    
                };

                // GUARDAR
                referenciaAlmacenamiento.Registrar(DificultadSeleccionada,inventario);

                referenciaAlmacenamiento.Guardar();

                MessageBox.Show("Ejercicio EOQ guardado correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Boton Calcular: ↓↓↓
        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                Inventario reactivo = new Inventario()
                {
                    DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),

                    CostoPorColocarOrden = decimal.Parse(txtValorCo.Text),
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}