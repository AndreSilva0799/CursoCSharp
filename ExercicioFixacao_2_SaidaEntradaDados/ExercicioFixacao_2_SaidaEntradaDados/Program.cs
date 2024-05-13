using System;
using System.Globalization;
namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string _name = Console.ReadLine();

            Console.WriteLine("{0} quantos quartos tem na sua casa ?", _name);

            int _qtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} sua casa tem {1} quartos ", _name, _qtdQuartos); //imprimindo na tela usando placeholder

            Console.WriteLine("Entre com o preço de um produto");

            double _precoProduto = double.Parse(Console.ReadLine());

            Console.WriteLine(" Produto custa {0:F2}", _precoProduto);

            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha)");

            string[] _text = Console.ReadLine().Split(' '); // aqui estou fazendo um vetor e separando em variaveis o que esta na separação com ' '
            string _lastName = _text[0];
            int _year = int.Parse(_text[1]);
            double _heigth = double.Parse(_text[2]);

            Console.WriteLine(_lastName);
            Console.WriteLine(_year);
            Console.WriteLine(_heigth);
         



        }
    }
}