using System;
using Module2HW2.Providers;

namespace Module2HW2.Services
{
    public class Cart_Service
    {
        private readonly Cart _cart = Cart.GetInstance;

        public void ClearCart()
        {
            _cart.ClearCart();
        }

        public bool PutToCart(Device device)
        {
            return _cart.PushToCart(device);
        }

        public Device[] ShowCart()
        {
            return _cart.GetAllFromCart();
        }

        public bool IsCartEmpty()
        {
            return _cart.IsEmpty();
        }
    }
}
