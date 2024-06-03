using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2_ClassesAtributosMetodos
{
    internal class Funcionario
    {
        public String Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() 
        {
            return this.SalarioBruto - this.Imposto;
        }

        public void AumentarSalario(double porcent) 
        {
           SalarioBruto *= (1 + porcent / 100);
        }


        public override string ToString() 
        {
            return this.Nome
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
                
        }

    }
}
