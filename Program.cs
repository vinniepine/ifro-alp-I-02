/* Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
 * C.S.T. em Análise e Desenvolvimento de Sistemas
 * Disciplina de Algoritmo e Lógica 1
 * Professor Clayton Ferraz Andrade
 *
 * Acadêmico Vinícius de Oliveira Pinheiro
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parte 3 - variáveis
            string nomePessoa;
            float saldo = 1450;
            int valorSaque = 0;

            //parte 4 - entrada
            Console.WriteLine("Digite o seu nome");
            nomePessoa = Console.ReadLine();

            Console.WriteLine("Digite o valor do saque");
            valorSaque = int.Parse(Console.ReadLine());

            //parte 5 - processamento
            if (valorSaque > saldo) {
                Console.WriteLine("Infelizmente seu saque não pode ser realizado, pois não há saldo suficiente na sua conta.");
            }
            else{
                saldo = saldo - valorSaque;
                Console.WriteLine("Saque com sucesso");
                Console.WriteLine("Seu saldo é: " + saldo);
            }
            Console.ReadLine();
        }
    }
}
