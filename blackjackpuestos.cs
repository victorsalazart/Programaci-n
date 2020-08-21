using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		Random aleatorio = new Random();
		int carta1 = 0, carta2 = 0, nuevacarta = 0, total = 0, jugadores = 0;
		int n = 0, maximo = 0, ganador = 0;
		string continuar = "n";

		Console.WriteLine("Ingrese un número de jugadores min 2 max 5:");
		n = int.Parse(Console.ReadLine());

		while (n < 2 || n > 5)
		{
			Console.WriteLine("Error, mínimo 2 jugadores y máximo 5; ");
			n = int.Parse(Console.ReadLine());
		}

		string[] players = new string[n];
		int[] puntajes = new int[n];

		while (jugadores < n)
		{


			Console.WriteLine("Inicio de juego");

			Console.WriteLine("Bienvenido jugador " + (jugadores+1));

			Console.WriteLine("Ingrese su nombre: ");
			string nombre = Console.ReadLine();
			players[jugadores] = nombre;

			carta1 = aleatorio.Next(1, 10);
			carta2 = aleatorio.Next(1, 10);
			Console.WriteLine("Carta 1 = " + carta1);
			Console.WriteLine("Carta 2 = " + carta2);
			total = carta1 + carta2;
			Console.WriteLine("Total = " + total);

			Console.Write("Desea tomar otra carta? (s/n): ");
			continuar = Console.ReadLine();		

			if (total > maximo && total <= 21)
			{
				maximo = total;
				ganador = jugadores;
			}


			while (continuar == "s")
			{
				nuevacarta = aleatorio.Next(1, 11);
				Console.WriteLine("Carta = " + nuevacarta);
				total += nuevacarta;
				Console.WriteLine("Total = " + total);

				if (total > 21)
				{
					Console.WriteLine("Eliminado");
					total = 0;
					continuar = "n";
				}

				else
				{
					Console.Write("Desea otra carta? (s/n): ");
					continuar = Console.ReadLine();
				}

				if (total > maximo && total <= 21)
				{
					maximo = total;
					ganador = jugadores;
				}			
			}

			puntajes[jugadores] = total;
			jugadores++;
		}

		for (int c = 0; c < players.Length; c++)
		{
			for (int j = 0; j < players.Length; j++)
			{
				for (int i = 0; i < players.Length - 1; i++)
				{
					if (puntajes[i] > puntajes[i + 1])
					{
						int tmp1 = puntajes[i + 1];
						puntajes[i + 1] = puntajes[i];
						puntajes[i] = tmp1;

						string tmp2 = players[i];
						players[i] = players[i + 1];
						players[i + 1] = tmp2;
					}
				}
			}
		}
		Console.WriteLine("El ganador fue " + players[n-1] + " con " + puntajes[n-1] + " puntos");
		Console.WriteLine("El segundo lugar fue " + players[n - 2] + " con " + puntajes[n - 2] + " puntos");
	}
}
