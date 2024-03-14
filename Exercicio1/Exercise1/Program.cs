using System;

namespace Program
{
    class MyClass
    {
        static void Main(string[] args)
        {
            float coefA = 0.0F, coefB = 0.0F, coefC = 0.0F;

            Console.WriteLine("\nEntre com um valor para o Coeficiente A: ");
            coefA = float.Parse(Console.ReadLine()!);

            Console.WriteLine("\nEntre com um valor para o Coeficiente B: ");
            coefB = float.Parse(Console.ReadLine()!);

            Console.WriteLine("\nEntre com um valor para o Coeficiente C: ");
            coefC = float.Parse(Console.ReadLine()!);

            Console.Clear();

            Bhaskara(coefA, coefB, coefC);
        }

        static void Bhaskara(float a, float b, float c)
        {
            float delta = 0.0F;
            float raiz1 = 0.0F, raiz2 = 0.0F;

            if (a > 0)
            {
                delta = (float)Math.Pow(b, 2) - (4 * a * c);

                if (delta > 0)
                {
                    raiz1 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
                    raiz2 = (-b - (float)Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine($"--> Raiz 01: {raiz1}.");
                    Console.WriteLine($"--> Raiz 02: {raiz2}.");

                }
                else if (delta == 0)
                {
                    raiz1 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
                    raiz2 = (-b - (float)Math.Sqrt(delta)) / (2 * a);

                    if (raiz1 == raiz2) Console.WriteLine($"\n--> As raizes sao iguais e possuem valor igual a {raiz1}");
                }
                else
                {
                    Console.WriteLine("\n--> A equacao nao possui raizes reais.");
                }
            }
            else
            {
                Console.WriteLine("\n--> Nao e uma funcao do segundo grau.");
            }

        }
    }
}