using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmProyectoIO.Properties
{
    public enum Dificultad { Facil,Medio,Dificil }

    public class ModeloUnSoloServidor
    {       
        //Propiedades de un reactivo
        public Dificultad NivelDificultad { get; set; } = Dificultad.Facil; //nivel de dificultad
        public string Titulo { get; set; } = "Sin titulo"; //titulo del reactivo
        public string Enunciado { get; set; } = "Sin enunciado"; 
        

        public double TasaServicio { get; set; } = 0;  //niu
        public double TasaLlegada { get; set; } = 0;    //lambda

        //solo se usa en el modelo de un servidor
        public int CantidadClientesEnSistema { get;set;} = 0;    //n

        //Propiedades para calculos
        public double UtilizacionPromedioSistema //p
        {
            get
            {
                return TasaLlegada / TasaServicio;
            }
        }

        public virtual double NumeroPromedioEnServicio //Ls: Numero promedio de clientes en el servicio
        {
            get
            {
                return TasaLlegada / (TasaServicio - TasaLlegada);
            }
        }

        public virtual double NumeroPromedioEnFila //Lq: numero promedio de clientes en la fila
        {
            get
            {
                return UtilizacionPromedioSistema * NumeroPromedioEnServicio;
            }
            
        }

        public virtual double TiempoPromedioEnServicio  //Ws: Tiempo promedio de clientes en el servicio
        {
            get
            {
                return 1 / (TasaServicio - TasaLlegada);
            }
            
        }

        public virtual double TiempoPromedioEnFila //Wq: Tiempo promedio de clientes en la fila
        {
            get
            {
                return UtilizacionPromedioSistema * TiempoPromedioEnServicio;
            }
        }

        //Probabilidades
        public double ProbabilidadDeTrabajadorOcioso //Po
        {
            get
            {
                return 1 - UtilizacionPromedioSistema;
            }
        }

        public double ProbabilidadClientesSistema  //p(n)
        {
            get
            {
                return (1d - UtilizacionPromedioSistema) * Math.Pow(UtilizacionPromedioSistema, CantidadClientesEnSistema);
            }
        }

    }
}
