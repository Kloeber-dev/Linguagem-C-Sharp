using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9_Exercicio2
{
    class TesteExercicio2
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta();
            conta1.setAgencia("12345");
            conta1.setNumero(1);
            conta1.setSaldo(960);

            Conta conta2 = new Conta();
            conta1.setAgencia("67890");
            conta1.setNumero(7);
            conta1.setSaldo(1090);

            Conta conta3 = new Conta();
            conta1.setAgencia("13145");
            conta1.setNumero(9);
            conta1.setSaldo(1254);

            Cliente cliente1 = new Cliente();
            cliente1.setNome("Kleber");
            cliente1.setSobrenome("Souza");
            cliente1.setCpf("123.456.789-00");
            cliente1.setConta(conta1);

            Cliente cliente2 = new Cliente();
            cliente1.setNome("Vanessa");
            cliente1.setSobrenome("Sardinha");
            cliente1.setCpf("987.654.321-99");
            cliente1.setConta(conta2);

            Cliente cliente3 = new Cliente();
            cliente1.setNome("Pâmela");
            cliente1.setSobrenome("Sonsa");
            cliente1.setCpf("132.457.689-55");
            cliente1.setConta(conta3);

            Console.WriteLine("Cliente 1");
            Console.WriteLine("Nome: " + cliente1.getNome());
            Console.WriteLine("Sobrenome: " + cliente1.getSobrenome());
            Console.WriteLine("CPF: " + cliente1.getCpf());
            Console.WriteLine("Conta/nAgencia " + cliente1.getConta().getAgencia());
            Console.WriteLine("Numero " + cliente1.getConta().getNumero());
            Console.WriteLine("Saldo " + cliente1.getConta().getSaldo());


            Console.WriteLine("Cliente 2");
            Console.WriteLine("Nome: " + cliente2.getNome());
            Console.WriteLine("Sobrenome: " + cliente2.getSobrenome());
            Console.WriteLine("CPF: " + cliente2.getCpf());
            Console.WriteLine("Conta:  Agencia " + cliente2.getConta().getAgencia());
            Console.WriteLine("Numero " + cliente2.getConta().getNumero());
            Console.WriteLine("Saldo " + cliente2.getConta().getSaldo());

            Console.WriteLine("Cliente 3");
            Console.WriteLine("Nome: " + cliente3.getNome());
            Console.WriteLine("Sobrenome: " + cliente3.getSobrenome());
            Console.WriteLine("CPF: " + cliente3.getCpf());
            Console.WriteLine("Conta/nAgencia " + cliente3.getConta().getAgencia());
            Console.WriteLine("Numero " + cliente3.getConta().getNumero());
            Console.WriteLine("Saldo " + cliente3.getConta().getSaldo());
        }
    }
}
