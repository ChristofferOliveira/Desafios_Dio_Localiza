using System;

namespace Desafios_Dio_Bootcamp_Localiza.Praticando_Programação_C_sharp
{
    class Coordenadas_Ponto
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            double x = double.Parse(tokens[0]);
            double y = double.Parse(tokens[1]);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
