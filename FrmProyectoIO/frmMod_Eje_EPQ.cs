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
        public Inventario Ejercicio { get; internal set; }

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

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void frmMod_Eje_EPQ_Load(object sender, EventArgs e)
        {

        }
    }
}
