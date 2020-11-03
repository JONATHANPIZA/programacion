using System;
using System.Collections.Generic;
using System.Text;

namespace trabajo
{
    public class profesores
    {
        public string nombrepro { get; set; }
        public void crear_profesor()
        {
                Console.WriteLine("Ingrese el nombre del profesor: ");
                this.nombrepro = Console.ReadLine();

        }
    }
}
