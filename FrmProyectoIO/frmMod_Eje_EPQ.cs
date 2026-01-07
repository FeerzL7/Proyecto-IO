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
    public partial class frmMod_Eje_EPQ : Form
    {
        public InventarioProduccion Ejercicio { get; set; }
        public Dificultad DificultadSeleccionada { get; set; }
        public Almacenamiento ReferenciaAlmacenamiento { get; set; }

        public frmMod_Eje_EPQ()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                lblValort.Text = produccion.DuracionCicloProduccion.ToString();
                lblNumCorridxAño.Text = produccion.NumeroDeLotes.ToString();
                lblValorImax.Text = produccion.InventarioMaximo.ToString();
                lblValorIprom.Text = produccion.InventarioPromedio.ToString();
                lblValorCalm.Text = produccion.CostoAnualXAlmacenar.ToString();
                lblValorCprep.Text = produccion.CostoAnualXPreparacion.ToString();
                lblValorCT.Text = produccion.CostoTotalXUnidadTiempo.ToString();
                lblValorQ.Text = produccion.CantidadDeLoteEconomico.ToString();
                lblValort0.Text = produccion.DuracionCicloProduccion.ToString();
                lblValortp.Text = produccion.TiempoProduccion.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReferenciaAlmacenamiento == null)
                    throw new Exception("Almacenamiento no inicializado");

                InventarioProduccion modificado = new InventarioProduccion()
                {
                   
                    Id = Ejercicio.Id,

                    Titulo = txtTitulo.Text,
                    Texto = txtEnunciado.Text,
                    Dificultad = Ejercicio.Dificultad,
                    DemandaXunidadTiempo = ushort.Parse(txtValorD.Text),
                    DemandaDiaria = ushort.Parse(txtValordd.Text),
                    CostoPorColocarOrden = decimal.Parse(txtValorCoCs.Text),
                    CostoPorAlmacenar = decimal.Parse(txtValorCh.Text),
                    TasaDeProduccion = ushort.Parse(txtValorp.Text),
                };

                ReferenciaAlmacenamiento.Modificar(Ejercicio.Dificultad,modificado);

                MessageBox.Show("Ejercicio EPQ modificado correctamente");
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Escriba todo en formato Numerico");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Ninguno de los datos Debe ser negativo");
            }
        }

        private void frmMod_Eje_EPQ_Load(object sender, EventArgs e)
        {
            if (Ejercicio == null) return;

            cmbNivelDificultad.DataSource = Enum.GetValues(typeof(Dificultad));
            cmbNivelDificultad.SelectedItem = Ejercicio.Dificultad;

            txtTitulo.Text = Ejercicio.Titulo;
            txtEnunciado.Text = Ejercicio.Texto;

            txtValorD.Text = Ejercicio.DemandaXunidadTiempo.ToString();
            txtValorCh.Text = Ejercicio.CostoPorAlmacenar.ToString();
            txtValorCoCs.Text = Ejercicio.CostoPorColocarOrden.ToString();
            txtValorp.Text = Ejercicio.TasaDeProduccion.ToString();
            txtValordd.Text = Ejercicio.DemandaDiaria.ToString();
        }
    }
}
