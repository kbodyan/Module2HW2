using System;
using Module2HW2.Providers;

namespace Module2HW2.Services
{
    public class Checkout_Service
    {
        private readonly Cart_Service _cart_service = new Cart_Service();
        public int? Checkout(string phone_number, string email)
        {
            if (new Cart_Service().IsCartEmpty())
            {
                Console.WriteLine("Your cart is empty. Nothing to checked out.");
                return null;
            }

            Console.WriteLine("Checkout succesfull.");
            Console.WriteLine("Your order:");
            var sum_USD = 0.00;
            foreach (var item in _cart_service.ShowCart())
            {
                Console.WriteLine($"Name: {item.Name}, Model: {item.Model}, Price: {item.Price}, Currency: {item.Currency.ToString()}");
                if (item.Currency == Currencys.USD)
                {
                    sum_USD += item.Price;
                }
            }

            Console.WriteLine($"Order total: {sum_USD}");
            var rand = new Random();
            int orderNumber = rand.Next(0, 1001);
            Console.WriteLine($"Order number: {orderNumber}");
            int number;
            if (phone_number != null && int.TryParse(phone_number, out number))
            {
                new SMS_Service().SendSMS(number, $"Checkout succesfull. Order number: {orderNumber}");
            }

            if (email != null)
            {
                new Email_Service().SendEmail(email, $"Checkout succesfull. Order number: {orderNumber}");
            }

            return orderNumber;
        }
    }
}
