using System;
using System.Collections.Generic;
using System.Text;

namespace trabajo
{
   public class administrativos
    {
        public string nombre { get; set; }
        public void crear_Administrativos()
        {
            Console.WriteLine("Ingrese el nombre del Administrativo: ");
            this.nombre = Console.ReadLine();

        }
    }
}

