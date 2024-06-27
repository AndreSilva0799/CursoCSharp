using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Construtor_This_Sobrecarga
{
    internal class Banco
    {
        private int _conta;
        private string _nome;
        private double _saldo;

        public Banco()
        {

            this._conta = 0;
            this._nome = null;
            this._saldo = 0.0;

        }

        public Banco(int conta, string nome, double deposito)
        {

            this._conta = conta;
            this._nome = nome;
            this._saldo = deposito;

        }

        public Banco(int conta, string nome)
        {

            this._conta = conta;
            this._nome = nome;
            this._saldo = 0.0;

        }

        public int Conta
        {
            get { return _conta; }
            set
            {
                if (value != null && value > 1)
                {
                    _conta = value;
                }
            }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if
                        (value != null && value.Length > 1)
                {
                    _nome = value;
                }

            }

        }

        public void SetSaldo(double saldo)
        {
            this._saldo = saldo;
        }

        public double GetSaldo()
        {
            return _saldo;
        }

        public override string ToString()
        {
            return "Conta " + _conta + ", Titular: " + _nome + ", Saldo: " + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
