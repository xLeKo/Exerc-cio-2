using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caixa eletrônico do Lekinho");

            int n1 = 0;
            int n2 = 0;
            int n5 = 0;
            int n10 = 0;
            int n20 = 0;
            int n50 = 0;
            int n100 = 0;

            Console.WriteLine("Digite o valor do saque: ");

            int saque = int.Parse(Console.ReadLine());

            while (saque > 0)
            {
                if (saque >= 100)
                {
                    saque -= 100;
                    n100++;
                }
                else
                {
                    if (saque >= 50)
                    {
                        saque -= 50;
                        n50++;
                    }
                    else
                    {
                        if (saque >= 20)
                        {
                            saque -= 20;
                            n20++;
                        }
                        else
                        {
                            if (saque >= 10)
                            {
                                saque -= 10;
                                n10++;
                            }
                            else
                            {
                                if (saque >= 5)
                                {
                                    saque -= 5;
                                    n5++;
                                }
                                else
                                {
                                    if (saque >= 2)
                                    {
                                        saque -= 2;
                                        n2++;
                                    }
                                    else
                                    {
                                        saque -= 1;
                                        n1++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            for (int i = 7; i > 0; i--)
            {
                switch (i)
                {
                    case 1:
                        if (n1 > 0)
                            Console
                                .WriteLine("Quantidade de notas de 1 real: " +
                                n1);
                        break;
                    case 2:
                        if (n2 > 0)
                            Console
                                .WriteLine("Quantidade de notas de 2 real: " +
                                n2);
                        break;
                    case 3:
                        if (n5 > 0)
                            Console
                                .WriteLine("Quantidade de notas de 5 real: " +
                                n5);
                        break;
                    case 4:
                        if (n10 > 0)
                            Console
                                .WriteLine("Quantidade de notas de 10 real: " +
                                n10);
                        break;
                    case 5:
                        if (n20 > 0)
                            Console
                                .WriteLine("Quantidade de notas de 20 real: " +
                                n20);
                        break;
                    case 6:
                        if (n50 > 0)
                            Console
                                .WriteLine("Quantidade de notas de 50 real: " +
                                n50);
                        break;
                    case 7:
                        if (n100 > 0)
                            Console
                                .WriteLine("Quantidade de notas de 100 real: " +
                                n100);
                        break;
                }
            }
        }
    }
}
