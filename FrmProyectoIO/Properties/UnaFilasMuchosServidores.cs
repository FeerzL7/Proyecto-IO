using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmProyectoIO.Properties
{
    internal class UnaFilasMuchosServidores : UnaFilaUnServidor
    {
        public float Servidores { get; set; } = 0;
        public override float Ls(float M, float m, float Y)
        {
            float ls = 0;
            ls = (Y * m * (float)(Math.Pow((Y / m), M))) / (Factorial(M - 1) * (float)(Math.Pow(((M * m) - Y), 2))) * Po(M, m, Y) + (Y / m);
            return ls;
        }
        public override float Ws(float M, float m, float Y)
        {
            float ws = 0;
            ws = m * (float)(Math.Pow((Y / m), M)) / (Factorial(M - 1) * (float)(Math.Pow((M * m - Y), 2))) * Po(M, m, Y) + (1 / m);
            return ws * 60;
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
            return wq * 60;
        }
    }
}
