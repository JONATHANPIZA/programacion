using System;
using System.Collections.Generic;
using System.Text;

namespace trabajo
{
    public class Horario : asignaturas
    {
        public int codhorario { get; set; }
        public string dias { get; set; }
        public int hora { get; set; }

        public void crear_horario()
        {
            Console.WriteLine("ingrese los dias que desea  tomar la materia");
            this.dias = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ingrese la hora que desea tomar la materia");
            this.hora =Convert.ToInt32(Console.ReadLine());
        }
    }
}
