using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmProyectoIO
{
    public class InventarioProduccion : Inventario


    {
        public override TipoEjercicio Tipo => TipoEjercicio.EPQ;

        public ushort TasaDeProduccion { get; set; }

        public override double CantidadDeLoteEconomico
        {
            get
            {
                double factor = 1 - ((double)DemandaDiaria / TasaDeProduccion);
                return Math.Sqrt((double)(2 * DemandaXunidadTiempo * CostoPorColocarOrden) / ((double)CostoPorAlmacenar * factor));
            }
        }


        public double NumeroDeLotes
        {
            get { return (DemandaXunidadTiempo / CantidadDeLoteEconomico); }
        }

        public decimal CostoAnualXPreparacion
        {
            get { return (decimal)(DemandaXunidadTiempo / CantidadDeLoteEconomico) * CostoPorColocarOrden; }
        }
        public override decimal CostoAnualXAlmacenar
        {
            get
            {
                double factor = 1 - ((double)DemandaDiaria / TasaDeProduccion);

                return (decimal)(CantidadDeLoteEconomico / 2) * CostoPorAlmacenar * (decimal)factor;
            }
        }

        public override decimal CostoTotalXUnidadTiempo
        {
            get
            {
                return CostoAnualXPreparacion + CostoAnualXAlmacenar;
                ;
            }
        }
        public double TiempoDelCiclo
        {
            get { return CantidadDeLoteEconomico / TasaDeProduccion; }
        }

        public double InventarioMaximo
        {
            get
            {
                decimal factor = 1 - ((decimal)DemandaDiaria / TasaDeProduccion);

                return (CantidadDeLoteEconomico * (double)factor);
            }
        }

        public double InventarioPromedio
        {
            get
            {
                decimal factor = 1 - ((decimal)DemandaDiaria / TasaDeProduccion);

                return (CantidadDeLoteEconomico / 2) * (double)factor;
            }
        }
    }
}
