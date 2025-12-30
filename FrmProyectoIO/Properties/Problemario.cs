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
        public Dictionary<Dificultad, List<ModeloUnSoloServidor>> ReactivosMM1 { get; set; } = new();
        public Dictionary<Dificultad, List<ModeloMultiplesServidores>> ReactivosMMS { get; set; } = new();

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
            if (!ReactivosMM1.ContainsKey(dificultad))
            {
                ReactivosMM1.Add(dificultad, new List<ModeloUnSoloServidor>());
            }
            if (tasallegada > tasaservicio) {
                throw new ArgumentException("Los datos son incongruentes. \nLa tasa de llegada no puede ser mayor a la tasa de servicio");
            }
            //Que no se repita el titulo
            if (ReactivosMM1.Values.SelectMany(X => X).Any(x => string.Equals(x.Titulo.Trim(), titulo.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("No puede repetir el título del ejercicio");
            }


            ReactivosMM1[dificultad].Add(new ModeloUnSoloServidor
            {
                Titulo = titulo,
                Enunciado = enunciado,
                TasaLlegada = tasallegada,
                TasaServicio = tasaservicio,
                


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

            if (!ReactivosMMS.ContainsKey(dificultad))//si no existe la llave todavia la crea
            {
                ReactivosMMS.Add(dificultad, new List<ModeloMultiplesServidores>());
            }

            if (tasallegada > (tasaservicio * servidores))
            {
                throw new ArgumentException("Los datos son incongruentes. \nLa tasa de llegada no puede ser mayor a la tasa de servicio");
            }
            //Que no se repita el titulo
            if (ReactivosMMS.Values.SelectMany(x => x).Any(x => string.Equals(x.Titulo.Trim(), titulo.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("No puede repetir el título del ejercicio");
            }

            ReactivosMMS[dificultad].Add(new ModeloMultiplesServidores
            {
                Titulo = titulo,
                Enunciado = enunciado,
                TasaLlegada = tasallegada,
                TasaServicio = tasaservicio,
                Servidores = servidores,
                NivelDificultad = dificultad,
                
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
            if (!ReactivosMM1[dificultad].Any(x => x.Titulo == problema.Titulo)) {
                throw new ArgumentException(" No existe un reactivo con ese titulo");
            }

            //busca el problema que seleccionaron
            var ProblemaModificar = ReactivosMM1[dificultad].FirstOrDefault(x => x.Titulo == problema.Titulo);
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
            ModeloMultiplesServidores? ProblemaModificar = ReactivosMMS.Values.SelectMany(x => x).FirstOrDefault(x => x.Titulo == problema.Titulo) as ModeloMultiplesServidores;
            if (ProblemaModificar != null)
            {
                ProblemaModificar.Titulo = problema.Titulo;
                ProblemaModificar.Enunciado = problema.Enunciado;
                ProblemaModificar.TasaLlegada = problema.TasaLlegada;
                ProblemaModificar.TasaServicio = problema.TasaServicio;
                ProblemaModificar.Servidores = problema.Servidores;

            }
            ReactivosMMS[dificultad].Add(ProblemaModificar);
            SeActualizoLista?.Invoke();
        }


        public void Eliminar(ModeloUnSoloServidor problema)
        {
            if (problema == null)
            {
                throw new ArgumentException("no se puede eliminar un problema inexistente");
            }

            ReactivosMM1[problema.NivelDificultad].Remove(problema);
            if (ReactivosMM1[problema.NivelDificultad].Count == 0)
            {
                ReactivosMM1.Remove(problema.NivelDificultad);
            }
            SeActualizoLista?.Invoke();
        }
        public void Eliminar(ModeloMultiplesServidores problema)
        {
            if (problema == null)
            {
                throw new ArgumentException("no se puede eliminar un problema inexistente");
            }

            ReactivosMMS[problema.NivelDificultad].Remove(problema);
            if (ReactivosMMS[problema.NivelDificultad].Count == 0)
            {
                ReactivosMMS.Remove(problema.NivelDificultad);
            }
            SeActualizoLista?.Invoke();

        }
        public List<ModeloUnSoloServidor> GetReactivosMM1ByDificultad(Dificultad dificultad) 
        {
            return ReactivosMM1[dificultad].ToList();
        }
        public List<ModeloMultiplesServidores> GetReactivosMMSByDificultad(Dificultad dificultad)
        {
            return ReactivosMMS[dificultad].ToList();
        }

       
        public void GuardarDatos()
        {
            var opt = new JsonSerializerOptions() { WriteIndented = true };

            string json = JsonSerializer.Serialize(ReactivosMM1, opt);
            File.WriteAllText("Lista de problemasMM1.json", json);
            string json2 = JsonSerializer.Serialize(ReactivosMMS, opt);
            File.WriteAllText("Lista de ProblemasMMS.json", json2);

        }
      
        public void CargarDatos()
        {
            if (File.Exists("Lista de problemasMM1.json"))
            {
                string json = File.ReadAllText("Lista de problemasMM1.json");

                ReactivosMM1 = JsonSerializer.Deserialize<Dictionary<Dificultad, List<ModeloUnSoloServidor>>>(json) ?? new Dictionary<Dificultad, List<ModeloUnSoloServidor>>();
                
            }
            if (File.Exists("Lista de problemasMMS.json"))
            {
                string json = File.ReadAllText("Lista de problemasMMS.json");

                ReactivosMMS = JsonSerializer.Deserialize<Dictionary<Dificultad, List<ModeloMultiplesServidores>>>(json) ?? new Dictionary<Dificultad, List<ModeloMultiplesServidores>>();
                
            }
            SeActualizoLista?.Invoke();
        }
    }
}

