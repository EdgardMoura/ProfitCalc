using System;

namespace HuntProfit
{
    class Calculadora
    {
        public string NomeEd { get; set; }
        public double SuplyEd { get; set; }
        public double ProfitParty { get; set; }
        public double Transfer { get; set; }
        public double Transfer1 { get; set; }

        public Calculadora()
        {
        }

        public Calculadora(string nomeEd, double suplyEd)
        {
            NomeEd = nomeEd;
            SuplyEd = suplyEd;
        }

        public Calculadora(string nome, double suplyEd, double profitParty) : this(nome, suplyEd)
        {
            ProfitParty = profitParty;
        }

        public Calculadora(string nome, double suplyEd, double profitParty, double transfer) : this(nome, suplyEd, profitParty)
        {
            Transfer = transfer;
        }

        public void Lucro(double profitParty, double suplyEd)
        {
            Transfer = profitParty / 2 + suplyEd;
            Transfer1 = Transfer - suplyEd;
        }



        public override string ToString()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();


            return " O gasto do ED "
                + NomeEd + " foi de : "
                + SuplyEd + "\n"
                + " O PROFIT da party foi de : "
                + ProfitParty + "\n"
                + " O valor a ser transferido para o " + NomeEd + " é de : "
                + Transfer + "\n"
                + " O profit REAL do EK foi de: "
                + Transfer1;
        }
    }
}
