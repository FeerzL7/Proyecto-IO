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
                D = ushort.Parse(txtD.Text),
                Co = decimal.Parse(txtCo.Text),
                Ch = decimal.Parse(txtCh.Text),
                d = ushort.Parse(txt_d.Text),
                p = ushort.Parse(txt_p.Text)


            };
            a.Registrar(Dificultad.Facil, i);
            lblQ.Text = i.Q.ToString();
            lblN.Text = i.N.ToString();
            lblCprep.Text = i.Cprep.ToString();
            lblCalm.Text = i.Calm.ToString();
            lblCT.Text = i.CT.ToString();
            lblTp.Text = i.Tp.ToString();
            lblImax.Text = i.Imax.ToString();
            lblIprom.Text = i.Iprom.ToString();




        }
    }
}
