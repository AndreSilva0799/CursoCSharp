using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1_ClassesAtributosMetodos
{
    internal class Retangulo
    {
        public double Altura;
        public double Largura;

        public double CalculoArea()
        {
            return this.Largura * this.Altura;
        }

        public double Perimetro()
        {
            return 2 * (this.Altura + this.Largura);
        }

        public double CalculoDiagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

    }
}
