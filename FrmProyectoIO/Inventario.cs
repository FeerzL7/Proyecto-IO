using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmProyectoIO
{
    public enum TipoEjercicio
    {
        EOQ,
        EPQ
    }
    public enum Dificultad
    {
        Facil, Dificil
    }
    public class Inventario
    {
        public virtual TipoEjercicio Tipo => TipoEjercicio.EOQ;

        public string Texto { get; set; } = "";
        public ushort DemandaXunidadTiempo { get; set; }
        public decimal CostoPorColocarOrden { get; set; }
        public decimal CostoPorAlmacenar { get; set; }
        public ushort TiempoDeEntrega { get; set; }
        public ushort DiasLaboradosAño { get; set; }
        public ushort DemandaDiaria { get; set; }

        public virtual double CantidadDeLoteEconomico
        {
            get
            {
                double Operacion = Math.Sqrt((double)((2 * DemandaXunidadTiempo * CostoPorColocarOrden) / CostoPorAlmacenar));
                return Operacion;
            }
        }

        public decimal CostoAnualXOrdenar
        {
            get { return ((decimal)CantidadDeLoteEconomico / 2) * CostoPorAlmacenar; }
        }
        public virtual decimal CostoAnualXAlmacenar
        {
            get { return (DemandaXunidadTiempo / (decimal)CantidadDeLoteEconomico) * CostoPorColocarOrden; }
        }
        public virtual decimal CostoTotalXUnidadTiempo
        {
            get { return CostoAnualXAlmacenar + CostoAnualXOrdenar; }
        }
        public double DuracionDelCiclo
        {
            get
            {

                if (DiasLaboradosAño > 0)
                {
                    double d = ((CantidadDeLoteEconomico / DemandaXunidadTiempo) * DiasLaboradosAño);
                    return d;

                }
                return (CantidadDeLoteEconomico / DemandaXunidadTiempo);
            }
        }

        public double CantidadPromInventario
        {
            get { return (ushort)(CantidadDeLoteEconomico / 2); }
        }

        public double TiempoEfectivo
        {
            get
            {  //L siempre esta en dias
                if (DiasLaboradosAño == 0)
                {
                    return 0;
                }
                if (TiempoDeEntrega > DuracionDelCiclo)
                {
                    int n = (int)(TiempoDeEntrega / DuracionDelCiclo);
                    return TiempoDeEntrega - (n * DuracionDelCiclo);
                }
                return TiempoDeEntrega;
            }
        }

        public double PuntoDeReorden
        {

            get
            {
                if (DemandaDiaria == 0)
                {
                    return 0;
                }
                return (TiempoEfectivo * DemandaDiaria);
            }
        }

    }
}
