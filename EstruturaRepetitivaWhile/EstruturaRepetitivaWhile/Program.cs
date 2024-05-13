using System;
using System.Globalization;

namespace EstruturaRepetitivaWhile // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double _numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (_numero >= 0)
            {

                double _raiz = Math.Sqrt(_numero);
                Console.WriteLine(_raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                _numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("{0} Número Negativo", _numero);
        }
    }
}