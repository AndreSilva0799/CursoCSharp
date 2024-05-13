using System;

namespace RepetitivaFor // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos números inteiros você vai digitar? ");
            int _numero = int.Parse(Console.ReadLine());
            int soma = 0;

           

            for (int i = 1; i <= _numero; i++) 
            {
                _numero += 1 - 1;
                
                Console.WriteLine("Digite o {0}º numero:", _numero);
                int _valor = int.Parse(Console.ReadLine());
                soma += _valor;
                Console.WriteLine("Valor #{0}: {1}", i, _valor);

            }

            Console.WriteLine("Soma {0}", soma);

        }
    }
}