using System;
using System.Collections.Generic;
using System.Text;

namespace trabajo
{
    public class asignaturas : profesores
    {
        public int codigo { get; set; }
        public string materia { get; set; }

        public void crear_asignaturas()
        {
            Console.WriteLine("Ingrese el nombre de la materia: ");
            this.materia = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingrese el codigo de la materia " + this.materia + ":");
            this.codigo = Convert.ToInt32(Console.ReadLine());
        }

    }
}
