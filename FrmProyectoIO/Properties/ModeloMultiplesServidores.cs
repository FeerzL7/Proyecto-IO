using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmProyectoIO.Properties
{

    public class ModeloMultiplesServidores : ModeloUnSoloServidor
    {
        //Cambios Pendientes:
        //1. Servidores deberia ser Int por que no puede haber 1.5 Servidores.
        //2. Checar los tipos de datos  y nombre de cada propiedad.
        //3. Cambiar los metodos por propiedades.
        //4. Checar si hay validaciones, etc, si no, usar campos para validar desde del VALUE (Para no validar una y otra vez por cada propiedad(Solo seria necesario una vez)).



        //Propiedades

        //Datos para los calculos
        public int Servidores { get; set; } = 0; //No hay referencias de esta propiedades en ningun metodo

        public double ProbabilidadSistemaVacio()
        {
            if (!((Servidores * TasaServicio) > TasaLlegada))
                throw new ArgumentException("Parame");

            double suma1 = 0;

            for (int n = 0; n < Servidores; n++)
            {
                suma1 += Math.Pow(UtilizacionPromedioSistema, n) / Factorial(n);
            }
            double suma2 = Math.Pow(UtilizacionPromedioSistema, Servidores) / Factorial(Servidores) * 
                (Servidores*TasaServicio)/ (Servidores * TasaServicio - TasaLlegada);

            return 1/(suma1 + suma2);

        }

        //Propiedades* para calculos
        //Los metodos deden tener un nombre mas intuitivo para el equipo, aun que por formulas sabes que es Ls, Ws, etc.
        //Para los que trabajaran en el diseño se le haria mas facil tener un texto mas intuitivo para mandar la informacion correctamente al formulario

        // ------------------ PROMEDIO DE CLIENTES EN EL SISTEMA (Ls) ------------------ (double)
        //Las formulas creo que estan repetidas pero que esten aqui esta correcto, creo
        //Mañana checar formulas - NumeroPromedioEnSistema
        public override double NumeroPromedioEnServicio
        {
            get
            {
                double primera = (TasaLlegada * TasaServicio * Math.Pow(UtilizacionPromedioSistema, Servidores)) /
                    (Factorial(Servidores - 1) * Math.Pow(Servidores * TasaServicio - TasaLlegada, 2));

                return (primera * ProbabilidadClientesSistema) + UtilizacionPromedioSistema;
            }
        }   //double



        // ------------------ TIEMPO PROMEDIO EN EL SISTEMA (Ws) ------------------ (double)

        public override double TiempoPromedioEnServicio
        {
            get
            {
                if (TiempoPromedioEnFila > 0)
                {
                    return TiempoPromedioEnFila / TasaLlegada;
                }

                double primera = (TasaServicio * Math.Pow(UtilizacionPromedioSistema, Servidores)) / (Factorial(Servidores - 1) * Math.Pow(Servidores * TasaServicio - TasaLlegada, 2));
                return (primera * ProbabilidadClientesSistema) + (1 / TasaServicio);
            }
        }

        // ------------------ CLIENTES PROMEDIO EN LA Fila (Lq) ------------------ (double)
        public override double NumeroPromedioEnFila
        {
            get
            {
                return TiempoPromedioEnServicio - UtilizacionPromedioSistema;
            }
        }

        // ------------------ TIEMPO PROMEDIO EN LA Fila (Wq) ------------------

        public override double TiempoPromedioEnFila
        {
            get
            {
                if (NumeroPromedioEnFila > 0)
                {
                    return NumeroPromedioEnFila / TasaLlegada;
                }

                return TiempoPromedioEnServicio - (1 / TasaServicio);
            }
        }
        //Esta bastante bien el trabajo solo que mañana hare los cambios 
        //que tengo comentados porque no tengo computadora, y si los cambio asi nomas podria generar errores en el programa

        public int Factorial(int num)
        {
            int n = 1;

            for (int i = 1; i <= num; i++)
            {
                n *= i;
            }
            return n;
        }

    }
}
