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
        
        public Almacenamiento referenciaAlmacenamiento { get; internal set; }
        public InventarioProduccion Ejercicio { get;  set; }


        private void label13_Click(object sender, EventArgs e)
        {

        }

        //LOAD ACTIVO, TRABAJAR AQUI ↓↓↓
        //AL CARGAR DEBE MOSTRAR LOS DATOS GUARDADOS DEL PROBLEMA SELECCIONADO DEL → DataGridView ←
        private void frmVerProblema_EPQ_Load(object sender, EventArgs e)
        {
            cmbNivelDificultad.DataSource = Enum.GetValues(typeof(Dificultad));

            if (Ejercicio == null) return;

            txtTitulo.Text = Ejercicio.Titulo;
            txtEnunciado.Text = Ejercicio.Texto;
            cmbNivelDificultad.SelectedItem = Ejercicio.Dificultad;

            txtValorD.Text = Ejercicio.DemandaXunidadTiempo.ToString();
            txtValorCh.Text = Ejercicio.CostoPorAlmacenar.ToString();
            txtValorCoCs.Text = Ejercicio.CostoPorColocarOrden.ToString();
            txtValorp.Text = Ejercicio.TasaDeProduccion.ToString();
            txtValordd.Text = Ejercicio.DemandaDiaria.ToString();
        

            lblNumCorridxAño.Text =Ejercicio.NumeroDeLotes.ToString("N4");
            lblValorImax .Text =Ejercicio.InventarioMaximo .ToString("N4");
            lblValort0.Text = Ejercicio.DuracionCicloProduccion.ToString(   "N4");
            lblValorIprom.Text = Ejercicio.InventarioPromedio.ToString("N4");
            lblValorCalm.Text = Ejercicio.CostoAnualXAlmacenar.ToString("N4");
            lblValorCprep.Text =Ejercicio .CostoAnualXPreparacion .ToString("N4");
            lblValorCT.Text =Ejercicio .CostoTotalXUnidadTiempo .ToString("N4");
            lblValorQ.Text =Ejercicio .CantidadDeLoteEconomico .ToString("N4");
            lblValortp.Text =Ejercicio .TiempoProduccion.ToString("N4");
            lblValort.Text =Ejercicio .DuracionCicloProduccion .ToString("N4");

            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //FORMULARIO DE VER, NO MODIFICAR

            //try
            //{

            //    InventarioProduccion modificado = new InventarioProduccion
            //    {

            //        Id = Ejercicio.Id,

            //        // Texto
            //        Titulo = txtTitulo.Text,
            //        Texto = txtEnunciado.Text,

            //        // Demanda
            //        DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),
            //        DemandaDiaria = ushort.Parse(txtValordd.Text),

            //        // Costos
            //        CostoPorColocarOrden = decimal.Parse(txtValorCoCs.Text),
            //        CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),

            //        // Tiempos

            //        DiasLaboradosAño = ushort.Parse(txtValorN.Text),

            //        // EPQ
            //        TasaDeProduccion = ushort.Parse(txtValorp.Text)
            //    };


            //    ReferenciaAlmacenamiento.Modificar(Dificultad.Dificil, modificado);

            //    DialogResult = DialogResult.OK;
            //    Close();

            //    DialogResult = DialogResult.OK;
            //    Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //BOTON DE FORMULARIO ACTIVO ↓↓↓
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}