using System.Globalization;

namespace Exercicio_1_ClassesAtributosMetodos;
class Program
{
    static void Main(string[] args)
    {
        Retangulo r = new Retangulo();

        Console.WriteLine("Entre a largura a altura do retângulo: ");
        r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("AREA = " + r.CalculoArea().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Primetro = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Primetro = " + r.CalculoDiagonal().ToString("F2", CultureInfo.InvariantCulture));
    }
}
