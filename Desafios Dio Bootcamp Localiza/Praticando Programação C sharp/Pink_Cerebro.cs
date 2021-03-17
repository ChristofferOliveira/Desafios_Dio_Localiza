using System;

namespace Desafios_Dio_Bootcamp_Localiza.Praticando_Programação_C_sharp
{
    class Pink_Cerebro
    {
        public static void Main(string[] args)
        {
            int qtdMultiplo2 = 0, qtdMultiplo3 = 0, qtdMultiplo4 = 0, qtdMultiplo5 = 0;
            int numero;

            var qtdElementos = int.Parse(Console.ReadLine());
            string[] elementos = Console.ReadLine().Split();

            foreach (var elemento in elementos)
            {
                numero = int.Parse(elemento);

                if (numero % 2 == 0)
                {
                    qtdMultiplo2++;
                }
                if (numero % 3 == 0)
                {
                    qtdMultiplo3++;
                }
                if (numero % 4 == 0)
                {
                    qtdMultiplo4++;
                }
                if (numero % 5 == 0)
                {
                    qtdMultiplo5++;
                }
            }

            Console.WriteLine("{0} Multiplo(s) de 2", qtdMultiplo2);
            Console.WriteLine("{0} Multiplo(s) de 3", qtdMultiplo3);
            Console.WriteLine("{0} Multiplo(s) de 4", qtdMultiplo4);
            Console.WriteLine("{0} Multiplo(s) de 5", qtdMultiplo5);
        }
    }
}
