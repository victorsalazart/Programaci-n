using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            bool gameover = false;
            int carta1 = aleatorio.Next(1, 11);
            int carta2 = aleatorio.Next(1, 11);
            int baraja = 0, total = (carta1 + carta2); ;
            Console.Write(" carta1: " + carta1);
            Console.Write(" carta2: " + carta2);
            Console.Write(" Total: " + total);

            while (21 > total && gameover != true)
            {
                Console.WriteLine(" ¿Deseas otra carta? ");
                string si = Console.ReadLine();

                if (si == "s")
                {
                    baraja = aleatorio.Next(1, 11);
                    total += baraja;
                    Console.Write(" Carta = " + baraja);
                    Console.Write(" Total = " + total);
                }
                else if (si == "n")
                {
                    Console.Write(" (Perdiste) ");
                    gameover = true;
                }

            }
            if (21 == total)
            {
                Console.WriteLine(" (ganaste) ");
            }
            else if (total > 21)
            {
                Console.WriteLine(" (perdiste) ");
            }

            Console.WriteLine(" total: " + total);
            Console.WriteLine(" Gracias por jugar ");
        }
    }
}
