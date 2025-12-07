using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmProyectoIO.Properties
{
    public enum Dificultad
    {
        Facil,
        Medio,
        Dificil
    }
    internal class UnaFilaUnServidor
    {
        public Dificultad NivelDificultad { get; set; } = Dificultad.Facil;
        public string titulo { get; set; } = "Sin Titulo";
        public string Enunciado { get; set; } = "Sin Enunciado";
        public DateOnly FechaCreacion { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public byte m { get; set; } = 0;  
        public float Y { get; set; } = 0;
        public float Po(float M, float m, float Y)
        {
            float po = 1;//
            if ((M * m) > Y)
            {
                for (int N = 1; N <= M - 1; N++)
                {
                    po += (1 / Factorial(N)) * (float)Math.Pow(Y / m, N);
                }
                po += (1 / Factorial(M)) * (float)(Math.Pow(Y / m, M)) * ((M * m) / (M * m - Y));
                po = 1 / po;
            }
            return po;
        }
        public virtual float Ls(float M, float m, float Y)
        {
            float ls = 0;
            ls = (Y * m * (float)(Math.Pow((Y / m), M))) / (Factorial(M - 1) * (float)(Math.Pow(((M * m) - Y), 2))) * Po(M, m, Y) + (Y / m);
            return ls;
        }
        public virtual float Ws(float M, float m, float Y)
        {
            float ws = 0;
            ws = m * (float)(Math.Pow((Y / m), M)) / (Factorial(M - 1) * (float)(Math.Pow((M * m - Y), 2))) * Po(M, m, Y) + (1 / m);
            return ws * 60;
        }
        public virtual float Lq(float M, float m, float Y)
        {
            float lq = 0;
            lq = Ls(M, m, Y) - (Y / m);
            return lq;
        }
        public virtual float Wq(float M, float m, float Y)
        {
            float wq = 0;
            wq = (Ws(M, m, Y) / 60) - (1 / m);
            return wq * 60;
        }
        public float Factorial(float Num)
        {
            if (Num == 1 || Num == 0) return 1;
            return Num * Factorial(Num - 1);
        }

    }
}
