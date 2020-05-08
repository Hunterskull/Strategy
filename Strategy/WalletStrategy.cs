using System;
using Strategy.Interfaces;
using Strategy.Models;

namespace Strategy
{
    public class WalletStrategy : IPaymentStrategy
    {
        public int Budget;
        public string GebruikerNaam { get; set; }

        public WalletStrategy(int budget, string gebruikerNaam)
        {
            Budget = budget;
            GebruikerNaam = gebruikerNaam;
        }


        public bool Pay(int totalPrice)
        { 
            if(Budget > totalPrice)
            {
                Console.WriteLine("Paid using In-Game Wallet. ");
                return true;
            }
            else
            {
                Console.WriteLine("You Lack The Funds To Buy Everything.");
                return false;
            }
        }
    }
}


    
