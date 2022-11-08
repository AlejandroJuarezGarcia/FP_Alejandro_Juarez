using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calif_Alum_EJ
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido, grado, seccion, materia;
            byte calif;
            Console.WriteLine("Escriba el nombre del alumno");
            nombre = Console.ReadLine();
            Console.WriteLine("Escriba el apellido del alumno");
            apellido = Console.ReadLine();
            Console.WriteLine("Escriba el grado del alumno");
            grado = Console.ReadLine();
            Console.WriteLine("Escriba la seccion del alumno");
            seccion = Console.ReadLine();
            Console.WriteLine("Escriba la materia a calificar");
            materia = Console.ReadLine();
            Console.WriteLine("Escriba la calificacion del alumno");
            calif= Convert.ToByte (Console.ReadLine());
            if (calif>=70)
            {
                Console.WriteLine("Nombre del alumno:{0}{1} \n Grupo y seccion:{2}{3} \n Materia:{4}"  , nombre, apellido, grado, seccion, materia);
                Console.WriteLine("El alumno esta acreditado");
                
            }
            else
            {
                Console.WriteLine("El alumno no esta acreditado");
            }
            Console.ReadKey();
        }
    }
}
