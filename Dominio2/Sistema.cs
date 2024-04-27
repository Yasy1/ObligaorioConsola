﻿using Dominio;
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
        List<TareaP> tareas = new List<TareaP>();

        public static Sistema Instancia
        {
            get { 
            if (instancia == null){
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

            foreach (Empleado empleadito in persona)
            {
                if (email == empleadito.Email)
                {
                    return empleadito;
                }
               
                }
            return null;
        }
        public Tarea? BuscarTarea(string email, int id)
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




    }
}



}
