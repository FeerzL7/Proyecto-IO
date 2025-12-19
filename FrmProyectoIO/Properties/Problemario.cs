using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
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
            if(tasallegada > tasaservicio) { 
                throw new ArgumentException("Los datos son incongruentes. \nLa tasa de llegada no puede ser mayor a la tasa de servicio");
            }
            //Que no se repita el titulo
            if (Reactivo.Values.SelectMany(X => X).Any(x => string.Equals(x.Titulo.Trim(), titulo.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("No puede repetir el título del ejercicio");
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

            if (tasallegada > (tasaservicio* servidores))
            {
                throw new ArgumentException("Los datos son incongruentes. \nLa tasa de llegada no puede ser mayor a la tasa de servicio");
            }
            //Que no se repita el titulo
            if (Reactivo.Values.SelectMany(x => x).Any(x => string.Equals(x.Titulo.Trim(), titulo.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("No puede repetir el título del ejercicio");
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
            if(!Reactivo[dificultad].Any(x => x.Titulo == problema.Titulo)) {
                throw new ArgumentException(" No existe un reactivo con ese titulo");
            }

            //busca el problema que seleccionaron
            var ProblemaModificar = Reactivo[dificultad].FirstOrDefault(x => x.Titulo == problema.Titulo);
            if (ProblemaModificar != null) //si este no es nulo actualiza los valores 
            {
                //Cambia todo menos el titulo - porque eso es como nuestra SKU
                ProblemaModificar.Enunciado = problema.Enunciado;
                ProblemaModificar.TasaLlegada = problema.TasaLlegada;
                ProblemaModificar.TasaServicio = problema.TasaServicio;

            }
            //Por si se cambia de dificulad
            
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
            ModeloMultiplesServidores? ProblemaModificar = Reactivo.Values.SelectMany(x => x).FirstOrDefault(x => x.Titulo == problema.Titulo) as ModeloMultiplesServidores;
            if (ProblemaModificar != null)
            {
                ProblemaModificar.Titulo = problema.Titulo;
                ProblemaModificar.Enunciado = problema.Enunciado;
                ProblemaModificar.TasaLlegada = problema.TasaLlegada;
                ProblemaModificar.TasaServicio = problema.TasaServicio;
                ProblemaModificar.Servidores = problema.Servidores;

            }
            Reactivo[dificultad].Add(ProblemaModificar);
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

        public void GuardarDatos()
        {
            var opt = new JsonSerializerOptions() { WriteIndented = true };

            string json = JsonSerializer.Serialize(Reactivo, opt);
            File.WriteAllText("Lista de problemas.json", json);

        }


        public void CargarDatos()
        {
            if (File.Exists("Lista de problemas.json"))
            {
                string json = File.ReadAllText("Lista de problemas.json");

                Reactivo = JsonSerializer.Deserialize<Dictionary<Dificultad, List<ModeloUnSoloServidor>>>(json) ?? new Dictionary<Dificultad, List<ModeloUnSoloServidor>>();
                SeActualizoLista?.Invoke();
            }
        }
    }
}

