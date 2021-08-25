using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9_Exercicio2
{
    class Conta
    {
        private string agencia;
        private int numero;
        private float saldo;

        public void setAgencia(string agencia)
        {
            this.agencia = agencia;
        }

        public string getAgencia()
        {
            return this.agencia;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public void setSaldo(float saldo)
        {
            this.saldo = saldo;
        }

        public float getSaldo()
        {
            return this.saldo;
        }
    }
}
