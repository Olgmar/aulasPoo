using System;
using System.Collections.Generic;
using System.Text;

namespace ProCalculadora
{
    class Calculadora
    {
        private List<double> listNumero = new List<double>();
        public void addNumero(double num)
        {
            this.listNumero.Add(num);
        }

        public double somar()
        {

            double resultado = 0;
            foreach (double numero in this.listNumero)
            {
                resultado += numero;
            }
            this.listNumero.Clear();
            return resultado;
        }

        public double Subtrair()
        {

            double resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado -= numero;
            }
            this.listNumero.Clear();
            return resultado;

        }
            public double Multiplicar()
        {
            double resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado *= numero;
            }
            this.listNumero.Clear();
            return resultado;
        }

        public double Dividir()
        {
            double resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado /= numero;
            }
            this.listNumero.Clear();
            return resultado;
        }

        public double Raiz()
        {
            double resultado = 0;
            foreach (double numero in this.listNumero)
            {
                resultado = Math.Sqrt(numero);
            }
            this.listNumero.Clear();
            return resultado;
        }

    }
}
