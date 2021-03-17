using System;
using System.Linq;

namespace Desafios_Dio_Bootcamp_Localiza.Praticando_Programação_C_sharp
{
    class Compras_Supermercado
    {
        public static void Main(string[] args)
        {
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalDeCasosDeTeste; i++)
            {
                string[] itens = Console.ReadLine().Split();
                var semDuplicados = itens.Distinct();
                var ordemAlfabetica = semDuplicados.OrderBy(String => String);

                foreach (var item in ordemAlfabetica)
                {
                    Console.Write("{0} ", item);
                }

                Console.WriteLine("");
            }
        }
    }
}
