using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmProyectoIO
{
    public enum Dificultad
    {
        Facil, Dificil
    }
    public class Inventario
    {
       
        public string Texto { get; set; } = "";
       // Cambiar los nombres de las variables a unos más claros e intuitivos
        public ushort D { get; set; } //ejem: Demanda anual 
        public decimal Co { get; set; }
        public decimal Ch { get; set; }
        public ushort L { get; set; }
        public ushort Y { get; set; }
        public ushort d { get; set; }
      

        //Propiedades 
        //También Agregar nombres completos a las propiedades de cálculo 
        public virtual double Q
        {
            get
            {
                double Operacion = Math.Sqrt((double)((2 * D * Co) / Ch));
                return Operacion;
            }
        }

        public decimal CAO
        {
            get { return ((decimal)Q / 2) * Ch; }
        }
        public decimal CAA
        {
            get { return (D / (decimal)Q) * Co; }
        }
        public virtual decimal CT
        {
            get { return CAA + CAO; }
        }
        public double To
        {
            get
            {

                if (Y > 0)
                {
                    double d = ((Q / D) * Y);
                    return d;

                }
                return (Q / D);
            }
        }

        public double CantidadPromInventario
        {
            get { return (ushort)(Q / 2); }
        }

        public double Le
        {
            get
            {  //L siempre esta en dias
                if (Y == 0)
                {
                    return 0;
                }
                if (L > To)
                {
                    int n = (int)(L / To);
                    return L - (n * To);
                }
                return L;
            }
        }

        public double R
        {

            get
            {
                if (d == 0)
                {
                    return 0;
                }
                return (Le * d);
            }
        }

    }
}
