using Dominio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dominio2
{
    internal class Sistema
    {
        private static Sistema instancia;
        List<Ganado> ganados = new List<Ganado>();
        List<Empleado> persona = new List<Empleado>();
        List<Potrero> potreros = new List<Potrero>();
        List<Vacuna> vacunas = new List<Vacuna>();
        List<Tarea> tareas = new List<Tarea>();

        public static Sistema Instancia
        {
            get {
                if (instancia == null) {
                    instancia = new Sistema();
                }
                return instancia;
            }
        }

        private Sistema()
        {
            //precarga
        }

        public Empleado? BuscarEmpleado(string email)
        {
            string minEmail = email.ToLower();
            foreach (Empleado empleadito in persona)
            {
                if (minEmail == empleadito.Email)
                {
                    return empleadito;
                }
            }
            return null;
        }

        public List<Empleado> BuscarEmpleadoRango(TipoEmpleado tipoEmpleado)
        {
            List<Empleado> aux = new List<Empleado>();
            if (tipoEmpleado == tipoEmpleado.peon)
            {

            }
            foreach (Empleado empleadito in persona)
            {
                if (tipoEmpleado == tipoEmpleado.peon && empleadito.typeof(Peon))
                {
                    aux.Add(empleadito);
                }
              /*  if (persona.GetType() == typeof(Estudiante))
                {
                    aux.Add(persona); detallesss
                }*/

                if (tipoEmpleado == tipoEmpleado.capataz && empleadito.typeof(Capataz))
                {
                    aux.Add(empleadito);
                }

            }
            return aux;
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return persona;

        }

        public Tarea? BuscarTarea(string email, int id)// se puede comprimir
        {
            foreach (Tarea unaTarea in tareas)
            {
                if(id == unaTarea.Id) { 
                    foreach (Empleado empleadito in persona)
                    {
                        if (email == empleadito.Email)
                        {
                            return unaTarea;
                        }

                    }
                }

            }


            return null;
        }



        List<Tarea> AsignarTarea(string email, int id)
        {
            string minEmail = email.ToLower();
            List < Tarea > aux = new List<Tarea>();
            foreach (Tarea unaTarea in tareas)
            {
                if (minEmail == unaTarea.EmailPeon )
                {
                    if (id != unaTarea.Id)
                    {
                        aux.Add(unaTarea);
                    }


                }
            }
            return aux;
        }

        public List<Tarea> ListarTareas() //potencial de comprimir
        {
         return tareas;

        }

        public bool VerificarExistencia(string email)
        {
            string minEmail= email.ToLower();

            foreach ( Empleado empleadito in persona)
            {
                if (empleadito.Email != null && empleadito.Email.ToLower() == minEmail)
                {
                    throw new Exception("Ya está registrado");
                }
            }
            return true;
        }

        public List<Empleado> ObtenerEmpleadosGenerales()
        {
            return persona;
        }

        public List<Peon> MostrarPeonPorCapataz(string email) //tiene potencial
        {
            Empleado empleadito = ObtenerEmpleados(email)
                if (empleadito == null)
            {
                throw new Exception("Capataz no encontrado");
            }
            if (empleadito.GetType() == typeof(Capataz))
            {
                Capataz unCapataz = empleadito as Capataz;
                return unCapataz.PersonasACargo;
            }
        }

        public Capataz ObtenerCapatazSegunPeon(string email)//tiene potencial
        {
            List<Peon> personasACargo = new List<Peon>();
            foreach (var item in email)
                {
                if (email == )
                {
                    
                }
            }
            return ;
            
        }




    }
}




