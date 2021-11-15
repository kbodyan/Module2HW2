using System;

namespace Module2HW2.Services
{
    public class SMS_Service
    {
        public bool SendSMS(int number, string massage)
        {
            Console.WriteLine($"SMS was send to number:{number} with massage: {massage}");
            return true;
        }
    }
}
