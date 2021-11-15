using System;
using Module2HW2.Services;

namespace Module2HW2
{
    public class Starter
    {
        private readonly Device_Service _device_service = new Device_Service();
        private readonly Cart_Service _cart_service = new Cart_Service();
        private readonly Checkout_Service _checkout_service = new Checkout_Service();

        public void Run()
        {
            var listOfDevices = _device_service.ReturnAllDevices();
            Random rand = new Random();
            var quantityToBuy = rand.Next(0, 21);
            var toCart = new Device[quantityToBuy];
            _cart_service.ClearCart();
            for (var i = 0; i < toCart.Length; i++)
            {
                var choice = rand.Next(0, listOfDevices.Length);
                if (!_cart_service.PutToCart(listOfDevices[choice]))
                {
                    break;
                }
            }

            _checkout_service.Checkout("0677777777", "allcome@gmail.com");
        }
    }
}
