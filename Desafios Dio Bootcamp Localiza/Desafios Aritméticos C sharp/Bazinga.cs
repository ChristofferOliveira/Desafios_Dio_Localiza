using System;
using System.Collections.Generic;
using System.Text;

namespace Desafios_Dio_Bootcamp_Localiza.Desafios_Aritméticos_C_sharp
{
    class Bazinga
    {
        static void Main(string[] args)
        {

            int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2;
            for (int i = 1; i <= qtdTeste; i++)
            {
                string[] valores = Console.ReadLine().Split();
                v1 = valores[0];
                v2 = valores[1];
                if (((v1.CompareTo("tesoura") == 0) && (v2.CompareTo("papel") == 0)) || ((v1.CompareTo("papel") == 0) && (v2.CompareTo("pedra") == 0))
                    || ((v1.CompareTo("pedra") == 0) && (v2.CompareTo("lagarto") == 0)) || ((v1.CompareTo("lagarto") == 0) && (v2.CompareTo("Spock") == 0))
                    || ((v1.CompareTo("Spock") == 0) && (v2.CompareTo("tesoura") == 0)) || ((v1.CompareTo("tesoura") == 0) && (v2.CompareTo("lagarto") == 0))
                    || ((v1.CompareTo("lagarto") == 0) && (v2.CompareTo("papel") == 0)) || ((v1.CompareTo("papel") == 0) && (v2.CompareTo("Spock") == 0))
                    || ((v1.CompareTo("Spock") == 0) && (v2.CompareTo("pedra") == 0)) || ((v1.CompareTo("pedra") == 0) && (v2.CompareTo("tesoura") == 0)))
                    Console.WriteLine("Caso #{0}: Bazinga!", i);
                else if (v1.CompareTo(v2) == 0)
                    Console.WriteLine("Caso #{0}: De novo!", i);
                else
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
            }
        }
    }
}
