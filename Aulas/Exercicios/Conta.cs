using System;

namespace Exercicios
{
    public class Conta
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
            return agencia;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public int getNumero()
        {
            return numero;
        }

        public void setSaldo(float saldo)
        {
            this.saldo = saldo;
        }

        public float getSaldo()
        {
            return saldo;
        }
    }
}
