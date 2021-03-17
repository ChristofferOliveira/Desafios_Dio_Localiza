using System;

namespace Desafios_Dio_Bootcamp_Localiza.Desafios_Aritméticos_C_sharp
{
    class Media
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double pesoA = 3.5;
            double pesoB = 7.5;
            double media;

            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            
            media = ((A * 3.5) + (B * 7.5)) / (pesoA + pesoB);
            
            Console.WriteLine($"MEDIA = {(string.Format("{0:0.00000}", media))}");
        }
    }
}
