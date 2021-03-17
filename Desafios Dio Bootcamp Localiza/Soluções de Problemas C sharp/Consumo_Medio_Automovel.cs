using System;

namespace Desafios_Dio_Bootcamp_Localiza.Soluções_de_Problemas_C_sharp
{
    class Consumo_Medio_Automovel
    {

        static void Main(string[] args)

        {
            int Distancia;
            double CombustivelConsumido, Media;

            Distancia = int.Parse(Console.ReadLine());
            CombustivelConsumido = double.Parse(Console.ReadLine());

            Media = Distancia / CombustivelConsumido;

            Console.WriteLine("{0:0.000} km/l", Media);
        }

    }
}
