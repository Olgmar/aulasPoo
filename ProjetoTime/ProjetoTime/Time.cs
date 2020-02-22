using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTime
{
    class Time
    {
        /*Atributos (Caracteristicas da Classe)*/
        public string nome;
        public string pais;
        public string estado;
        public string cidade;
        public int numerodejogadores = 0;
        public int numerodetitulos = 0;
        public double valorDoTimeEmDinheiro = 0;


        /*Metodos (Ações)*/
        public void comprarJogador (int numJogador)
        {
            this.numerodejogadores += numJogador;
        }

        public void titulo(int ganhoutitulo)
        {

            this.numerodetitulos += ganhoutitulo;
        }

        public void valor (int entradadedinheiro)
        {

            this.valorDoTimeEmDinheiro += entradadedinheiro;
        }

        public string statusClass()
        {
            string retorno;
            retorno = "Nome: " + this.nome +
                    "\nCidade: " + this.cidade +
                    "\nEstado: " + this.estado +
                    "\nPaís: " + this.pais +
                    "\nNúmero de Jogadores: " + this.numerodejogadores +
                    "\nNúmero de Titulo: " + this.numerodetitulos +
                    "\nValor do Time: R$" + this.valorDoTimeEmDinheiro;


            return retorno;           
         }


    }
}