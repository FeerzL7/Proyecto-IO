using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmProyectoIO
{
    public class InventarioProduccion : Inventario
    {
        public ushort p { get; set; }

        public override double Q
        {
            get
            {
                double factor = 1 - ((double)d / p);
                return Math.Sqrt((double)(2 * D * Co) / ((double)Ch * factor));
            }
        }


        public double N
        {
            get { return (D / Q); }
        }

        public decimal Cprep
        {
            get { return (decimal)(D / Q) * Co; }
        }
        public decimal Calm
        {
            get
            {
                double factor = 1 - ((double)d / p);

                return (decimal)(Q / 2) * Ch * (decimal)factor;
            }
        }

        public override decimal CT
        {
            get
            {
                return Cprep + Calm;
                ;
            }
        }
        public double Tp
        {
            get { return Q / p; }
        }

        public double Imax
        {
            get
            {
                decimal factor = 1 - ((decimal)d / p);

                return (Q * (double)factor);
            }
        }

        public double Iprom
        {
            get
            {
                decimal factor = 1 - ((decimal)d / p);

                return (Q / 2) * (double)factor;
            }
        }
    }
}
