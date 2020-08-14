using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Aleatorio = new Random();
            int dado1, dado2, total = 0, vidas = 3, Turnodosdados = 0, Turnodevida = 0;
            string seguir = "s";

            while ((total < 100) && (seguir == "s"))
            {
                
                Turnodosdados += 1;
                Turnodevida += 1;

                
                if (Turnodosdados == 3)
                {
                    Turnodosdados = 0;

                    dado1 = Aleatorio.Next(1, 7);
                    dado2 = Aleatorio.Next(1, 7);
                    Console.WriteLine("\nDado 1: " + dado1);
                    Console.WriteLine("Dado 2: " + dado2);
                    total += dado1 + dado2;
                    if (dado1 == dado2)
                    {
                        vidas += 1;
                        Console.WriteLine("\nGanas 1 vida");
                        Console.WriteLine("Tienes " + vidas + " vidas");
                    }
                }
                else
                {
                    dado1 = Aleatorio.Next(1, 7);
                    Console.WriteLine("\nDado: " + dado1);
                    total += dado1;
                }
                
                if (Turnodevida == 2)
                {
                    Turnodevida = 0;
                    vidas -= 1;
                    Console.WriteLine("\nPerdiste 1 vida");
                    Console.WriteLine("Tienes " + vidas + " vidas");
                    if (vidas == 0)
                    {
                        Console.WriteLine("\nPerdiste ");
                        break;
                    }
                }

                Console.WriteLine("\nTotal: " + total);

                if (total >= 100)
                {
                    Console.WriteLine("\nGanaste ");
                    break;
                }

                else
                {
                    Console.WriteLine("\nDesea continuar? (s/n)");
                    seguir = Console.ReadLine();
                    if (seguir == "n") break;
                }
            }
            Console.WriteLine("\nSu puntaje fue: " + total);
        }
    }
}
