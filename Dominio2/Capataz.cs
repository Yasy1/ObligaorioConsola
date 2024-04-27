using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio2
{
    internal class Capataz : Empleado
    {
      
        List<Peon> personasACargo;

       // public int CantidadPersonasCargo { get => cantidadPersonasCargo; set => cantidadPersonasCargo = value; }
        public List<Peon> PersonasACargo { get => personasACargo; set => personasACargo = value; }


        public Capataz() {
        
        }

        public Capataz(string Nombre, string Email, String Password, DateTime Ingreso) 
                                                                        : base(Nombre, Email, Password, Ingreso, Rangos.Capataz)
        {
           
            this.personasACargo = new List<Peon>();
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
