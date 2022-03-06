using System;
using System.Collections.Generic;
using System.Text;
using Telephony.Interfaces;

namespace Telephony
{
    public class Stationary : IStationary
    {
        public void Dialing(string number)
        {
            Console.WriteLine($"Dialing... {number}");
        }
    }
}
