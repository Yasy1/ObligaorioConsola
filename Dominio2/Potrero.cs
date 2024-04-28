using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio2
{
    internal class Potrero
    {
        int id;
        public static int secuendiaId = 0;
        string? descripcion;
        float cantidadHectareas;
        int capacidadMaxima;
        List<Tarea> tareas;

        public int Id { get => id; set => id = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }
        public float CantidadHectareas { get => cantidadHectareas; set => cantidadHectareas = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }


        public Potrero(){

        }

        public Potrero(int id, string? descripcion, float cantidadHectareas, int capacidadMaxima)
        {
            Id = id;
            Descripcion = descripcion;
            CantidadHectareas = cantidadHectareas;
            CapacidadMaxima = capacidadMaxima;
        }

        public void Validar()
        {

        }

        private float CalcularGanancias()
        {
            return;
        }

        private bool ListaNoSupereCapacidadMaxima()
        {
            return;
        }

        private float CostoTotal()
        {
            return;
        }



        public override string ToString()
        {
            return $" {Id} {Descripcion} {CantidadHectareas} {CapacidadMaxima}";
        }
    }

}
