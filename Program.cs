using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejemplo_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            //Variables
            string Name, LastName, Telefono, Email, FBPerfil, City;
            byte Edad;
            string Contrasena, ConContrasena, CodAcc, NameUser;

            Console.WriteLine("Escriba su nombre");
            Name = Console.ReadLine();
            Console.WriteLine("Escriba su apellido");
            LastName = Console.ReadLine();
            Console.WriteLine("Escriba su edad");
            Edad = Convert.ToByte(Console.ReadLine());
            //uso del if
            if (Edad >= 18)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Continue con su registro");
                Console.WriteLine("Escriba su telefono");
                Telefono = Console.ReadLine();
                Console.WriteLine("Escriba la ciudad donde reside");
                City = Console.ReadLine();
                Console.WriteLine("Escriba su perfil de facebook");
                FBPerfil = Console.ReadLine();
                Console.WriteLine("Escriba su Email");
                Email = Console.ReadLine();
                Console.WriteLine("Escriba su nombre de usuario");
                NameUser = Console.ReadLine();
                Console.WriteLine("Escriba su contrasena");
                Contrasena = Console.ReadLine();
                Console.WriteLine("Confirme su contrasena");
                ConContrasena = Console.ReadLine();

                if (Contrasena==ConContrasena)
                {
                    Random rnd = new Random();
                    CodAcc = rnd.Next(1000, 9999).ToString();
                    Console.WriteLine("Su codigo de acceso es: {0}", CodAcc);

                }

                
            }
            else //uso del else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine("Usted no es mayor de edad");
                Console.ReadKey();
            }

            Console.WriteLine("Saliendo del sistema.");
            Thread.Sleep(1000);
            Console.WriteLine("Saliendo del sistema..");
            Thread.Sleep(1000);
            Console.WriteLine("Saliendo del sistema...");
            Thread.Sleep(1000);
            Console.WriteLine("Saliendo del sistema....");
            Thread.Sleep(1000);

        }
    }
}
