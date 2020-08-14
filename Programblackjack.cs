using System;


class Program
{
    static void Main(string[] args)
    {
        Random Aleatorio = new Random();
        int cartas, total = 0, jugadores, contador = 1, max = 0;

        string seguir = "s", nombre = " ", nombreganador = " ";

        Console.WriteLine("¿Cuantos van a jugar?: min 2, max 5 jugadores");
        jugadores = int.Parse(Console.ReadLine());
        


        while (jugadores < 2 || 5 < jugadores)
        {
            Console.WriteLine("Minimo 2, máximo 5. ingrese nuevamente el # de jugadores ");
            jugadores = int.Parse(Console.ReadLine());
        }



        
        while (contador <= jugadores)
        {
            Console.WriteLine("\nJugador : " + contador);
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            cartas = Aleatorio.Next(1, 11);
            total += cartas;
            Console.WriteLine("\nCarta 1 : "+ cartas);

            

            while (total < 22 && seguir == "s")
            {
                cartas = Aleatorio.Next(1, 11);
                total += cartas;
                Console.Write("Carta 2: " + cartas);
                Console.WriteLine("\nTotal  : " + total);

                if (total > 21)
                {
                    Console.Write(" Haz sido eliminado! ");
                    Console.Write(" Su total fue : " + total);
                    total = 0;
                    break;
                }
                else
                {
                    Console.Write("Desea seguir jugando? (s/n)");
                    if (total <= 21 && (max <= total))
                    {
                        max = total;
                        nombreganador = nombre;
                    }
                    if (Console.ReadLine() != "s")
                    {
                        total = 0;
                        break;
                    }
                }
            }
            contador++;
        }
        Console.WriteLine("\n El ganador es: " + nombreganador);
    }
}