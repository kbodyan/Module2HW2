using System;

namespace Module2HW2
{
    public class Device
    {
        public string Name { get; init; }
        public string Model { get; init; }
        public int Id { get; init; }
        public double Price { get; set; }
        public Currencys Currency { get; set; }

        public Device(string name, string model, int id, double price,  Currencys currency)
        {
            Name = name;
            Model = model;
            Id = id;
            Price = price;
            Currency = currency;
        }
    }
}
