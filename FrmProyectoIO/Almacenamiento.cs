using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Threading.Tasks;

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
            if (dificultad != Dificultad.Facil)
                throw new ArgumentException("Este es un problema fácil.");
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
            Document doc = new Document(PageSize.A4, 25, 25, 25, 25);
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

                    tabla.AddCell(Header("Q*"));
                    tabla.AddCell(Header("N"));
                    tabla.AddCell(Header("Imax"));
                    tabla.AddCell(Header("Iprom"));
                    tabla.AddCell(Header("Calm"));
                    tabla.AddCell(Header("Cprep"));
                    tabla.AddCell(Header("Ct"));
                    tabla.AddCell(Header("Tp"));
                    tabla.AddCell(epq.CantidadDeLoteEconomico.ToString("F2"));
                    tabla.AddCell(epq.NumeroDeLotes.ToString("F2"));
                    tabla.AddCell(epq.InventarioMaximo.ToString("F2"));
                    tabla.AddCell(epq.InventarioPromedio.ToString("F2"));
                    tabla.AddCell(epq.CostoAnualXAlmacenar.ToString("C"));
                    tabla.AddCell(epq.CostoAnualXPreparacion.ToString("C"));
                    tabla.AddCell(epq.CostoTotalXUnidadTiempo.ToString("C"));
                    tabla.AddCell(epq.TiempoDelCiclo.ToString("F2"));
                    doc.Add(tabla);
                }
                else
                {

                    doc.Add(new Paragraph(Header2("EOQ")));
                    doc.Add(new Paragraph(Header2(inv.Titulo)));
                    doc.Add(new Paragraph(inv.Texto));
                    doc.Add(new Paragraph($"Demanda anual: {inv.DemandaXunidadTiempo}" + $"Costo por colocar orden: {inv.CostoPorColocarOrden:F2}"));
                    doc.Add(new Paragraph($"Costo por almacenar: {inv.CostoPorAlmacenar:F2}" + $"Tiempo de entrega: {inv.TiempoDeEntrega}" + $"Dias laborados en el año: {inv.DiasLaboradosAño}"));
                    doc.Add(new Paragraph($"Demanda diaria: {inv.DemandaDiaria:F2}"));
                    doc.Add(new Paragraph(" "));
                    PdfPTable tabla1 = new PdfPTable(8);
                    tabla1.WidthPercentage = 100;
                    tabla1.AddCell(Header("Q*"));
                    tabla1.AddCell(Header("CAO"));
                    tabla1.AddCell(Header("CAA"));
                    tabla1.AddCell(Header("CT"));
                    tabla1.AddCell(Header("To"));
                    tabla1.AddCell(Header("Cprom"));
                    tabla1.AddCell(Header("Le"));
                    tabla1.AddCell(Header("r"));
                    tabla1.AddCell(inv.CantidadDeLoteEconomico.ToString("F2"));
                    tabla1.AddCell(inv.CostoAnualXOrdenar.ToString("c"));
                    tabla1.AddCell(inv.CostoAnualXAlmacenar.ToString("c"));
                    tabla1.AddCell(inv.CostoTotalXUnidadTiempo.ToString("c"));
                    tabla1.AddCell(inv.DuracionDelCiclo.ToString("F2"));
                    tabla1.AddCell(inv.CantidadPromInventario.ToString("F2"));
                    tabla1.AddCell(inv.TiempoEfectivo.ToString("F2"));
                    tabla1.AddCell(inv.PuntoDeReorden.ToString("F2"));
                    doc.Add(tabla1);
                }
            }

            doc.Close();
        }
        public void GenerarExamenPDF(string RutaDeAcceso, int NumeroFaciles, int NumeroDificiles)
        {
            List<Inventario> Dificiles = Ejercicios[Dificultad.Dificil];
            List<Inventario> faciles = Ejercicios[Dificultad.Facil];
            
            if (NumeroFaciles > Ejercicios[Dificultad.Facil].Count)
                throw new ArgumentException("no puede asignar mas problemas faciles de los que cuenta el problemario.");
            if (NumeroDificiles > Ejercicios[Dificultad.Dificil].Count)
                throw new ArgumentException("no puede asignar mas problemas Dificiles de los que cuenta el problemario.");
            if (NumeroFaciles < 0 || NumeroDificiles<0)
                throw new ArgumentException("no puede asignar numeros negativos a los problemas de los que cuenta el problemario.");
            if (NumeroFaciles==0 && NumeroDificiles==0)
                throw new ArgumentException("No puede asignar 0 a los dos valores.");
            List<Inventario> Seleccion = new();
            Random azar = new Random();
            int i = 0;
            while (i < NumeroFaciles)// selecciona los problemas faciles para agregarlos a la lista
            {
                int seleccionado = azar.Next(faciles.Count);
                if (!Seleccion.Contains(faciles[seleccionado]))
                {
                    Seleccion.Add(faciles[seleccionado]);
                    i++;
                }
            }
            i = 0;
            while (i < NumeroDificiles)// selecciona los problemas dificiles 
            {
                int seleccionado = azar.Next(Dificiles.Count);
                if (!Seleccion.Contains(Dificiles[seleccionado]))
                {
                    Seleccion.Add(Dificiles[seleccionado]);
                    i++;
                }
            }
            //se crea el documento donde se guardara la lista con los problemas
            Document doc = new Document(PageSize.A4, 25, 25, 25, 25);
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
                    doc.Add(new Paragraph($"Costo por almacenar: {inv.CostoPorAlmacenar:F2}" + $" Tiempo de entrega: {inv.TiempoDeEntrega}" + $" Dias laborados en el año: {inv.DiasLaboradosAño}"));
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