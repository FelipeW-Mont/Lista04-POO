using System;

namespace Program
{
    class MyClass
    {
        static void Main(string[] args)
        {
            string nome = " ";
            string sobrenome = " ";
            char genero = ' ';
            int horario = 0;

            Console.WriteLine("\nDigite seu primeiro nome: ");
            nome = Console.ReadLine()!;

            Console.WriteLine("\nDigite seu sobrenome: ");
            sobrenome = Console.ReadLine()!;

            Console.WriteLine("\nDigite sua orientação sexual [M - Masculino] ou [F - Feminino]: ");
            genero = char.Parse(Console.ReadLine()!);

            Console.WriteLine("\nDigite o horario [Apenas em horas] no qual esta digitando [Formato 24h]: ");
            horario = int.Parse(Console.ReadLine()!);

            Console.Clear();

            Saudacao(nome, sobrenome, genero, horario);
        }

        static void Saudacao(string nome, string sobrenome, char genero, int horario)
        {
            string tratamento = " ";
            string periodoDia = " ";

            tratamento = (genero.Equals('M') || genero.Equals('m'))
                ? "Sr."
                : "Sra.";

            if (horario >= 6 && horario <= 12) 
            {
                periodoDia = "Bom dia";
            } else if (horario > 12 && horario <= 18)
            {
                periodoDia = "Boa tarde";
            }
            else
            {
                periodoDia = "Boa noite";
            }

            Console.WriteLine($"\n{periodoDia} {tratamento} {nome} {sobrenome}.");
        }
    }
}