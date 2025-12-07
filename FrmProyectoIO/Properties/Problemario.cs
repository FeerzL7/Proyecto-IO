using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FrmProyectoIO.Properties
{
    internal class Problemario
    {
        Dictionary<Dificultad, List<UnaFilaUnServidor>> problemas = new Dictionary<Dificultad, List<UnaFilaUnServidor>>();

        public void AgregarProblema(string titulo, string enunciado, float m, float y, Dificultad dificil)
        {
            if (string.IsNullOrEmpty(titulo) && titulo.Length > 50) { throw new ArgumentException("porfavor pon un titulo o excedes 50 letras"); }
            if (string.IsNullOrEmpty(enunciado) && enunciado.Length > 250) { throw new ArgumentException("porfavor pon un enunciado o excedes 250 letras"); }
            if (m <= 0) { throw new ArgumentException("la tasa de servicio debe ser mayor a 0"); }
            if (y <= 0) { throw new ArgumentException("la tasa de llegada debe ser mayor a 0"); }
            UnaFilaUnServidor problema = new UnaFilaUnServidor()
            {
                titulo = titulo,
                Enunciado = enunciado,
                m = (byte)m,
                Y = y,
                NivelDificultad = dificil
            };
            problemas[dificil].Add(problema);
        }
        public void AgregarProblema(string titulo, string enunciado, float m, float M, float y, Dificultad dificil)
        {
            if (string.IsNullOrEmpty(titulo) && titulo.Length > 50) { throw new ArgumentException("porfavor pon un titulo o excedes 50 letras"); }
            if (string.IsNullOrEmpty(enunciado) && enunciado.Length > 250) { throw new ArgumentException("porfavor pon un enunciado o excedes 250 letras"); }
            if (m <= 0) { throw new ArgumentException("la tasa de servicio debe ser mayor a 0"); }
            if (y <= 0) { throw new ArgumentException("la tasa de llegada debe ser mayor a 0"); }
            if (M <= 0) { throw new ArgumentException("el numero de servidores debe ser mayor a 0"); }
            UnaFilaUnServidor problema = new UnaFilasMuchosServidores()
            {
                titulo = titulo,
                Enunciado = enunciado,
                m = (byte)m,
                Y = y,
                M = M,
                NivelDificultad = dificil
            };
            problemas[dificil].Add(problema);
        }
        public void Eliminar(UnaFilaUnServidor problema)
        {
            if (problema == null) { throw new ArgumentException("no se puede eliminar un problema nulo"); }
            problemas[problema.NivelDificultad].Remove(problema);
        }
        public void Modificar(UnaFilaUnServidor problema, string titulo, string enunciado, float m, float y)
        {
            if (problema == null) { throw new ArgumentException("no se puede modificar un problema nulo"); }
            if (string.IsNullOrEmpty(titulo) && titulo.Length > 50) { throw new ArgumentException("porfavor pon un titulo o excedes 50 letras"); }
            if (string.IsNullOrEmpty(enunciado) && enunciado.Length > 250) { throw new ArgumentException("porfavor pon un enunciado o excedes 250 letras"); }
            if (m <= 0) { throw new ArgumentException("la tasa de servicio debe ser mayor a 0"); }
            if (y <= 0) { throw new ArgumentException("la tasa de llegada debe ser mayor a 0"); }
            problema.titulo = titulo;
            problema.Enunciado = enunciado;
            problema.m = (byte)m;
            problema.Y = y;
        }
        public void Modificar(UnaFilasMuchosServidores problema, string titulo, string enunciado, float m, float y, float M)
        {
            if (problema == null) { throw new ArgumentException("no se puede modificar un problema nulo"); }
            if (string.IsNullOrEmpty(titulo) && titulo.Length > 50) { throw new ArgumentException("porfavor pon un titulo o excedes 50 letras"); }
            if (string.IsNullOrEmpty(enunciado) && enunciado.Length > 250) { throw new ArgumentException("porfavor pon un enunciado o excedes 250 letras"); }
            if (m <= 0) { throw new ArgumentException("la tasa de servicio debe ser mayor a 0"); }
            if (y <= 0) { throw new ArgumentException("la tasa de llegada debe ser mayor a 0"); }
            if (M <= 0) { throw new ArgumentException("el numero de servidores debe ser mayor a 0"); }
            problema.titulo = titulo;
            problema.Enunciado = enunciado;
            problema.m = (byte)m;
            problema.Y = y;
            problema.M = M;
        }
    }
}
