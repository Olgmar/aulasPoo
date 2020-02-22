using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTime
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Instancia de um objeto*/
            Time objTime = new Time();
            objTime.nome = "Boa Esporte";
            objTime.cidade = "Varginha";
            objTime.comprarJogador(1);
            objTime.titulo(1);
            objTime.valor(0);

            /*Mostrar Valor para o Usuario*/
            System.Console.WriteLine(@"Entre com a cidade do time "+ objTime.nome);
            

            /*Ler entrada do usuário*/
            objTime.cidade = System.Console.ReadLine();

            /*Mostrar Valor para o Usuario*/
            System.Console.WriteLine(@"Entre com o estado do time " + objTime.nome);

            /*Ler entrada do usuário*/
            objTime.estado = System.Console.ReadLine();

            /*Mostrar Valor para o Usuario*/
            System.Console.WriteLine(@"Entre com o pais do time " + objTime.nome);

            /*Ler entrada do usuário*/
            objTime.pais = System.Console.ReadLine();

            /*Mostrar Valor para o Usuario*/
            System.Console.WriteLine(@"Entre com o número de jogadores do " + objTime.nome);

            /*Ler entrada do usuário*/
            objTime.numerodejogadores = Convert.ToInt32(System.Console.ReadLine());

            /*Mostrar Valor para o Usuario*/
            System.Console.WriteLine(@"Entre com o número de titulos do " + objTime.nome);

            /*Ler entrada do usuário*/
            objTime.numerodetitulos = Convert.ToInt32(System.Console.ReadLine());

            /*Mostrar Valor para o Usuario*/
            System.Console.WriteLine(@"Entre com o Valor do Time " + objTime.nome);

            /*Ler entrada do usuário*/
            objTime.valorDoTimeEmDinheiro = Convert.ToInt32(System.Console.ReadLine());

            /*Mostrar estado do objeto*/
            string statusDoObjeto;
            statusDoObjeto = objTime.statusClass();
            System.Console.WriteLine(statusDoObjeto);
            
            //System.Console.WriteLine(@"Entre com o número de Jogadores");
            //int numJogador;
            //numjogador = System.Console.ReadLine();
            //objTime.comprarJogador(numJogador);

            /*Parar o programa*/
            System.Console.ReadKey();


        }
    }
}
