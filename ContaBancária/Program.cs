using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancária {
    internal class Program {
        static void Main(string[] args) {

       

            Console.WriteLine("   Programado por JulianoMarthins\n\n");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n\n");

            Console.WriteLine("Digite os dados do cliente: ");
            
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Deseja realizar deposito inicial: [S/N] ");
            string opcao = Console.ReadLine().ToLower();


            double valor = 0.0;
            if(opcao == "s") {
                Console.Write("\nDigite o valor de deposito: ");
                valor = double.Parse(Console.ReadLine());

            }
         

            Cliente cliente = new Cliente(nome, valor);

            Console.WriteLine("\nCliente cadastrado com sucesso");
            Console.WriteLine(cliente.ToString());

            Console.Write("\nDigite o valor para deposito: ");
            valor = double.Parse(Console.ReadLine());

            cliente.Deposito(valor);
            Console.WriteLine("\n" + cliente.ToString());

            Console.WriteLine("\nDigite o valor de saque: ");
            valor = double.Parse(Console.ReadLine());

            cliente.Saque(valor);

            Console.WriteLine("\n" + cliente.ToString());



        }
    }
}
