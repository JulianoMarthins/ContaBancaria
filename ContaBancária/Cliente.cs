using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancária {
    internal class Cliente {

        public string nome{ get; set; }
        private double saldo;
        private int numConta = 1001;


        public Cliente(string nome, double deposito) {
            this.nome = nome;
            this.saldo = deposito;
            this.numConta = this.numConta += 10;
        }

        public double Deposito(double valor) {
            this.saldo += valor;
            return this.saldo;

        }

        public double Saque(double valor) {

            if(this.saldo >= valor + 5.0){
                this.saldo -= (valor + 5.0);
            }
            else {
                this.saldo -= (valor + 5.0) ;
            }

            return this.saldo;
        }

        public string ToString() {
            string saldoFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", this.saldo);
            return $"\n\n<<<<<Extrato>>>>>\nNúmero da conta: {numConta}\nNome: {this.nome}\nSaldo: {saldoFormatado}\n";
        }

    }
}
