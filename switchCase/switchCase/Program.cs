﻿internal class Program
{
    private static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());

        string day = "";

        switch (x) {
            case 1:
                day = "Domingo";
                break;
            case 2:
                day = "Segunda";
                break;

            case 3:
                day = "Terca";
                break;

            case 4:
                day = "Quarta";
                break;
            
            case 5:
                day = "Quinta";
                break;

            case 6:
                day = "Sexta";
                break;
            
            case 7:
                day = "Sabado";
                break;

        }
        
        Console.WriteLine("Dia = " + day);

    }
}

