using Dominio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio
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
        Peon emails;


        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FinalizacionEstimada { get => finalizacionEstimada; set => finalizacionEstimada = value; }
        public bool TareaFinalizada { get => tareaFinalizada; set => tareaFinalizada = value; }
        public DateTime FechaDeFinalizacion { get => fechaDeFinalizacion; set => fechaDeFinalizacion = value; }
        public string? ComentarioSobreTarea { get => comentarioSobreTarea; set => comentarioSobreTarea = value; }
        internal Peon Emails { get => emails;}

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





    }

}
