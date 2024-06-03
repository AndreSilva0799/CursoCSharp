using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3_ClassesAtributosMetodos
{
    internal class Aluno
    {
        public string Nome;
        public double Nota_1;
        public double Nota_2;
        public double Nota_3;

        public void CalculoSemestres()
        {
            double soma = Nota_1 + Nota_2 + Nota_3;
            if (soma >= 60.00) 
            {
                Console.WriteLine("NOTA FINAL: " + soma.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");
            }
            else if (soma < 60.00)
            {
                Console.WriteLine("NOTA FINAL: " + soma.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
                double falta = 60.00 - soma;
                Console.WriteLine( "FALTARAM {0} PONTOS", falta.ToString("F2", CultureInfo.InvariantCulture));
            }
        }

    }
}
