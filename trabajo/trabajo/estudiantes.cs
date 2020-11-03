using System;
using System.Collections.Generic;
using System.Text;

namespace trabajo
{
    public class estudiantes : Horario
    {
        public string nombrestu { get; set; }
        public void crear_Estudiante()
        {
            Console.WriteLine("Ingrese el nombre del Estudiante: ");
            this.nombrestu = Console.ReadLine();

        }

      
    }
}
