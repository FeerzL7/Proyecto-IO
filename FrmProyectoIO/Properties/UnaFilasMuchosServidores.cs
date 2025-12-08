using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmProyectoIO.Properties
{
    //Nombres de Clases
    //ModeloMMS : ModeloMM1 o ModeloMultiplesServidores : ModeloUNSoloServidor
    internal class UnaFilasMuchosServidores : UnaFilaUnServidor
    {
        //Cambios Pendientes:
        //Servidores deberia ser Int por que no puede haber 1.5 Servidores.
        //Checar los tipos de datos  y nombre de cada propiedad, metodo, etc.
        //Cambiar Nombres de clases.
        //Cambiar las referencias de los parametros (Eliminarlos) y agregar las referencias de las propiedades a los metodos.
        //Checar si hay validaciones, etc, si no, usar campos para validar desde del VALUE (Para no validar una y otra vez por cada metodo(Solo seria necario una vez)).
        
        
       
        //Propiedades
        
        //Datos para los calculos
        public float Servidores { get; set; } = 0; //No hay referencias de esta propiedades en ningun metodo

        //Metodos -  Calculos
        //Los metodos deden tener un nombre mas intuitivo para el equipo, aun que por formulas sabes que es Ls, Ws, etc.
        //Para los que trabajaran en el diseño se le haria mas facil tener un texto mas intuitivo para mandar la informacion correctamente al formulario

         // ------------------ PROMEDIO DE CLIENTES EN EL SISTEMA (Ls) ------------------ (double)
        public override float Ls(float M, float m, float Y) //Las formulas creo que estan repetidas pero que esten aqui esta correcto, creo
        {                                                   //Mañana checar formulas
            float ls = 0;
            ls = (Y * m * (float)(Math.Pow((Y / m), M))) / (Factorial(M - 1) * (float)(Math.Pow(((M * m) - Y), 2))) * Po(M, m, Y) + (Y / m);
            return ls;
        }
        // ------------------ TIEMPO PROMEDIO EN EL SISTEMA (Ws) ------------------ (double)
        public override float Ws(float M, float m, float Y) // TiempoPromedioEnSistema
        {
            float ws = 0;
            ws = m * (float)(Math.Pow((Y / m), M)) / (Factorial(M - 1) * (float)(Math.Pow((M * m - Y), 2))) * Po(M, m, Y) + (1 / m);
            return ws * 60; //Minutos
        }

         // ------------------ CLIENTES PROMEDIO EN LA COLA (Lq) ------------------ (double)
        public override float Lq(float M, float m, float Y) //NumeroPromedioCola
        {
          //double
            float lq = 0;
            //* Llamo al metodo
            lq = Ls(M, m, Y) - (Y / m);
            return lq;
        }

        // ------------------ TIEMPO PROMEDIO EN LA COLA (Wq) ------------------
        public override float Wq(float M, float m, float Y)  //TiempoPromedioEnCola
        {
           //double, es un proceso matematico
            float wq = 0;
               //* Llamo el metodo/60  -    1 / Tasa de sercico
            wq = (Ws(M, m, Y) / 60) - (1 / m);
            return wq * 60; //Minutos
        }
        //Esta bastante bien el trabajo solo que mañana hare los cambios 
        //que tengo comentados porque no tengo computadora, y si los cambio asi nomas podria generar errores en el programa
    }
}
