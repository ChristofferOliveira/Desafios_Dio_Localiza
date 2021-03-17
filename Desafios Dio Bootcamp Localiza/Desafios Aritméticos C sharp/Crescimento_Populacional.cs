using System;
using System.Collections.Generic;
using System.Text;

namespace Desafios_Dio_Bootcamp_Localiza.Desafios_Aritméticos_C_sharp
{
    class Crescimento_Populacional
    {
        static void Main(string[] args)
        {
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;

            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                string[] valores = Console.ReadLine().Split();
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

                cpa = double.Parse(valores[2]);
                cpb = double.Parse(valores[3]);

                while (pa <= pb)
                {
                    pa = (int)(pa * (1 + (cpa / 100)));
                    pb = (int)(pb * (1 + (cpb / 100)));
                    anos++;

                    if (anos > 100)
                    {                        
                        Console.WriteLine("Mais de 1 seculo.");
                        break;
                    }
                }

                if (anos <= 100)
                {
                    Console.WriteLine(anos + " anos.");
                }
            }
        }
    }
}
