using System;

namespace RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {

            int larg, resul, h;
            int v1 = 1;
            int v2 = 1;

            bemVindo();

            comanda("Insira a altura (1 e 10): ");
            h = Convert.ToInt32(Console.ReadLine());

            comanda("Insira a largura (1 e 10): ");
            larg = Convert.ToInt32(Console.ReadLine());

            if(h < 1 || larg < 1 || h > 10 || larg > 10)
            {
                Console.WriteLine();
                Console.WriteLine("Digite valores entre 01 e 10.");
                Environment.Exit(-1);
            }

            resul = h * larg;

            exibicaoResul(h, larg, resul);

            comanda("Ilustração: ");
            Console.WriteLine();

            while (v2 <= larg)
            {
                while (v1 <= h)
                {
                    if (v2 == larg || v1 == 1 || v1 == h || v2 == 1)
                    {
                        Console.Write(" * ");
                    }

                    else
                    {
                        Console.Write("   ");
                    }

                    v1++;
                }

                v1 = 1;
                v2++;
                Console.WriteLine();
            }

        }

        static void bemVindo()
        {
            DateTime agora = DateTime.Now;
            Console.WriteLine();
            Console.WriteLine($"Olá!             {agora}");
            Console.WriteLine();

            Console.WriteLine("RetContorno");
            Console.WriteLine("- Exibição do contorno de um retângulo, com altura e largura digitados pelo usuário (entre 1 e 10).");           
        }

        static void comanda(string a)
        {
            Console.WriteLine();
            Console.Write($"{a}", "/n");
        }

        static void exibicaoResul(int h, int larg, int resul)
        {
            Console.WriteLine();
            Console.WriteLine($"--> Altura: {h}");
            Console.WriteLine($"--> Largura: {larg}");
            Console.WriteLine($"--> Área: {resul}");
        }
    }
}
