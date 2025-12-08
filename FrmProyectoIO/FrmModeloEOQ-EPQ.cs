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
                p = ushort.Parse(txt_p.Text)


            };
            a.Registrar(Dificultad.Facil, i);
            lblQ.Text = i.CantidadDeLoteEconomico.ToString();
            lblN.Text = i.N.ToString();
            lblCprep.Text = i.Cprep.ToString();
            lblCalm.Text = i.Calm.ToString();
            lblCT.Text = i.CostoTotalXUnidadTiempo.ToString();
            lblTp.Text = i.Tp.ToString();
            lblImax.Text = i.Imax.ToString();
            lblIprom.Text = i.Iprom.ToString();




        }
    }
}
