using System.Collections.Generic;
using System.Linq;
using Strategy.Interfaces;

namespace Strategy.Models
{
    public class Cart
    {
        private List<Product> _items;

        public Cart()
        {
            _items = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _items.Add(product);
        }

        public void ClearCart()
        {
            _items.Clear();
        }

        public void MakePayment(IPaymentStrategy paymentStrategy)
        {
            var totalPrice = GetTotalPrice();
            paymentStrategy.Pay(totalPrice);
        }

        public void MakePayment(List<IPaymentStrategy> paymentStrategies)
        {
            var totalPrice = GetTotalPrice();
            foreach (var paymentStrategy in paymentStrategies)
            {
                if (paymentStrategy.Pay(totalPrice))
                {
                    break;
                }
            }
        }

        public int GetTotalPrice()
        {
            var total = _items.Sum(x => x.GetPrice());
            return total;
        }
    }
}