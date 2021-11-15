using System;

namespace Module2HW2.Providers
{
    public class Cart
    {
        private const int _cartSize = 10;
        private static readonly Cart Instance = new Cart();

        private Device[] _cart = new Device[_cartSize];
        private int _temp = 0;
        static Cart()
        {
        }

        private Cart()
        {
        }

        public static Cart GetInstance
        {
            get { return Instance; }
        }

        public bool PushToCart(Device device)
        {
            if (_temp < _cartSize)
            {
                _cart[_temp] = device;
                _temp++;
                return true;
            }

            return false;
        }

        public void ClearCart()
        {
            _temp = 0;
        }

        public Device[] GetAllFromCart()
        {
            var result = new Device[_temp];
            for (var i = 0; i < _cart.Length && i < _temp; i++)
            {
                result[i] = _cart[i];
            }

            return result;
        }

        public bool IsEmpty()
        {
            return _temp == 0;
        }
    }
}
