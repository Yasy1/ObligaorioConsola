using Dominio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio2
{
    internal class Peon : Empleado
    {
        bool EsResidente;
        List<Tarea> tareas;

        public bool EsResidente1 { get => EsResidente; set => EsResidente = value; }
        internal List<Tarea> Tareas { get => tareas;} // saque set para que no vaguee

        public Peon()
        {
        }

        public Peon(bool esResidente, List<Tarea> tareas, string Nombre, string Email, string Password, DateTime Ingreso) : base(Nombre,Email, Password, Ingreso, Rangos.Peon)
        {
            EsResidente = esResidente;
            this.tareas = tareas;
        }

        public void Validacion()
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }



    }
}
