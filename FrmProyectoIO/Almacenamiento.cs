using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FrmProyectoIO
{
    public class Almacenamiento
    {
        public Dictionary<Dificultad, List<Inventario>> Ejercicios { get; set; } = new();
        public delegate void Profesor();
        public event Profesor AlCambiar;


        public void Registrar(Dificultad dificultad, Inventario inventario)
        {
            if (!Enum.IsDefined(typeof(Dificultad), dificultad))
                throw new ArgumentException("Seleccionó algún dato no compatible.");
            if (dificultad != Dificultad.Facil)
                throw new ArgumentException("Este es un problema fácil.");
            if (inventario.D <= 0)
                throw new ArgumentException("La demanda anual debe ser mayor a cero.");
            if (inventario.Co <= 0)
                throw new ArgumentException("El coto por ordenar debe ser mayor a cero.");
            if (inventario.Ch <= 0)
                throw new ArgumentException("El costo por almacenar debe ser mayor a cero.");
            if (inventario.L > 0 && inventario.d <= 0)
                throw new ArgumentException("Si el tiempo de entrega es mayor a cero debe \n proporcionarnos la demanda diaria");
            if (string.IsNullOrWhiteSpace(inventario.Texto))
                throw new ArgumentException("No nos a proporcionado el texto");
            if (!Ejercicios.ContainsKey(dificultad))
            {
                Ejercicios.Add(dificultad, new List<Inventario>() { inventario });
                AlCambiar?.Invoke();
            }
            else
            {
                Ejercicios[dificultad].Add(inventario);
                AlCambiar?.Invoke();

            }
        }
        public void Registrar(Dificultad dificultad, InventarioProduccion inventario)
        {

            if (!Enum.IsDefined(typeof(Dificultad), dificultad))
                throw new ArgumentException("Seleccionó algún dato no compatible.");
            if (dificultad != Dificultad.Dificil)
                throw new ArgumentException("Este es un problema difícil.");
            if (inventario.D <= 0)
                throw new ArgumentException("La demanda anual debe ser mayor a cero.");
            if (inventario.Co <= 0)
                throw new ArgumentException("El coto por ordenar debe ser mayor a cero.");
            if (inventario.Ch <= 0)
                throw new ArgumentException("El costo por almacenar debe ser mayor a cero.");
            if (inventario.d <= 0)
                throw new ArgumentException("La demanda diaria debe ser mayor a cero.");
            if (inventario.p <= 0)
                throw new ArgumentException("La produccion diaria debe ser mayor a cero.");
            if (inventario.p <= inventario.d)
                throw new ArgumentException("En EPQ la producción diaria debe ser mayor que la demanda diaria.");
            if (string.IsNullOrWhiteSpace(inventario.Texto))
                throw new ArgumentException("No nos a proporcionado el texto.");
            if (!Ejercicios.ContainsKey(dificultad))
            {
                Ejercicios.Add(dificultad, new List<Inventario>() { inventario });
                AlCambiar?.Invoke();

            }
            else
            {
                Ejercicios[dificultad].Add(inventario);
                AlCambiar?.Invoke();

            }
        }

        public void Eliminar(Dificultad dificultad, Inventario inventario)
        {
            if (!Enum.IsDefined(typeof(Dificultad), dificultad))
                throw new ArgumentException("Seleccionó algún dato no compatible.");
            if (inventario == null)
                throw new ArgumentNullException("No se encontró el ejercicio que desea eliminar");


            if (Ejercicios.ContainsKey(dificultad))
            {

                var ejercicioActual = Ejercicios[dificultad]
                  .FirstOrDefault(x => x.Texto == inventario.Texto);

                if (ejercicioActual != null)
                {
                    Ejercicios[dificultad].Remove(ejercicioActual);
                    AlCambiar?.Invoke();
                }
                else
                {
                    throw new ArgumentException("No se encontró el ejercicio a eliminar");
                }
            }
        }
        public void Guardar()
        {
            string json = JsonSerializer.Serialize(Ejercicios, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText("ArchivoEjerciciosIO.json", json);
            AlCambiar?.Invoke();
        }
        public void Leer()
        {
            if (File.Exists("ArchivoEjerciciosIO.json"))
            {
                string json = File.ReadAllText("ArchivoEjerciciosIO.json");
                Ejercicios = JsonSerializer.Deserialize<Dictionary<Dificultad, List<Inventario>>>(json)
                 ?? new Dictionary<Dificultad, List<Inventario>>();
                File.WriteAllText("ArchivoPaises.json", json);
                AlCambiar?.Invoke();
            }
        }


    }
}
