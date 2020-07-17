using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, x = 0, y = 1, z = 0; // z = resultado
            bool vlvalido; // vl = valor

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ----- FIBONACCI ----- \n");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Digite um número (inteiro >= 2): ");
            vlvalido = Int32.TryParse(Console.ReadLine(), out numero);

            if (!vlvalido || numero < 2)

            {
                Console.Write("Programa finalizado: número ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("INVÁLIDO.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Pressione enter.");
                Console.ReadKey();
                Environment.Exit(-1);
            }

            for (int finish = 0; finish < numero; finish++)

            {
                if (finish <= 1)
                {
                    z = finish;
                }
                else
                {
                    z = x + y;
                    x = y;
                    y = z;
                }

                Console.WriteLine(z);
            }

            Console.WriteLine("\nPressione enter para finalizar <3 ");
            Console.ReadKey();

        }
    }
}
