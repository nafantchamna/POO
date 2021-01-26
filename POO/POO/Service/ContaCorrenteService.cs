using System;
using POO.Model;
namespace POO.Service
{
   public class ContaCorrenteService 
    {
        public void OperacaoSaque()
        {
            Console.WriteLine();
            Console.WriteLine("Fvaor digite o seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe valor que deseja sacar: " + "\n");
            Console.ReadKey();
        }
        public void OperacaoDeposito()
        {
            Console.WriteLine();
            Console.WriteLine("Favor digite o seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe valor que deseja depositar: " + "\n");
            Console.ReadKey();
        }
        public void OperacaoTransferencia()
        {
            Console.WriteLine("Favor digite o seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe valor que deseja transferir: " + "\n");
            Console.ReadKey();
        }
    }
}