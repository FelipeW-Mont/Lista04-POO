using System;

namespace Program
{
    class MyClass
    {
        enum Cargo
        {
            diretor,
            gerente,
            coordenador,
            analista,
            assistente,
            auxiliar
        }
        static void Main(string[] args)
        {
            Dictionary<uint, string> dicFuncionarios = new Dictionary<uint, string>();
            string txt = " ";

            Cargo cargoFuncionario = new Cargo();
            uint numeroMatricula = 0, seletor = 0;
            ushort cargaHorariaMensal = 0, numeroFuncionarios = 0;
            float valorRecebidoHora = 0.0F, salarioMensal = 0.0F;

            Console.WriteLine("Insira o numero de funcionarios a serem cadastrados: ");
            numeroFuncionarios = ushort.Parse(Console.ReadLine()!);

            Console.Clear();

            for (ushort i = 0; i < numeroFuncionarios; i++)
            {
                Numeracao(i);

                Console.WriteLine("Insira o numero de matricula do funcionario: ");
                numeroMatricula = uint.Parse(Console.ReadLine()!);

                Console.WriteLine("Insira a carga horaria do funcionarios [mensal]: ");
                cargaHorariaMensal = ushort.Parse(Console.ReadLine()!);

                Console.WriteLine("Insira o valor por hora recebido pelo funcionarios: ");
                valorRecebidoHora = float.Parse(Console.ReadLine()!);

                do
                {
                    ListaCargos();

                    Console.WriteLine("Qual o cargo desse funcionario [0 - 5]?");
                    seletor = uint.Parse(Console.ReadLine()!);

                    Console.Clear();
                } while (seletor < 0 || seletor > 5);

                switch (seletor)
                {
                    case 0:
                        cargoFuncionario = Cargo.diretor;
                        break;
                    case 1:
                        cargoFuncionario = Cargo.gerente;
                        break;
                    case 2:
                        cargoFuncionario = Cargo.coordenador;
                        break;
                    case 3:
                        cargoFuncionario = Cargo.analista;
                        break;
                    case 4:
                        cargoFuncionario = Cargo.assistente;
                        break;
                    case 5:
                        cargoFuncionario = Cargo.auxiliar;
                        break;
                }

                salarioMensal = cargaHorariaMensal * valorRecebidoHora;

                txt = $"{cargoFuncionario} trabalha {cargaHorariaMensal}h mensalmente e recebe em media {salarioMensal.ToString("C")}.";

                dicFuncionarios.Add(numeroMatricula, txt);
            }

            Console.WriteLine("\nLista de funcionanrios:\n");
            foreach (KeyValuePair<uint, string> funcionario in dicFuncionarios)
            {
                Console.WriteLine($"{funcionario.Key}: {funcionario.Value}");
            }
        }

        static void ListaCargos()
        {
            Console.WriteLine("\n[0] - Diretor");
            Console.WriteLine("[1] - Gerente");
            Console.WriteLine("[2] - Coordenador");
            Console.WriteLine("[3] - Analista");
            Console.WriteLine("[4] - Assistente");
            Console.WriteLine("[5] - Auxiliar\n");
        }

        static void Numeracao(int numero) 
        {
            Console.WriteLine("\n=============================================");
            Console.WriteLine($" Cadastro do Funcionario [{numero}]:");
            Console.WriteLine("=============================================\n");
        }
    }
}