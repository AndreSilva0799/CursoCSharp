using System;
using System.Globalization;

namespace Exercicio_Construtor_This_Sobrecarga // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco b = new Banco();
            Console.Write("Entre com o numero da Conta: ");
            int conta = int.Parse(Console.ReadLine());


            Console.Write("Entre com o titular da Conta: ");
            string nome = Console.ReadLine();

            Console.Write("Havera deposito inicial responda 's' ou 'n': ");

            string opcao = Console.ReadLine();
            double deposito;

            switch (opcao.ToLower())
            {
                case "s":

                    Console.Write("Entre o valor de deposito inicial:");
                     deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    b = new Banco(conta, nome, deposito);

                    break;


                case "n":
                    Console.WriteLine("Teste 2");
                    break;
            }

            Console.WriteLine(b);

            Console.Write("Entre um valor do depósito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

        }
    }
}