using System;
using Module2HW2.Providers;

namespace Module2HW2.Services
{
    public class Device_Service
    {
        private readonly Device_Provider _device_provider = new Device_Provider();

        public Device[] ReturnAllDevices()
        {
            return _device_provider.GetFullBase();
        }

        public Device ReturnByID(int id)
        {
            return _device_provider.GetFromBaseByID(id);
        }
    }
}
