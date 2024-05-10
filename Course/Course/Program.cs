﻿using System;
using System.Globalization;
namespace PrimeiroProjeto
 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // aqui para poder digitar com ponto e sair como virgula 
            String[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome.ToString());
            Console.WriteLine(sexo.ToString());
            Console.WriteLine(idade.ToString());
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}