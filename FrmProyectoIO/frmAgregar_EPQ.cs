namespace FrmProyectoIO
{
    public partial class frmAgregar_EPQ : Form
    {
        public frmAgregar_EPQ()
        {
            InitializeComponent();
        }
        public Almacenamiento referenciaAlmacenamiento { get; set; }
        public Dificultad DificultadSeleccionada { get; set; }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAgregar_EPQ_Load(object sender, EventArgs e)
        {
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
                if (string.IsNullOrWhiteSpace(txtValorCh.Text))
                {
                    throw new ArgumentException("Ningún valor puede estar vacio, asegurese de rellenar todos los datos.");
                }
                if (string.IsNullOrWhiteSpace(txtValorCoCs.Text))
                {
                    throw new ArgumentException("Ningún valor puede estar vacio, asegurese de rellenar todos los datos.");
                }
                if (string.IsNullOrWhiteSpace(txtValorD.Text))
                {
                    throw new ArgumentException("Ningún valor puede estar vacio, asegurese de rellenar todos los datos.");
                }
                if (string.IsNullOrWhiteSpace(txtValorp.Text))
                {
                    throw new ArgumentException("Ningún valor puede estar vacio, asegurese de rellenar todos los datos.");
                }
                if (string.IsNullOrWhiteSpace(txtValordd.Text))
                {
                    throw new ArgumentException("Ningún valor puede estar vacio, asegurese de rellenar todos los datos.");
                }
                if (!ushort.TryParse(txtValorD.Text, out ushort demanda))
                    throw new ArgumentException("La demanda debe ser un número entero válido.");

                if (!decimal.TryParse(txtValorCoCs.Text, out decimal costoOrden))
                    throw new ArgumentException("El costo por ordenar debe ser numérico.");

                if (!decimal.TryParse(txtValorCh.Text, out decimal costoAlmacenar))
                    throw new ArgumentException("El costo por almacenar debe ser numérico.");

                if (!ushort.TryParse(txtValorp.Text, out ushort tasaProd))
                    throw new ArgumentException("La tasa de producción debe ser un número entero.");

                if (!ushort.TryParse(txtValordd.Text, out ushort demandaDiaria))
                    throw new ArgumentException("La demanda diaria debe ser un número entero.");
                InventarioProduccion produccion = new InventarioProduccion()
                {
                    DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),
                    CostoPorColocarOrden = decimal.Parse(txtValorCoCs.Text),
                    CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),
                    TasaDeProduccion = ushort.Parse(txtValorp.Text),
                    DemandaDiaria = ushort.Parse(txtValordd.Text)
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
                if (referenciaAlmacenamiento == null)
                {
                    MessageBox.Show("Error interno: almacenamiento no inicializado");
                    return;
                }

                if (cmbNivelDificultad.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona una dificultad");
                    return;
                }

                InventarioProduccion produccion = new InventarioProduccion()
                {
                    Titulo = txtTitulo.Text,
                    Texto = txtEnunciado.Text,

                    DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),
                    DemandaDiaria = ushort.Parse(txtValordd.Text),
                    CostoPorColocarOrden = decimal.Parse(txtValorCoCs.Text),
                    CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),
                    TasaDeProduccion = ushort.Parse(txtValorp.Text),

                };

                referenciaAlmacenamiento.Registrar(DificultadSeleccionada, produccion);

               MessageBox.Show("Ejercicio EPQ agregado correctamente");
               this.Close();
                 }
            catch (FormatException)
            {
                MessageBox.Show("Verifica los valores numéricos");
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

        private void frmAgregar_EPQ_Load_1(object sender, EventArgs e)
        {
            cmbNivelDificultad.DataSource = Enum.GetValues(typeof(Dificultad));
            cmbNivelDificultad.SelectedItem = DificultadSeleccionada;
        }
    }
}