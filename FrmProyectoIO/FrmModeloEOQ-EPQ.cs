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
    public partial class FrmModeloEOQ_EPQ : Form
    {
        public FrmModeloEOQ_EPQ()
        {
            InitializeComponent();
        }

        private void FrmModeloEOQ_EPQ_Load(object sender, EventArgs e)
        {

        }
        Almacenamiento a = new();
        private void button1_Click(object sender, EventArgs e)
        {
            InventarioProduccion i = new InventarioProduccion()
            {
                Texto = txtTexto.Text,
                DemandaXunidadTiempo = ushort.Parse(txtD.Text),
                CostoPorColocarOrden = decimal.Parse(txtCo.Text),
                CostoPorAlmacenar = decimal.Parse(txtCh.Text),
                DemandaDiaria = ushort.Parse(txt_d.Text),
                TasaDeProduccion = ushort.Parse(txt_p.Text)


            };
            a.Registrar(Dificultad.Facil, i);
            lblQ.Text = i.CantidadDeLoteEconomico.ToString();
            lblN.Text = i.NumeroDeLotes.ToString();
            lblCprep.Text = i.CostoAnualXPreparacion.ToString();
            lblCalm.Text = i.CostoAnualXAlmacenar.ToString();
            lblCT.Text = i.CostoTotalXUnidadTiempo.ToString();
            lblTp.Text = i.TiempoDelCiclo.ToString();
            lblImax.Text = i.InventarioMaximo.ToString();
            lblIprom.Text = i.InventarioPromedio.ToString();




        }
    }
}
