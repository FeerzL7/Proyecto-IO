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
    public partial class frmGenerarExamen : Form
    {
        public frmGenerarExamen()
        {
            InitializeComponent();
        }

        public Almacenamiento Rprincipal { get; set; }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON DE FORMULARIO, TRABAJAR AQUI ↓↓↓
        private void btnGenerarExamen_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog Guardar = new();
                Guardar.Filter = "PDF (*.pdf)|*.pdf";
                Guardar.FileName = "examen " + DateTime.Now.ToString("D");
                if (Guardar.ShowDialog() == DialogResult.OK)
                {

                    Rprincipal.GenerarExamenPDF(Guardar.FileName, int.Parse(txtFacilEOQ.Text), int.Parse(txtMediaEOQ.Text), int.Parse(txtAltaEOQ.Text)
                        , int.Parse(txtFacilEPQ.Text), int.Parse(txtMediaEPQ.Text), int.Parse(txtAltaEPQ.Text));
                    MessageBox.Show("Examen generado correctamente");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese los datos en formato numerico");
            }
        }
    }
}
