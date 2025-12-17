using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FrmProyectoIO.Properties
{
    public class Problemario
    {
        public Dictionary<Dificultad, List<ModeloUnSoloServidor>> Reactivo { get; set; } = new();

        public delegate void ProblemarioHandler();
        public event ProblemarioHandler? SeActualizoLista;

        public void AgregarProblema(string titulo, string enunciado, double tasallegada, double tasaservicio, Dificultad dificultad)
        {
            //Validaciones de entrada
            if (string.IsNullOrWhiteSpace(titulo))
            {
                throw new ArgumentException("Ingrese el titulo del problema");
            }
            if (string.IsNullOrWhiteSpace(enunciado))
            {
                throw new ArgumentException("Ingrese el enunciado del problema");
            }
            if (tasallegada <= 0)
            {
                throw new ArgumentException("la tasa de llegada debe ser mayor que 0");
            }
            if (tasaservicio <= 0)
            {
                throw new ArgumentException("la tasa de servicio debe ser mayor que 0");
            }

            if (!Reactivo.ContainsKey(dificultad))
            {
                Reactivo.Add(dificultad, new List<ModeloUnSoloServidor>());
            }
            //Que no se repita el titulo
            if (Reactivo[dificultad].Any(x => x.Titulo.ToUpper() == titulo.ToUpper()))
            {
                throw new ArgumentException("");
            }

            Reactivo[dificultad].Add(new ModeloUnSoloServidor
            {
                Titulo = titulo,
                Enunciado = enunciado,
                TasaLlegada = tasallegada,
                TasaServicio = tasaservicio
            });
            SeActualizoLista?.Invoke();

        }
        public void AgregarProblema(string titulo, string enunciado, double tasallegada, double tasaservicio, int servidores, Dificultad dificultad)
        {
            //Validaciones de entrada
            if (string.IsNullOrWhiteSpace(titulo))
            {
                throw new ArgumentException("Ingrese el titulo del problema");
            }
            if (string.IsNullOrWhiteSpace(enunciado))
            {
                throw new ArgumentException("Ingrese el enunciado del problema");
            }
            if (tasallegada <= 0)
            {
                throw new ArgumentException("la tasa de llegada debe ser mayor que 0");
            }
            if (tasaservicio <= 0)
            {
                throw new ArgumentException("la tasa de servicio debe ser mayor que 0");
            }
            if (servidores <= 0)
            {
                throw new ArgumentException("el numero de servidores debe ser mayor que 0");
            }

            if (!Reactivo.ContainsKey(dificultad))//si no existe la llave todavia la crea
            {
                Reactivo.Add(dificultad, new List<ModeloUnSoloServidor>());
            }

            if (Reactivo[dificultad].Any(x => x.Titulo.ToUpper() == titulo.ToUpper())) //si el problema a agregar ya existe
            {
                throw new ArgumentException("");
            }
            Reactivo[dificultad].Add(new ModeloMultiplesServidores
            {
                Titulo = titulo,
                Enunciado = enunciado,
                TasaLlegada = tasallegada,
                TasaServicio = tasaservicio,
                Servidores = servidores,
                NivelDificultad = dificultad
            });
            SeActualizoLista?.Invoke();

        }


        public void ModificarProblema(ModeloUnSoloServidor problema, Dificultad dificultad)
        {
            //Validacion
            if (problema == null)
            {
                throw new ArgumentException("Seleccione que reactivo desea modificar");
            }
            if (string.IsNullOrWhiteSpace(problema.Titulo))
            {
                throw new ArgumentException("Ingrese el titulo del problema");
            }
            if (string.IsNullOrWhiteSpace(problema.Enunciado))
            {
                throw new ArgumentException("Ingrese el enunciado del problema");
            }
            if (problema.TasaLlegada <= 0 || problema.TasaServicio <= 0)
            {
                throw new ArgumentException("la tasa de llegada y la tasa de servicio debe ser mayor que 0");
            }

            //busca el problema que seleccionaron
            var ProblemaModificar = Reactivo[dificultad].FirstOrDefault(x => x.Titulo == problema.Titulo);
            if (ProblemaModificar != null) //si este no es nulo actualiza los valores 
            {
                ProblemaModificar.Titulo = problema.Titulo;
                ProblemaModificar.Enunciado = problema.Enunciado;
                ProblemaModificar.TasaLlegada = problema.TasaLlegada;
                ProblemaModificar.TasaServicio = problema.TasaServicio;

            }
            SeActualizoLista?.Invoke();
        }


        public void ModificarProblema(ModeloMultiplesServidores problema, Dificultad dificultad)
        {
            //Validacion
            if (problema == null)
            {
                throw new ArgumentException("Seleccione que reactivo desea modificar");
            }
            if (string.IsNullOrWhiteSpace(problema.Titulo))
            {
                throw new ArgumentException("Ingrese el titulo del problema");
            }
            if (string.IsNullOrWhiteSpace(problema.Enunciado))
            {
                throw new ArgumentException("Ingrese el enunciado del problema");
            }
            if (problema.TasaLlegada <= 0 || problema.TasaServicio <= 0)
            {
                throw new ArgumentException("la tasa de llegada y la tasa de servicio debe ser mayor que 0");
            }

            //guardalo como un ModeloMultiplesServidores
            ModeloMultiplesServidores? ProblemaModificar = Reactivo[dificultad].FirstOrDefault(x => x.Titulo == problema.Titulo) as ModeloMultiplesServidores;
            if (ProblemaModificar != null)
            {
                ProblemaModificar.Titulo = problema.Titulo;
                ProblemaModificar.Enunciado = problema.Enunciado;
                ProblemaModificar.TasaLlegada = problema.TasaLlegada;
                ProblemaModificar.TasaServicio = problema.TasaServicio;
                ProblemaModificar.Servidores = problema.Servidores;

            }
            SeActualizoLista?.Invoke();
        }


        public void Eliminar(ModeloUnSoloServidor problema)
        {
            if (problema == null)
            {
                throw new ArgumentException("no se puede eliminar un problema inexistente");
            }

            Reactivo[problema.NivelDificultad].Remove(problema);
            SeActualizoLista?.Invoke();
        }
        public void Eliminar(ModeloMultiplesServidores problema)
        {
            if (problema == null)
            {
                throw new ArgumentException("no se puede eliminar un problema inexistente");
            }

            Reactivo[problema.NivelDificultad].Remove(problema);
            SeActualizoLista?.Invoke();
        }

    }
}

