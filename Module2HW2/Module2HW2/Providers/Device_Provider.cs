using System;
using Module2HW2.Database;

namespace Module2HW2.Providers
{
    public class Device_Provider
    {
        private readonly Device_Base _database = Device_Base.GetInstance;

        public Device[] GetFullBase()
        {
            return _database.Devices;
        }

        public Device GetFromBaseByID(int id)
        {
            var devices = GetFullBase();
            Device exact = null;
            foreach (var i in devices)
            {
                if (i.Id == id)
                {
                    exact = i;
                    break;
                }
            }

            return exact;
        }
    }
}
