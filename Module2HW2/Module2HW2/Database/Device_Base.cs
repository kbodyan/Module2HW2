using System;

namespace Module2HW2.Database
{
    public class Device_Base
    {
        private static readonly Device_Base Instance = new Device_Base();
        static Device_Base()
        {
        }

        private Device_Base()
        {
        }

        private readonly Device[] _devices = new Device[]
        {
            new Device("HP laptop", "HP Envy x360", 1, 500.00, Currencys.USD),
            new Device("Dell laptop", "Dell XPS 15", 2, 700.00, Currencys.USD),
            new Device("Samsung  laptop", "Samsung Galaxy Book", 3, 600.00, Currencys.USD),
            new Device("Asus laptop", "Asus Zenbook 13", 4, 400.00, Currencys.USD),
            new Device("Acer laptop", "Acer Swift 3", 5, 450.00, Currencys.USD),
            new Device("Google laptop", "Google Pixel Book", 6, 750.00, Currencys.USD),
            new Device("Microsoft laptop", "Microsoft Surface Book 13", 7, 900.00, Currencys.USD),
            new Device("Apple laptop", "Apple Macbook Pro", 8, 1000.00, Currencys.USD),
            new Device("Lenovo laptop", "Lenovo Yoga 3 Pro", 9, 550.00, Currencys.USD),
            new Device("MSI laptop", "MSI Trealth Pro", 10, 750.00, Currencys.USD)
        };

        public static Device_Base GetInstance
        {
            get { return Instance; }
        }

        public Device[] Devices
        {
            get { return _devices; }
        }

        public int Lenght()
        {
            return _devices.Length;
        }
    }
}
