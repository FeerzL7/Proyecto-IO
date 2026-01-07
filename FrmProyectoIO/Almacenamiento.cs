using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.IO;
using System.Text.Json;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FrmProyectoIO
{
    public class Almacenamiento
    {
        public Dictionary<Dificultad, List<Inventario>> Ejercicios { get; set; } = new();

        public delegate void Profesor();
        public event Profesor? AlCambiar;


        public void Registrar(Dificultad dificultad, Inventario inventario)
        {

            if (!Enum.IsDefined(typeof(Dificultad), dificultad))
                throw new ArgumentException("Seleccionó algún dato no compatible.");
            if (string.IsNullOrWhiteSpace(inventario.Titulo))
                throw new ArgumentException("Escriba el titulo del ejercicio.");

            if (inventario.DemandaXunidadTiempo <= 0)
                throw new ArgumentException("La demanda anual debe ser mayor a cero.");
            if (inventario.CostoPorColocarOrden <= 0)
                throw new ArgumentException("El coto por ordenar debe ser mayor a cero.");
            if (inventario.CostoPorAlmacenar <= 0)
                throw new ArgumentException("El costo por almacenar debe ser mayor a cero.");
            if (inventario.TiempoDeEntrega > 0 && inventario.DemandaDiaria <= 0)
                throw new ArgumentException("Si el tiempo de entrega es mayor a cero debe \n proporcionarnos la demanda diaria");
            if (string.IsNullOrWhiteSpace(inventario.Texto))
                throw new ArgumentException("No nos a proporcionado el texto");
            inventario.Dificultad = dificultad;
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

            if (string.IsNullOrWhiteSpace(inventario.Titulo))
                throw new ArgumentException("Escriba el titulo del ejercicio.");
            if (inventario.DemandaXunidadTiempo <= 0)
                throw new ArgumentException("La demanda anual debe ser mayor a cero.");
            if (inventario.CostoPorColocarOrden <= 0)
                throw new ArgumentException("El coto por ordenar debe ser mayor a cero.");
            if (inventario.CostoPorAlmacenar <= 0)
                throw new ArgumentException("El costo por almacenar debe ser mayor a cero.");
            if (inventario.DemandaDiaria <= 0)
                throw new ArgumentException("La demanda diaria debe ser mayor a cero.");
            if (inventario.TasaDeProduccion <= 0)
                throw new ArgumentException("La produccion diaria debe ser mayor a cero.");
            if (inventario.TasaDeProduccion <= inventario.DemandaDiaria)
                throw new ArgumentException("En EPQ la producción diaria debe ser mayor que la demanda diaria.");
            if (string.IsNullOrWhiteSpace(inventario.Texto))
                throw new ArgumentException("No nos a proporcionado el texto.");
            inventario .Dificultad = dificultad;
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
        public void Modificar(Dificultad dificultad, Inventario invmodificado)
        {

            if (!Enum.IsDefined(typeof(Dificultad), dificultad))
                throw new ArgumentException("Dificultad no valida");
            if (invmodificado == null)
                throw new ArgumentNullException("Inventario vacio");
            if (!Ejercicios.ContainsKey(dificultad))
                throw new ArgumentException("No existen ejercicios en esa dificultad");
            var lista = Ejercicios[dificultad];
            var ejeActual = lista.FirstOrDefault(x => x.Id == invmodificado.Id);

            if (ejeActual == null)
                throw new ArgumentException("No se encontro el ejercicio a modificar");
            int index = lista.IndexOf(ejeActual);
            lista[index] = invmodificado;

            AlCambiar?.Invoke();
        }

        public void Eliminar(Dificultad dificultad, Inventario inventario)
        {

            if (!Enum.IsDefined(typeof(Dificultad), dificultad))
                throw new ArgumentException("Dificultad no válida.");


            if (inventario == null)
                throw new ArgumentNullException("Ingrese los datos del ejercicio");


            if (!Ejercicios.ContainsKey(dificultad))
                throw new ArgumentException("No existen ejercicios en esa dificultad.");


            var ejercicioActual = Ejercicios[dificultad]
                .FirstOrDefault(x => x.Id == inventario.Id);

            if (ejercicioActual == null)
                throw new ArgumentException("No se encontró el ejercicio a eliminar.");


            Ejercicios[dificultad].Remove(ejercicioActual);


            AlCambiar?.Invoke();
        }
        public void CrearPdf(string RutaDeAcceso, List<Inventario> ejercicios)
        {

            //IMPORTANTE: INSTALAR LA LIBRERIA "iTextSharp"
            //IMPORTANTE: INSTALAR LA LIBRERIA "iTextSharp"

            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 25, 25, 25, 25);
            PdfWriter.GetInstance(doc, new FileStream(RutaDeAcceso, FileMode.Create));
            doc.Open();
            PdfPCell Header(string texto)
            {
                PdfPCell cell = new PdfPCell(new Phrase(texto));
                cell.BackgroundColor = BaseColor.YELLOW;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                cell.Padding = 5;
                return cell;
            }
            Paragraph Header2(string texto)
            {
                iTextSharp.text.Font font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                Paragraph p = new Paragraph(texto, font);
                p.Alignment = Element.ALIGN_CENTER;
                p.SpacingAfter = 10;
                return p;
            }
            foreach (Inventario inv in ejercicios)
            {
                if (inv is InventarioProduccion epq)
                {
                    doc.Add(new Paragraph(Header2("EPQ")));
                    doc.Add(new Paragraph(Header2(inv.Titulo)));
                    doc.Add(new Paragraph(inv.Texto));
                    doc.Add(new Paragraph($"Demanda anual: {inv.DemandaXunidadTiempo}" + $"Costo por colocar orden: {inv.CostoPorColocarOrden:F2}"));
                    doc.Add(new Paragraph($"Costo por almacenar: {inv.CostoPorAlmacenar:F2}" + $"Demanda diaria: {inv.DemandaDiaria:F2}"));
                    doc.Add(new Paragraph($"Producción diaria: {epq.TasaDeProduccion}"));
                    doc.Add(new Paragraph(" "));
                    PdfPTable tabla = new PdfPTable(8);
                    tabla.WidthPercentage = 100;
                }
            }
        }
        public void GenerarExamenPDF(string RutaDeAcceso,
            int NFEOQ, int NMEOQ, int NDEOQ,
            int NFEPQ, int NMEPQ, int NDEPQ
            )
        {

            List<Inventario> DEOQ = Ejercicios[Dificultad.Dificil].Where(x => x is not InventarioProduccion).ToList();
            List<Inventario> MEOQ = Ejercicios[Dificultad.Medio].Where(x => x is not InventarioProduccion).ToList();
            List<Inventario> FEOQ = Ejercicios[Dificultad.Facil].Where(x => x is not InventarioProduccion).ToList();
            List<Inventario> DEPQ = Ejercicios[Dificultad.Dificil].Where(x => x is InventarioProduccion).ToList();
            List<Inventario> MEPQ = Ejercicios[Dificultad.Medio].Where(x => x is InventarioProduccion).ToList();
            List<Inventario> FEPQ = Ejercicios[Dificultad.Facil].Where(x => x is InventarioProduccion).ToList();
            //validaciones de los datos
            if (NFEOQ < 0 || NMEOQ < 0 || NDEOQ < 0 || NFEPQ < 0 || NMEPQ < 0 || NDEPQ < 0)
                throw new ArgumentException("Ninguno de los datos puestos puede ser negativo");
            if (NFEOQ == 0 && NMEOQ == 0 && NDEOQ == 0 && NFEPQ == 0 && NMEPQ == 0 && NDEPQ == 0)
                throw new ArgumentException("No puede dejar todos los datos en cero");
            if (NFEOQ > FEOQ.Count)
                throw new ArgumentException($"el Numero de los Ejercicios faciles del modelo EOQ es mayor a la cantidad que esta registrada({FEOQ.Count})");
            if (NMEOQ > MEOQ.Count)
                throw new ArgumentException($"el Numero de los Ejercicios intermedio del modelo EOQ es mayor a la cantidad que esta registrada({MEOQ.Count})");
            if (NDEOQ > DEOQ.Count)
                throw new ArgumentException($"el Numero de los Ejercicios dificiles del modelo EOQ es mayor a la cantidad que esta registrada({DEOQ.Count})");
            if (NFEPQ > FEPQ.Count)
                throw new ArgumentException($"el Numero de los Ejercicios faciles del modelo EPQ es mayor a la cantidad que esta registrada({FEPQ.Count})");
            if (NMEPQ > MEPQ.Count)
                throw new ArgumentException($"el Numero de los Ejercicios intermedio del modelo EPQ es mayor a la cantidad que esta registrada({MEPQ.Count})");
            if (NDEPQ > DEPQ.Count)
                throw new ArgumentException($"el Numero de los Ejercicios dificiles del modelo EPQ es mayor a la cantidad que esta registrada({DEPQ.Count})");
            List<Inventario> Seleccion = new();
            Random azar = new Random();
            int i = 0;
            while (i < NFEOQ)
            {
                int seleccionado = azar.Next(FEOQ.Count);
                if (!Seleccion.Contains(FEOQ[seleccionado]))
                {
                    Seleccion.Add(FEOQ[seleccionado]);
                    i++;
                }
            }
            i = 0;
            while (i < NMEOQ)
            {
                int seleccionado = azar.Next(MEOQ.Count);
                if (!Seleccion.Contains(MEOQ[seleccionado]))
                {
                    Seleccion.Add(MEOQ[seleccionado]);
                    i++;
                }
            }
            i = 0;
            while (i < NDEOQ)
            {
                int seleccionado = azar.Next(DEOQ.Count);
                if (!Seleccion.Contains(DEOQ[seleccionado]))
                {
                    Seleccion.Add(DEOQ[seleccionado]);
                    i++;
                }
            }i = 0;
            while (i < NFEPQ)
            {
                int seleccionado = azar.Next(FEPQ.Count);
                if (!Seleccion.Contains(FEPQ[seleccionado]))
                {
                    Seleccion.Add(FEPQ[seleccionado]);
                    i++;
                }
            }
            i = 0;
            while (i < NMEPQ)
            {
                int seleccionado = azar.Next(MEPQ.Count);
                if (!Seleccion.Contains(MEPQ[seleccionado]))
                {
                    Seleccion.Add(MEPQ[seleccionado]);
                    i++;
                }
            }
            i = 0;
            while (i < NDEPQ)
            {
                int seleccionado = azar.Next(DEPQ.Count);
                if (!Seleccion.Contains(DEPQ[seleccionado]))
                {
                    Seleccion.Add(DEPQ[seleccionado]);
                    i++;
                }
            }
            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 25, 25, 25, 25);
            PdfWriter.GetInstance(doc, new FileStream(RutaDeAcceso, FileMode.Create));
            doc.Open();
            foreach (Inventario inv in Seleccion)
            {
                if (inv is InventarioProduccion epq)
                {
                    doc.Add(new Paragraph("EPQ"));
                    doc.Add(new Paragraph(inv.Titulo));
                    doc.Add(new Paragraph(inv.Texto));
                    doc.Add(new Paragraph($"Demanda anual: {inv.DemandaXunidadTiempo}" + $" Costo por colocar orden: {inv.CostoPorColocarOrden:F2}"));
                    doc.Add(new Paragraph($"Costo por almacenar: {inv.CostoPorAlmacenar:F2}" + $" Demanda diaria: {inv.DemandaDiaria:F2}"));
                    doc.Add(new Paragraph($"Producción diaria: {epq.TasaDeProduccion}"));
                    PdfPTable tabla = new PdfPTable(8);
                    tabla.WidthPercentage = 100;
                    tabla.AddCell("Q*");
                    tabla.AddCell("N");
                    tabla.AddCell("Imax");
                    tabla.AddCell("Iprom");
                    tabla.AddCell("Calm");
                    tabla.AddCell("Cprep");
                    tabla.AddCell("Ct");
                    tabla.AddCell("Tp");
                    for (int H = 0; H < 8; H++)
                        tabla.AddCell("        ");
                    doc.Add(tabla);
                }
                else
                {
                    doc.Add(new Paragraph("EOQ"));
                    doc.Add(new Paragraph(inv.Titulo));
                    doc.Add(new Paragraph(inv.Texto));
                    doc.Add(new Paragraph($"Demanda anual: {inv.DemandaXunidadTiempo}" + $" Costo por colocar orden: {inv.CostoPorColocarOrden:F2}"));
                    doc.Add(new Paragraph($"Costo por almacenar: {inv.CostoPorAlmacenar:F2}" + $"Tiempo de entrega: {inv.TiempoDeEntrega}" + $"Dias laborados en el año: {inv.DiasLaboradosAño}"));
                    doc.Add(new Paragraph($"Demanda diaria: {inv.DemandaDiaria:F2}"));
                    doc.Add(new Paragraph($"Costo total: {inv.CostoTotalXUnidadTiempo:C}"));
                    PdfPTable tabla1 = new PdfPTable(8);
                    tabla1.WidthPercentage = 100;
                    tabla1.AddCell("Q*");
                    tabla1.AddCell("CAO");
                    tabla1.AddCell("CAA");
                    tabla1.AddCell("CT");
                    tabla1.AddCell("To");
                    tabla1.AddCell("Cprom");
                    tabla1.AddCell("Le");
                    tabla1.AddCell("r");
                    for (int H = 0; H < 8; H++)
                        tabla1.AddCell("        ");
                    doc.Add(tabla1);
                }
            }
            doc.Close();
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