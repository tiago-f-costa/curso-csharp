using System;
using System.Globalization;

namespace Calculadora {
    class Program {
        static void Main(string[] args) {

            int x;

            do {
                Console.WriteLine(" ====== Calculadora de Operações Simples =======");
                Console.WriteLine();
                Console.Write("-> Digite o Primeiro Número: ");
                double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("-> Digite o Segundo  Número: ");
                double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                Console.WriteLine(" === Informe qual operação deseja realizar: ");
                Console.WriteLine("A - Adição");
                Console.WriteLine("S - Subtração");
                Console.WriteLine("M - Multiplicação");
                Console.WriteLine("D - Divisão");
                Console.Write("Informe a opção desejada: ");
                char opcao = char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine();
                switch (opcao) {

                    case 'A':
                        Console.WriteLine("Adição = " + Calculo.Calculos('A', n1, n2).ToString("F2", CultureInfo.InvariantCulture));
                        break;

                    case 'S':
                        Console.WriteLine("Subtração = " + Calculo.Calculos('S', n1, n2).ToString("F2", CultureInfo.InvariantCulture));
                        break;

                    case 'M':
                        Console.WriteLine("Multiplicação = " + Calculo.Calculos('M', n1, n2).ToString("F2", CultureInfo.InvariantCulture));
                        break;

                    case 'D':
                        Console.WriteLine("Divisão = " + Calculo.Calculos('D', n1, n2).ToString("F2", CultureInfo.InvariantCulture));
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine();
                Console.Write("Digite 1 para prosseguir ou qualquer tecla para sair: ");
                x = int.Parse(Console.ReadLine());

            }while (x == 1) ;

        }
    }
}
