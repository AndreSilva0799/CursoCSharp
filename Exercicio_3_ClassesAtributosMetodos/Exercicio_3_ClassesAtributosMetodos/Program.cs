using System.Globalization;

namespace Exercicio_3_ClassesAtributosMetodos
{
    class Exercicio_3_ClassesAtributosMetodos 
    {
        static void Main(string[] args) 
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno: ");
            aluno.Nota_1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aluno.Nota_2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aluno.Nota_3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            aluno.CalculoSemestres();

        }
    }
}