using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Calculadora
{
    
    internal class Calculadora
    {
        private double memoriaAtual;
        public double Soma(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }

        public double Subtracao(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero - segundoNumero;
        }

        public double Divisao(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero / segundoNumero;
        }

        public double Multiplicacao(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero * segundoNumero;
        }

        public double Raiz(double primeiroNumero)
        {
            return Math.Sqrt(primeiroNumero);
        }



        // Função para o botão 'C' (Clear)
        public void Limpar()
        {
            memoriaAtual = 0;
        }

        // Função para o botão 'CE' (Clear Entry)
        public void LimparEntrada()
        {
            memoriaAtual = 0;
        }

        // Função para definir a memória atual
        public void DefinirMemoria(double valor)
        {
            memoriaAtual = valor;
        }

        // Função para obter a memória atual
        public double ObterMemoria()
        {
            return memoriaAtual;
        }
    }


}

