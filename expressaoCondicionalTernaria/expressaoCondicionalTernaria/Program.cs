using System;
using System.Globalization;

namespace expressaoCondicionalTernaria // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // se preço menor que 20 pega o valor antes dos dois pontos se for maior pega o valor depois dos dois pontos
            // ou seja se a condição for verdadeira pega o primeiro valor se a condição for falsa o segundo valor.
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.5;

            if (preco < 20) {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.5;
            }
            Console.WriteLine(desconto);
        }
    }
}