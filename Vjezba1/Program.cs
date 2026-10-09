using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string izbor = "";
            do
            {
                Console.WriteLine("1. zadatak");
                Console.WriteLine("2. zadatak");
                Console.WriteLine("3. zadatak");
                Console.WriteLine("0. kraj");

                Console.WriteLine("Unesite broj zadatka: ");
                izbor = Console.ReadLine();
                switch (izbor)
                {
                    case "1":
                        Zad01();
                        break;
                    case "2":
                        Zad02();
                        break;
                    case "3":
                        Zad03();
                        break;  
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepoznat izbor)");
                        break;
                }

            } while (izbor != "0");
            Console.ReadKey();
        }
        static void Zad01()
        {
            Console.WriteLine("Zadatak 1");
        }
        static void Zad02()
        {
            Console.WriteLine("Zadatak 2");
        }        
        static double Povrsina(double a, double b)
        {
            return a * b;
        }
        static void Zad03()
        {
            Console.WriteLine("---Zadatak 3---");
            Console.WriteLine("Unesi stranicu pravokutnika a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesi starnicu pravokutnika b: ");
            double b = double.Parse(Console.ReadLine());
            double povrsina = Povrsina(a, b);
            Console.WriteLine($"Povrsina pravokutnika je: {povrsina}");
            Console.WriteLine($"Povrsina pravokutnika je: {Povrsina(a, b)}");
        }


    }
}
