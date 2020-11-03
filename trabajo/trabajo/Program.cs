using System;

namespace trabajo
{
    class Program
    {
        static void Main(string[] args)
        {
            profesores profe1 = new profesores();
            profe1.crear_profesor();
            asignaturas asignatura1 = new asignaturas();
            asignatura1.crear_asignaturas();

            profesores profe2 = new profesores();
            profe2.crear_profesor();
            asignaturas asignatura2 = new asignaturas();
            asignatura2.crear_asignaturas();

            estudiantes estudiante1= new estudiantes();
            estudiante1.crear_Estudiante();
            Console.WriteLine("Ingrese el nombre de la materia ya creada");
            string a = Convert.ToString(Console.ReadLine());
            if (asignatura1.materia == a)
            {
                Horario horario1 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario1.codhorario = Convert.ToInt32(Console.ReadLine());
                horario1.crear_horario();
            }
            else if (asignatura2.materia == a)
            {
                Horario horario1 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario1.codhorario = Convert.ToInt32(Console.ReadLine());
                horario1.crear_horario();
            }
            else { Console.WriteLine("la materia no esta creada"); }

            estudiantes estudiante2 = new estudiantes();
            estudiante2.crear_Estudiante();
            Console.WriteLine("Ingrese el nombre de la materia ya creada");
            string B= Convert.ToString(Console.ReadLine());
            if (asignatura1.materia == B)
            {
                Horario horario2 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario2.codhorario = Convert.ToInt32(Console.ReadLine());
                horario2.crear_horario();
            }
            else if (asignatura2.materia == B)
            {
                Horario horario2 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario2.codhorario = Convert.ToInt32(Console.ReadLine());
                horario2.crear_horario();
            }
            else { Console.WriteLine("la materia no esta creada"); }


            estudiantes estudiante3 = new estudiantes();
            estudiante3.crear_Estudiante();
            Console.WriteLine("Ingrese el nombre de la materia ya creada");
            string N = Convert.ToString(Console.ReadLine());
            if (asignatura1.materia == N)
            {
                Horario horario3 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario3.codhorario = Convert.ToInt32(Console.ReadLine());
                horario3.crear_horario();
            }
            else if (asignatura2.materia == N)
            {
                Horario horario3 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario3.codhorario = Convert.ToInt32(Console.ReadLine());
                horario3.crear_horario();
            }
            else { Console.WriteLine("la materia no esta creada"); }


            estudiantes estudiante4 = new estudiantes();
            estudiante4.crear_Estudiante();
            Console.WriteLine("Ingrese el nombre de la materia ya creada");
            string Z = Convert.ToString(Console.ReadLine());
            if (asignatura1.materia == Z)
            {
                Horario horario4 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario4.codhorario = Convert.ToInt32(Console.ReadLine());
                horario4.crear_horario();
            }
            else if (asignatura2.materia == Z)
            {
                Horario horario4 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario4.codhorario = Convert.ToInt32(Console.ReadLine());
                horario4.crear_horario();
            }
            else { Console.WriteLine("la materia no esta creada"); }


            estudiantes estudiante5 = new estudiantes();
            estudiante5.crear_Estudiante();
            Console.WriteLine("Ingrese el nombre de la materia ya creada");
            string X = Convert.ToString(Console.ReadLine());
            if (asignatura1.materia == X)
            {
                Horario horario5 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario5.codhorario = Convert.ToInt32(Console.ReadLine());
                horario5.crear_horario();
            }
            else if (asignatura2.materia == X)
            {
                Horario horario5 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario5.codhorario = Convert.ToInt32(Console.ReadLine());
                horario5.crear_horario();
            }
            else { Console.WriteLine("la materia no esta creada"); }


            estudiantes estudiante6 = new estudiantes();
            estudiante6.crear_Estudiante();
            Console.WriteLine("Ingrese el nombre de la materia ya creada");
            string S = Convert.ToString(Console.ReadLine());
            if (asignatura1.materia == S)
            {
                Horario horario6 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario6.codhorario = Convert.ToInt32(Console.ReadLine());
                horario6.crear_horario();
            }
            else if (asignatura2.materia == S)
            {
                Horario horario6 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario6.codhorario = Convert.ToInt32(Console.ReadLine());
                horario6.crear_horario();
            }
            else { Console.WriteLine("la materia no esta creada"); }


            estudiantes estudiante7 = new estudiantes();
            estudiante7.crear_Estudiante();
            Console.WriteLine("Ingrese el nombre de la materia ya creada");
            string L = Convert.ToString(Console.ReadLine());
            if (asignatura1.materia == L)
            {
                Horario horario7 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario7.codhorario = Convert.ToInt32(Console.ReadLine());
                horario7.crear_horario();
            }
            else if (asignatura2.materia == L)
            {
                Horario horario7 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario7.codhorario = Convert.ToInt32(Console.ReadLine());
                horario7.crear_horario();
            }
            else { Console.WriteLine("la materia no esta creada"); }


            estudiantes estudiante8 = new estudiantes();
            estudiante8.crear_Estudiante();
            Console.WriteLine("Ingrese el nombre de la materia ya creada");
            string P = Convert.ToString(Console.ReadLine());
            if (asignatura1.materia == P)
            {
                Horario horario8 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario8.codhorario = Convert.ToInt32(Console.ReadLine());
                horario8.crear_horario();
            }
            else if (asignatura2.materia == P)
            {
                Horario horario8 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario8.codhorario = Convert.ToInt32(Console.ReadLine());
                horario8.crear_horario();
            }
            else { Console.WriteLine("la materia no esta creada"); }


            estudiantes estudiante9 = new estudiantes();
            estudiante9.crear_Estudiante();
            Console.WriteLine("Ingrese el nombre de la materia ya creada");
            string Q = Convert.ToString(Console.ReadLine());
            if (asignatura1.materia == Q)
            {
                Horario horario9 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario9.codhorario = Convert.ToInt32(Console.ReadLine());
                horario9.crear_horario();
            }
            else if (asignatura2.materia == Q)
            {
                Horario horario9 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario9.codhorario = Convert.ToInt32(Console.ReadLine());
                horario9.crear_horario();
            }
            else { Console.WriteLine("la materia no esta creada"); }


            estudiantes estudiante10 = new estudiantes();
            estudiante10.crear_Estudiante();
            Console.WriteLine("Ingrese el nombre de la materia ya creada");
            string T = Convert.ToString(Console.ReadLine());
            if (asignatura1.materia == T)
            {
                Horario horario0= new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario0.codhorario = Convert.ToInt32(Console.ReadLine());
                horario0.crear_horario();
            }
            else if (asignatura2.materia == T)
            {
                Horario horario0 = new Horario();
                Console.WriteLine("ingrese el codigo del horario");
                horario0.codhorario = Convert.ToInt32(Console.ReadLine());
                horario0.crear_horario();
            }
            else { Console.WriteLine("la materia no esta creada"); }


            administrativos admin1 = new administrativos();
            admin1.crear_Administrativos();

            administrativos admin2 = new administrativos();
            admin2.crear_Administrativos();
        }
    }
}
