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
            if (Ejercicio == null) return;

            txtTitulo.Text = Ejercicio.Titulo;
            txtEnunciado.Text = Ejercicio.Texto;

            txtValorD.Text = Ejercicio.DemandaXunidadTiempo.ToString();
            txtValorCh.Text = Ejercicio.CostoPorAlmacenar.ToString();
            txtValorCoCs.Text = Ejercicio.CostoAnualXPreparacion.ToString();
            txtValorp.Text = Ejercicio.TasaDeProduccion.ToString();
            txtValordd.Text = Ejercicio.DemandaDiaria.ToString();
        



            
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