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

        public override double CantidadDeLoteEconomico
        {
            get
            {
                double factor = 1 - ((double)DemandaDiaria / p);
                return Math.Sqrt((double)(2 * DemandaXunidadTiempo * CostoPorColocarOrden) / ((double)CostoPorAlmacenar * factor));
            }
        }


        public double N
        {
            get { return (DemandaXunidadTiempo / CantidadDeLoteEconomico); }
        }

        public decimal Cprep
        {
            get { return (decimal)(DemandaXunidadTiempo / CantidadDeLoteEconomico) * CostoPorColocarOrden; }
        }
        public decimal Calm
        {
            get
            {
                double factor = 1 - ((double)DemandaDiaria / p);

                return (decimal)(CantidadDeLoteEconomico / 2) * CostoPorAlmacenar * (decimal)factor;
            }
        }

        public override decimal CostoTotalXUnidadTiempo
        {
            get
            {
                return Cprep + Calm;
                ;
            }
        }
        public double Tp
        {
            get { return CantidadDeLoteEconomico / p; }
        }

        public double Imax
        {
            get
            {
                decimal factor = 1 - ((decimal)DemandaDiaria / p);

                return (CantidadDeLoteEconomico * (double)factor);
            }
        }

        public double Iprom
        {
            get
            {
                decimal factor = 1 - ((decimal)DemandaDiaria / p);

                return (CantidadDeLoteEconomico / 2) * (double)factor;
            }
        }
    }
}
