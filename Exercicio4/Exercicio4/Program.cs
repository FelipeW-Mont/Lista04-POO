using System;

namespace Program
{
    class MyClass
    {
        enum Figuras
        {
            triangulo,
            circulo,
            trapezio,
            quadrado,
            retangulo
        }

        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Figuras figura = new Figuras();
            ushort num = 0;
            const double PI = 3.14159;
            double a = 0.0D, b = 0.0D, c = 0.0D, resultado = 0.0D;
            string txt = " ";

            do
            {
                if (a == 0 || b == 0 || c == 0) Console.WriteLine("\nOBS: Nenhum dos valores pode ser negativo ou igual a zero.\n");

                Console.WriteLine("\nInsira o valor para A:");
                a = double.Parse(Console.ReadLine()!);

                Console.WriteLine("\nInsira o valor para B:");
                b = double.Parse(Console.ReadLine()!);

                Console.WriteLine("\nInsira o valor para C:");
                c = double.Parse(Console.ReadLine()!);

                Console.Clear();

            } while (a == 0 || b == 0 || c == 0);

            do {
                Opcoes();
                Console.WriteLine("Insira o calculo de area desejado:");
                num = ushort.Parse(Console.ReadLine()!);

                Console.Clear();

                switch (num) 
                { 
                    case 0:
                        {
                            resultado = AreaTrianguloRetangulo(a, c);
                            figura = Figuras.triangulo;
                        }
                        break;
                    case 1:
                        {
                            resultado = AreaCirculo(c, PI);
                            figura = Figuras.circulo;
                        }
                        break;
                    case 2:
                        {
                            resultado = AreaTrapezio(a, b, c);
                            figura = Figuras.trapezio;
                        }
                        break;
                    case 3:
                        {
                            resultado = AreaQuadrado(b);
                            figura = Figuras.quadrado;
                        }
                        break;
                    case 4:
                        {
                            resultado = AreaRetangulo(a, b);
                            figura = Figuras.retangulo;
                        }
                        break;
                    case 5:
                        MostrarLista(list);
                        break;
                    case 6:
                        Console.WriteLine("\n+==== Voce acabou de sair do programa, obrigado por utiliza-lo ====+\n");
                        break;
                    default: 
                        Console.WriteLine("Calculo nao encontrado, tente novamente!");
                        break;
                }

                txt = $"--> Area do {figura} = {Math.Round(resultado,2)}";

                if (!list.Contains(txt))
                {
                    list.Add(txt);
                }

            } while(num != 6);

            MostrarLista(list);
        }

        static void Opcoes() 
        {
            Console.WriteLine("\nEscolha uma das opcoes: ");
            Console.WriteLine("[0] - Area do Triangulo Retangulo");
            Console.WriteLine("[1] - Area do Circulo");
            Console.WriteLine("[2] - Area do Trapezio");
            Console.WriteLine("[3] - Area do Quadrado");
            Console.WriteLine("[4] - Area do Retangulo");
            Console.WriteLine("[5] - Exibir lista");
            Console.WriteLine("[6] - Sair\n");
        }

        static void MostrarLista(List<string>list)
        {
            Console.WriteLine("\nLista com os valores de area obtidos:\n");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
        }

        static double AreaTrianguloRetangulo(double a, double b) => (a * b) / 2;
        static double AreaCirculo(double c, double PI) => Math.Pow(c, 2) * PI;
        static double AreaTrapezio(double a, double b, double c) => ((a * b) * c) / 2;
        static double AreaQuadrado(double b) => Math.Pow(b, 2);
        static double AreaRetangulo(double a, double b) => b * a;
    }
}