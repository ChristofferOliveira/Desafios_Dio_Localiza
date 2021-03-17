using System;

namespace Desafios_Dio_Bootcamp_Localiza.Desafios_Aritméticos_C_sharp
{
    class Comunicacao_Piralandia
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            char[] caracters = n.ToCharArray();

            for (int i = 1; i <= caracters.Length; i++)
            {
                Console.Write(caracters[caracters.Length - i]);
            }
        }
    }
}
