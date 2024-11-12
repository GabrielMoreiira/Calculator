using System;
using System.Data;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            static void Menu()
            {
                Console.Clear();
                Console.WriteLine("Digite a funcao que deseja");
                Console.WriteLine("1 - soma");
                Console.WriteLine("2 - Multiplicacao");
                Console.WriteLine("3 - Divisao");
                Console.WriteLine("4 - Subtracao");
                Console.WriteLine("-------------------");
                short res = short.Parse(Console.ReadLine());
                switch (res)
                {
                    case 1: Soma(); break;
                    case 2: Multiplicacao(); break;
                    case 3: Divisao(); break;
                    case 4: Subtracao(); break;
                    default: Menu(); break;
                }
            }

            static void Soma()
            {
                Console.Clear();
                Console.WriteLine("Soma!");
                Console.WriteLine("Digite o primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                float soma = v1 + v2;

                Console.WriteLine($"O valor total e de : {soma}");
                Console.ReadKey();
                Menu();
            }
            static void Subtracao()
            {
                Console.Clear();
                Console.WriteLine("Subtracao!");
                Console.WriteLine("Digite o primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                float resultado = v1 - v2;

                Console.WriteLine($"O resultado da substracao e {resultado}");
                Console.ReadKey();
                Menu();

            }
            static void Divisao()
            {
                Console.Clear();
                Console.WriteLine("Divisao!");
                Console.WriteLine("Digite o primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                float resultado = v1 / v2;

                Console.WriteLine($"O resultado da divisao e {resultado}");
                Console.ReadKey();
                Menu();
            }
            static void Multiplicacao()
            {
                Console.Clear();
                Console.WriteLine("Multiplicacao!");
                Console.WriteLine("Digite o primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                float resultado = v1 * v2;

                Console.WriteLine($"O resultado da multiplicacao e {resultado}");
                Console.ReadKey();

                Menu();
            }
        }
    }
}