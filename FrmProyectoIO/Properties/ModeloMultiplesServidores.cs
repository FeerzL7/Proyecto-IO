using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace FrmProyectoIO.Properties
{

    public class ModeloMultiplesServidores : ModeloUnSoloServidor
    {
        //Propiedades

        //Datos para los calculos
        public int Servidores { get; set; } = 0; 

        public double ProbabilidadSistemaVacio()
        {
            double suma1 = 0;

            for (int n = 0; n < Servidores; n++)
            {
                suma1 += Math.Pow(UtilizacionPromedioSistema, n) / Factorial(n);
            }
            double suma2 = Math.Pow(UtilizacionPromedioSistema, Servidores) / Factorial(Servidores) *
                (Servidores * TasaServicio) / (Servidores * TasaServicio - TasaLlegada);

            return 1 / (suma1 + suma2);

        }

        

        // ------------------ PROMEDIO DE CLIENTES EN EL SISTEMA (Ls) ------------------ (double)
        
        public override double NumeroPromedioEnServicio
        {
            get
            {
                
                double primera = (TasaLlegada * TasaServicio * Math.Pow(UtilizacionPromedioSistema, Servidores)) /
                    (Factorial(Servidores - 1) * Math.Pow(Servidores * TasaServicio - TasaLlegada, 2));

                return (primera * ProbabilidadSistemaVacio()) + UtilizacionPromedioSistema;
            }
        }   



        // ------------------ TIEMPO PROMEDIO EN EL SISTEMA (Ws) ------------------ (double)

        public override double TiempoPromedioEnServicio
        {
            get
            {


                double primera = (TasaServicio * Math.Pow(UtilizacionPromedioSistema, Servidores)) / (Factorial(Servidores - 1) * Math.Pow(Servidores * TasaServicio - TasaLlegada, 2));
                return (primera * ProbabilidadSistemaVacio()) + (1 / TasaServicio);
            }
        }

        // ------------------ CLIENTES PROMEDIO EN LA Fila (Lq) ------------------ (double)
        public override double NumeroPromedioEnFila
        {
            get
            {

                return NumeroPromedioEnServicio - UtilizacionPromedioSistema;
            }
        }

        // ------------------ TIEMPO PROMEDIO EN LA Fila (Wq) ------------------

        public override double TiempoPromedioEnFila
        {
            get
            {


                return TiempoPromedioEnServicio - (1 / TasaServicio);
            }
        }
        

        public int Factorial(int num)
        {
            if (num < 0)
                throw new ArgumentException("Ingresa números positivos");

            int n = 1;

            for (int i = 1; i <= num; i++)
            {
                n *= i;
            }
            return n;
        }

    }
}
