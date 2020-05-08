using System;
using System.Collections.Generic;
using Strategy.Interfaces;
using Strategy.Models;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppingCart = new Cart();
            shoppingCart.AddProduct(new Game(50));
            shoppingCart.AddProduct(new Game(15));
            shoppingCart.AddProduct(new Sticker(5));
            shoppingCart.AddProduct(new Poster(10));


            
            var paypal = new PaypalStrategy("Steve", "Evest");
            var wallet = new WalletStrategy(90,"ForniteIsCool");
            var listPayment = new List<IPaymentStrategy>();
            listPayment.Add(wallet);
            listPayment.Add(paypal);
            shoppingCart.MakePayment(listPayment);
            //shoppingCart.MakePayment(paypal);
            //shoppingCart.MakePayment(wallet);
            shoppingCart.ClearCart();
            Console.ReadKey();

        }
    }
}
