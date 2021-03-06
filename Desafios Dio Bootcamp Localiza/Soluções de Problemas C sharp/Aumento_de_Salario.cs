using System;
using System.Globalization;

namespace Desafios_Dio_Bootcamp_Localiza.Soluções_de_Problemas_C_sharp
{
    class Aumento_de_Salario
    {
        class minhaClasse

        {

            static void Main(string[] args)

            {

                double salario = -10;
                double novoSalario = 0.00;
                double reajuste = 0.00;
                double percentual = 0;

                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (salario < 0.00)
                {
                    return;
                }

                else if (salario <= 400.00)
                {
                    percentual = 15;
                    reajuste = salario * ((double)percentual / 100);
                    novoSalario = salario + reajuste;
                }

                else if (salario <= 800.00)
                {
                    percentual = 12;
                    reajuste = salario * ((double)percentual / 100);
                    novoSalario = salario + reajuste;
                }

                else if (salario <= 1200.00)
                {
                    percentual = 10;
                    reajuste = salario * ((double)percentual / 100);
                    novoSalario = salario + reajuste;
                }

                else if (salario <= 2000.00)
                {
                    percentual = 7;
                    reajuste = salario * ((double)percentual / 100);
                    novoSalario = salario + reajuste;
                }

                else
                {
                    percentual = 4;
                    reajuste = salario * ((double)percentual / 100);
                    novoSalario = salario + reajuste;
                }

                Console.WriteLine("Novo salario: {0}", novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: {0}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: {0} %", percentual);
            }

        }
    }
}
