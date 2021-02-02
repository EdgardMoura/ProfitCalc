using System;

namespace HuntProfit
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculadora conta;

            Console.Write("Nome do Ed: ");
            string nomeEd = Console.ReadLine();
            Console.Write("Profit suado: ");
            double profitParty = double.Parse(Console.ReadLine());
            Console.Write("Gasto Ed: ");
            double suplyEd = double.Parse(Console.ReadLine());

            conta = new Calculadora(nomeEd, suplyEd, profitParty);
            conta.Lucro(profitParty, suplyEd);

            Console.WriteLine(conta);

            Console.ReadKey();

        }
    }
}