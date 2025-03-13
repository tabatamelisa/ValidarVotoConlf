using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarVotoConIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verificar si una persona puede votar usando if-else
            //Tabata Vernaza
            int edad;
            do
            {
                Console.Write("Introduce tu edad para verificar si puedes votar: ");
                edad = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {
                    Console.WriteLine("Si puedes votar.");
                }
                else
                {
                    Console.WriteLine("No puedes votar.");
                }
            } while (true); //El programa se repite
        }
    }
}
