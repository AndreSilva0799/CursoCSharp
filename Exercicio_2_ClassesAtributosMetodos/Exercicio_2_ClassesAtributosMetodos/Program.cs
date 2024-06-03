using System.Globalization;

namespace Exercicio_2_ClassesAtributosMetodos;
class Program {
    static void Main(string[] args)
    {
        Funcionario f = new Funcionario();
        Console.Write("Nome: ");
        f.Nome = Console.ReadLine();
        Console.Write("Salario bruto: ");
        f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Imposto: ");
        f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Funcionario: " + f);
        Console.Write("Digite a porcentagem pra aumentar o salário: ");
        double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        f.AumentarSalario(percent);
        Console.WriteLine("Dados Atualizados: " + f);
    }
}