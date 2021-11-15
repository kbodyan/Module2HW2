using System;

namespace Module2HW2.Services
{
    public class Email_Service
    {
        public bool SendEmail(string address, string massage)
        {
            Console.WriteLine($"E-mail was send to address:{address} with massage: {massage}");
            return true;
        }
    }
}
