namespace FrmProyectoIO
{
    public partial class frmAgregar_EPQ : Form
    {
        public frmAgregar_EPQ()
        {
            InitializeComponent();
        }
        public Almacenamiento referenciaAlmacenamiento { get; set; } = new Almacenamiento();
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAgregar_EPQ_Load(object sender, EventArgs e)
        {
            cmbNivelDificultad.DataSource = Enum.GetValues(typeof(Dificultad));
        }


        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            //InventarioProduccion produccion = new InventarioProduccion()
            //{
            //    DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),
            //    CostoPorColocarOrden = decimal.Parse(txtValorCoCs.Text),
            //    CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),
            //    TasaDeProduccion = ushort.Parse(txtValorp.Text)
            //};
            //lblValort.Text = produccion.TiempoDelCiclo.ToString();
            //lblNumCorridxAño.Text = produccion.NumeroDeLotes.ToString();
            //lblValorImax.Text = produccion.InventarioMaximo.ToString();
            //lblValorIprom.Text = produccion.InventarioPromedio.ToString();
            //lblValorCalm.Text = produccion.CostoAnualXAlmacenar.ToString();
            //lblValorCprep.Text = produccion.CostoAnualXPreparacion.ToString();
            //lblValorCT.Text = produccion.CostoTotalXUnidadTiempo.ToString();
            //lblValorQ.Text = produccion.CantidadDeLoteEconomico.ToString();
            //lblValort0.Text = produccion.TiempoDelCiclo.ToString();
            //lblValortp.Text = produccion.TiempoEfectivo.ToString();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    InventarioProduccion produccion = new InventarioProduccion()
            //    {
            //        Texto = txtEnunciado.Text,
            //        Titulo = txtTitulo.Text,
            //        DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),
            //        CostoPorColocarOrden = decimal.Parse(txtValorCoCs.Text),
            //        CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),
            //        TasaDeProduccion = ushort.Parse(txtValorp.Text),
            //        DiasLaboradosAño = ushort.Parse(txtValorDemDiaria.Text)
            //    };
            //    referenciaAlmacenamiento.Registrar((Dificultad)cmbNivelDificultad.SelectedItem, produccion);
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    InventarioProduccion produccion = new InventarioProduccion()
            //    {
            //        Texto = txtEnunciado.Text,
            //        Titulo = txtTitulo.Text,
            //        DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),
            //        CostoPorColocarOrden = decimal.Parse(txtValorCoCs.Text),
            //        CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),
            //        TasaDeProduccion = ushort.Parse(txtValorp.Text),
            //        DiasLaboradosAño = ushort.Parse(txtValordd.Text)
            //    };
            //    referenciaAlmacenamiento.Registrar((Dificultad)cmbNivelDificultad.SelectedItem, produccion);
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                InventarioProduccion produccion = new InventarioProduccion()
                {
                    DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),
                    CostoPorColocarOrden = decimal.Parse(txtValorCoCs.Text),
                    CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),
                    TasaDeProduccion = ushort.Parse(txtValorp.Text)
                };
                lblValort.Text = produccion.TiempoDelCiclo.ToString();
                lblNumCorridxAño.Text = produccion.NumeroDeLotes.ToString();
                lblValorImax.Text = produccion.InventarioMaximo.ToString();
                lblValorIprom.Text = produccion.InventarioPromedio.ToString();
                lblValorCalm.Text = produccion.CostoAnualXAlmacenar.ToString();
                lblValorCprep.Text = produccion.CostoAnualXPreparacion.ToString();
                lblValorCT.Text = produccion.CostoTotalXUnidadTiempo.ToString();
                lblValorQ.Text = produccion.CantidadDeLoteEconomico.ToString();
                lblValort0.Text = produccion.TiempoDelCiclo.ToString();
                lblValortp.Text = produccion.TiempoEfectivo.ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
         }

        private void btnAgregar_Click_2(object sender, EventArgs e)
        {
            try
            {
                InventarioProduccion produccion = new InventarioProduccion()
                {
                    Texto = txtEnunciado.Text,
                    Titulo = txtTitulo.Text,
                    DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),
                    CostoPorColocarOrden = decimal.Parse(txtValorCoCs.Text),
                    CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),
                    TasaDeProduccion = ushort.Parse(txtValorp.Text),
                    DiasLaboradosAño = ushort.Parse(txtValordd.Text)
                };
                referenciaAlmacenamiento.Registrar((Dificultad)cmbNivelDificultad.SelectedItem, produccion);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}