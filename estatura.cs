using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Netzuko", "Tanjiro", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 164.5, 164, 180, 156, 176 };

            for (int c = 0; c < estatura.Length; c++)
            {

                for (int j = 0; j < estatura.Length; j++)
                {

                    for (int i = 0; i < estatura.Length - 1; i++)
                    {
                        if (estatura[i] > estatura[i + 1])
                        {
                            double tmp1 = estatura[i];
                            estatura[i] = estatura[i + 1];
                            estatura[i + 1] = tmp1;

                            string tmp2 = nombres[i];
                            nombres[i] = nombres[i + 1];
                            nombres[i + 1] = tmp2;
                        }
                    }
                }
                Console.WriteLine(estatura[c] + " " + nombres[c]);
            }
        }
    }
}
    

