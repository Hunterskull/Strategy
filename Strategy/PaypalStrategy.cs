using System;
using Strategy.Interfaces;

namespace Strategy
{
    public class PaypalStrategy : IPaymentStrategy
    {
        private string GebruikersNaam;
        private string Wachtwoord;

        public PaypalStrategy(string gebruikersNaam, string wachtwoord)
        {
            GebruikersNaam = gebruikersNaam;
            Wachtwoord = wachtwoord;
        }

        public bool Pay(int totalPrice)
        {
            if (Login())
            {
                Console.WriteLine("Paid Using Paypall");
                return true;
            }
            else
            {
                Console.WriteLine("Not logged in");
                return false;
            }
            
        }

        public bool Login()
        {
            return GebruikersNaam == "Steve" && Wachtwoord == "Evest";
        }
      
    }
}