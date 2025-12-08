using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmProyectoIO.Properties
{
//Cambiar Nombres de clases 
    internal class UnaFilasMuchosServidores : UnaFilaUnServidor
    {
        //Cambios Pendientes:
        //Servidores deberia ser Int por que no puede haber 1.5 Servidores
       
        //Propiedades
        
        //Datos para los calculos
        public float Servidores { get; set; } = 0; //No hay referencias de esta propiedades en ningun metodo

        //Metodos -  Calculos
        //Los metodos deden tener un nombre mas intuitivo para el equipo, aun que por formulas sabes que es Ls, Ws, etc.
        //Para los que trabajaran en el diseño se le haria mas facil tener un texto mas intuitivo para mandar la informacion correctamente al formulario
        
        public override float Ls(float M, float m, float Y) //Las formulas creo que estan repetidas pero que esten aqui esta correcto, creo
        {                                                   //Mañana checar formulas
            float ls = 0;
            ls = (Y * m * (float)(Math.Pow((Y / m), M))) / (Factorial(M - 1) * (float)(Math.Pow(((M * m) - Y), 2))) * Po(M, m, Y) + (Y / m);
            return ls;
        }
        public override float Ws(float M, float m, float Y)
        {
            float ws = 0;
            ws = m * (float)(Math.Pow((Y / m), M)) / (Factorial(M - 1) * (float)(Math.Pow((M * m - Y), 2))) * Po(M, m, Y) + (1 / m);
            return ws * 60; //Minutos
        }
        public override float Lq(float M, float m, float Y)
        {
            float lq = 0;
            lq = Ls(M, m, Y) - (Y / m);
            return lq;
        }
        public override float Wq(float M, float m, float Y)
        {
            float wq = 0;
            wq = (Ws(M, m, Y) / 60) - (1 / m);
            return wq * 60; //Minutos
        }
        //Esta bastante bien el trabajo solo que mañana hare los cambios 
        //que tengo comentados porque no tengo computadora, y si los cambio asi nomas podria generar errores en el programa
    }
}
