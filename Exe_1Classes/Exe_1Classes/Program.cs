namespace Exe_1Classes;
class Program
{
    static void Main(string[] args)
    {
        Pessoas a, b;
        a=new Pessoas();
        b=new Pessoas();
        Console.WriteLine("Dados da primeira pessoa");
        a.name = Console.ReadLine();
        a.idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados da segunda pessoa");
        b.name = Console.ReadLine();
        b.idade = int.Parse(Console.ReadLine());

        if (a.idade > b.idade)
        {
            Console.WriteLine("Pessoa mais velha: {0}", a.name);
        }
        else {
            Console.WriteLine("Pessoa mais velha: {0}", b.name);
        }



    }
}