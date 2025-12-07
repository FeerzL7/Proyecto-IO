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
            if (string.IsNullOrEmpty(titulo) || titulo.Length > 50) { throw new ArgumentException("Ingrese un titulo valido que no exceda los 50 caracteres"); }
            if (string.IsNullOrEmpty(enunciado) || enunciado.Length > 250) { throw new ArgumentException("Ingrese el enunciado valido que no exceda los 250 caracteres"); }
            if (m <= 0) { throw new ArgumentException("la tasa de servicio debe ser mayor a 0"); }
            if (y <= 0) { throw new ArgumentException("la tasa de llegada debe ser mayor a 0"); }
            UnaFilaUnServidor problema = new UnaFilaUnServidor()
            {
                Titulo = titulo,
                Enunciado = enunciado,
                TasaServicio = (byte)m,
                TasaLlegada = y,
                NivelDificultad = dificil
            };
            problemas[dificil].Add(problema);
        }
        public void AgregarProblema(string titulo, string enunciado, float m, float M, float y, Dificultad dificil)
        {
            if (string.IsNullOrEmpty(titulo) || titulo.Length > 50) { throw new ArgumentException("Ingrese un titulo valido que no exceda los 50 caracteres"); }
            if (string.IsNullOrEmpty(enunciado) || enunciado.Length > 250) { throw new ArgumentException("Ingrese el enunciado valido que no exceda los 250 caracteres"); }
            if (m <= 0) { throw new ArgumentException("La tasa de servicio debe ser mayor a 0"); }
            if (y <= 0) { throw new ArgumentException("La tasa de llegada debe ser mayor a 0"); }
            if (M <= 0) { throw new ArgumentException("El numero de servidores debe ser mayor a 0"); }
            UnaFilaUnServidor problema = new UnaFilasMuchosServidores()
            {
                Titulo = titulo,
                Enunciado = enunciado,
                TasaServicio = (byte)m,
                TasaLlegada = y,
                Servidores = M,
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
            if (string.IsNullOrEmpty(titulo) || titulo.Length > 50) { throw new ArgumentException("Ingrese un titulo valido que no exceda los 50 caracteres"); }
            if (string.IsNullOrEmpty(enunciado) || enunciado.Length > 250) { throw new ArgumentException("Ingrese el enunciado valido que no exceda los 250 caracteres"); }
            if (m <= 0) { throw new ArgumentException("la tasa de servicio debe ser mayor a 0"); }
            if (y <= 0) { throw new ArgumentException("la tasa de llegada debe ser mayor a 0"); }
            problema.Titulo = titulo;
            problema.Enunciado = enunciado;
            problema.TasaServicio = (byte)m;
            problema.TasaLlegada = y;
        }
        public void Modificar(UnaFilasMuchosServidores problema, string titulo, string enunciado, float m, float y, float M)
        {
            if (problema == null) { throw new ArgumentException("no se puede modificar un problema nulo"); }
            if (string.IsNullOrEmpty(titulo) || titulo.Length > 50) { throw new ArgumentException("Ingrese un titulo valido que no exceda los 50 caracteres"); }
            if (string.IsNullOrEmpty(enunciado) ||  enunciado.Length > 250) { throw new ArgumentException("Ingrese el enunciado valido que no exceda los 250 caracteres"); }
            if (m <= 0) { throw new ArgumentException("la tasa de servicio debe ser mayor a 0"); }
            if (y <= 0) { throw new ArgumentException("la tasa de llegada debe ser mayor a 0"); }
            if (M <= 0) { throw new ArgumentException("el numero de servidores debe ser mayor a 0"); }
            problema.Titulo = titulo;
            problema.Enunciado = enunciado;
            problema.TasaServicio = (byte)m;
            problema.TasaLlegada = y;
            problema.Servidores = M;
        }
    }
}
