using Dominio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio2
{
    internal class Tarea
    {
        int id;
        static int secuendiaId = 0;
        string descripcion;
        DateTime finalizacionEstimada;
        bool tareaFinalizada;
        DateTime fechaDeFinalizacion;
        string? comentarioSobreTarea;
        DateTime fechaPactada;
        string emailPeon;


        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FinalizacionEstimada { get => finalizacionEstimada; set => finalizacionEstimada = value; }
        public bool TareaFinalizada { get => tareaFinalizada; set => tareaFinalizada = value; }
        public DateTime FechaDeFinalizacion { get => fechaDeFinalizacion; set => fechaDeFinalizacion = value; }
        public string? ComentarioSobreTarea { get => comentarioSobreTarea; set => comentarioSobreTarea = value; }
        public string EmailPeon { get => emailPeon;}

        public Tarea()
        {

        }

        public Tarea(int id, string descripcion, DateTime finalizacionEstimada, bool tareaFinalizada, DateTime fechaDeFinalizacion, string? comentarioSobreTarea)
        {
            Id = id;
            Descripcion = descripcion;
            FinalizacionEstimada = finalizacionEstimada;
            TareaFinalizada = tareaFinalizada;
            FechaDeFinalizacion = fechaDeFinalizacion;
            ComentarioSobreTarea = comentarioSobreTarea;
        }

        public void Validar()
        {

        }
        public override string ToString()
        {
            return $" {Id} {Descripcion} {FinalizacionEstimada} {TareaFinalizada} {FechaDeFinalizacion} {ComentarioSobreTarea}";
        }

        private void ValidarEmaiils()
        {
            string minCorreo = EmailPeon.ToLower();
            foreach (Empleado unEmpleado in Empleado)
            {
                if (minCorreo != unEmpleado.Email)
                {
                    throw new Exception("Nombre inválido");
                }
            }
        }



    }

}
