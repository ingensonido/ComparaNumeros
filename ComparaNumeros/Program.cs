using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ComparaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            String e2;
            int numeroa, numerob;
            Console.WriteLine("Sistema para Felipe");
            Console.WriteLine("Ingrese un número");
            numeroa = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Ingrese un número");
                e2 = Console.ReadLine();
                if (e2 == "stop")
                {
                    Console.WriteLine("Usted Desea Cerrarlo");
                    Environment.Exit(0);
                }
                numerob = int.Parse(e2);
                if (numeroa < numerob)
                    {
                        numerob = numeroa;
                    }            
                Console.WriteLine("El numero más bajo es: " + numerob);
            } while (Console.ReadLine() != "stop");
        }
    }
}//wow es mas facil de lo que pense pero me explota la cabeza cuando no puedo :c 
