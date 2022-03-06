using System;
using System.Collections.Generic;
using System.Text;
using Telephony.Interfaces;

namespace Telephony
{
    public class Smartphone : ISmartphoneable
    {
        public void Calling(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }

        public void Browsing(string website)
        {
            Console.WriteLine($"Browsing: {website}!");
        }
    }
}
