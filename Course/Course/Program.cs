using System;
using System.Globalization;
namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';

            Console.WriteLine("char " + genero);

            char letra = '\u0041';

            Console.WriteLine("char Unicode " + letra);

            sbyte x = 100;

            Console.WriteLine("sbyte " + x);

            byte n1 = 126;

            Console.WriteLine("byte " + n1);

            int n2 = 1000;
            Console.WriteLine("int " + n2);

            int n3 = 2147443648;

            Console.WriteLine("int " + n3);

            long n4 = 2147443648L;

            Console.WriteLine("long " + n4);

            bool completo = false;

            Console.WriteLine("bool " + completo);

            float n5 = 4.5f; // para mostrar que é  um valor do tipo float devemos colocar um f no final do valor, para double é normal

            Console.WriteLine("float " + n5);

            double n6 = 4.5;

            Console.WriteLine("double " + n6);

            String text = "André";

            Console.WriteLine("String " + text);

            object obj1 = "Rayane Cagona";

            Console.WriteLine("Object_1 " + obj1);

            object obj2 = 4.5f;

            Console.WriteLine("Object_2 " + obj2);

            Console.WriteLine("Bom dia");

            Console.Write("tudo bem ?"); // imprimir na tela sem quebra de linha

            double saldo = 234.5544;
            Console.WriteLine(saldo.ToString("F2")); // para imprimir um valor double com 2 casas decimais
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture)); // para imprimir um valor double com o ponto ao inves da virgula (precisa chamar o using System.Globalization;)

            Console.WriteLine("************************************************************");

            Console.WriteLine();

            int idade = 32;
            double saldo2 = 10.35784;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais ", nome, idade, saldo2); // forma de imprimir a variavel usando placeholder

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo2:F2} reais"); // imprimir usando a interpolação 

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " +  saldo2.ToString("F2",CultureInfo.InvariantCulture) + " reais"); // usando a concatenação e usando o ponto no double ao inves da virgula
        }
    }
}