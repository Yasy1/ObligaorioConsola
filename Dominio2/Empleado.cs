using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio2
{
    public abstract class Empleado
    {
        public enum Rangos { Capataz, Peon };
        Rangos TipoEmpleado;
        string? nombre;
        string? email;
        string? password;
        DateTime ingreso = new DateTime();
        

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Email { get => email; set => email = value; }
        public string? Password { get => password; set => password = value; }
        public DateTime Ingreso { get => ingreso; set => ingreso = value; }
        public Rangos TipoEmpleado1 { get => TipoEmpleado; set => TipoEmpleado = value; }

        public Empleado() {

        }

        public Empleado(string? nombre, string? email, string? password, DateTime ingreso, Rangos tipoEmpleado1) 
        {
            Nombre = nombre;
            Email = email;
            Password = password;
            Ingreso = ingreso;
            TipoEmpleado1 = tipoEmpleado1;
        }

        public void Validar()
        {

        }

        private string ValidadContraseña()
        {
            return;
        }

        public override string ToString()
        {
            return $" {Nombre} {Email} {Password} {Ingreso} {TipoEmpleado1}" ;
        }


        // Lanzar excepciones


    }
}
