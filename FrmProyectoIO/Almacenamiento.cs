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
        public event Profesor ? AlCambiar;

        public void Registrar(Dificultad dificultad, Inventario inventario)
        {
            if (!Enum.IsDefined(typeof(Dificultad), dificultad))
                throw new ArgumentException("Dificultad no válida.");

            if (string.IsNullOrWhiteSpace(inventario.Texto))
                throw new ArgumentException("No se proporcionó el texto del ejercicio.");

            // Validaciones de ambos modelos
            if (inventario.DemandaXunidadTiempo <= 0)
                throw new ArgumentException("La demanda anual debe ser mayor a cero.");
            if (inventario.CostoPorColocarOrden <= 0)
                throw new ArgumentException("El costo por ordenar debe ser mayor a cero.");
            if (inventario.CostoPorAlmacenar <= 0)
                throw new ArgumentException("El costo por almacenar debe ser mayor a cero.");

            if (inventario.TiempoDeEntrega > 0 && inventario.DemandaDiaria <= 0)
                throw new ArgumentException("Debe proporcionar demanda diaria.");

            // Validaciones por tipo de modelo
            if (inventario.Tipo == TipoEjercicio.EOQ && dificultad != Dificultad.Facil)
                throw new ArgumentException("EOQ solo corresponde a dificultad fácil.");

            if (inventario.Tipo == TipoEjercicio.EPQ)
            {
                if (dificultad != Dificultad.Dificil)
                    throw new ArgumentException("EPQ solo corresponde a dificultad difícil.");

                var epq = inventario as InventarioProduccion
                    ?? throw new ArgumentException("Datos EPQ inválidos.");

                if (epq.TasaDeProduccion <= epq.DemandaDiaria)
                    throw new ArgumentException("La producción debe ser mayor que la demanda.");
            }

            if (!Ejercicios.ContainsKey(dificultad))
                Ejercicios[dificultad] = new List<Inventario>();

            Ejercicios[dificultad].Add(inventario);
            AlCambiar?.Invoke();
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
            if (!File.Exists("ArchivoEjerciciosIO.json")) return;

            string json = File.ReadAllText("ArchivoEjerciciosIO.json");
            Ejercicios = JsonSerializer.Deserialize<Dictionary<Dificultad, List<Inventario>>>(json)
                ?? new();

            AlCambiar?.Invoke();
        }


    }
}
