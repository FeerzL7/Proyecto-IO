namespace FrmProyectoIO
{
    public partial class frmVerProblema_EOQ : Form
    {

        public frmVerProblema_EOQ()
        {
            InitializeComponent();

        }
        public Inventario Ejercicio { get; internal set; } = new();
        public InventarioProduccion ReferenciaInv { get; internal set; } = new();
        public Almacenamiento ReferenciaAlmacenamiento { get; internal set; } = new();
        public Almacenamiento referenciaAlmacenamiento { get; internal set; }

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

        //LOAD DEL FORMULARIO, HACER AQUI LAS FUNCIONES DE VER EJERCICIO ↓↓↓
        private void frmVerProblema_EOQ_Load(object sender, EventArgs e)
        {
            if (Ejercicio == null) return;

            txtTitulo.Text = Ejercicio.Titulo;
            txtEnunciado.Text = Ejercicio.Texto;

            txtValorD.Text = Ejercicio.DemandaXunidadTiempo.ToString();
            txtValorCh.Text = Ejercicio.CostoPorAlmacenar.ToString();
            txtValorCo.Text = Ejercicio.CostoAnualXOrdenar.ToString();
            txtValorL.Text = Ejercicio.TiempoDeEntrega.ToString();
            txtValorY.Text = Ejercicio.DiasLaboradosAño.ToString();
            txtValorDemandaDiaria.Text = Ejercicio.DemandaDiaria.ToString();



            lblValorCAO.Text = Ejercicio.CostoAnualXOrdenar.ToString();
            lblValorCAA.Text = Ejercicio.CostoAnualXAlmacenar.ToString();
            lblValort0.Text =Ejercicio .DuracionDelCiclo.ToString();
            lblValorCT.Text = Ejercicio.CostoTotalXUnidadTiempo.ToString();
            lblValorLe.Text =Ejercicio .TiempoEfectivo.ToString();
            lblValorCLE.Text =Ejercicio.CantidadDeLoteEconomico.ToString();
            lblPuntoDeReorden.Text =Ejercicio .PuntoDeReorden.ToString();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //FORMULARIO DE VER, NO MODIFICAR

            //try
            //{
            //    // Se crea el objeto modificado mismo Id
            //    Inventario modificado = new Inventario
            //    {
            //        Id = Ejercicio.Id,

            //        Titulo = txtTitulo.Text,
            //        Texto = txtEnunciado.Text,

            //        DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),
            //        CostoPorColocarOrden = decimal.Parse(txtValorCoCs.Text),
            //        CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),
            //        TiempoDeEntrega = ushort.Parse(txtValorL.Text),

            //    };



            //    ReferenciaAlmacenamiento.Modificar(Dificultad.Facil, modificado);

            //    DialogResult = DialogResult.OK;
            //    Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}