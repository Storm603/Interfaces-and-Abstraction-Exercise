using System;
using System.Text.RegularExpressions;
using Telephony.Interfaces;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            Regex numberMatcher = new Regex(@"[0-9]+");
            Regex websiteMatcher = new Regex(@"^[^0-9]+$");

            string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < numbers.Length; i++)
            {
                Match match = numberMatcher.Match(numbers[i]);

                if (match.Success && match.Length == 10)
                {
                    ISmartphoneable calling = new Smartphone();
                    calling.Calling(match.ToString());
                }
                else if (match.Success && match.Length == 7)
                {
                    IStationary dialing = new Stationary();
                    dialing.Dialing(match.ToString());
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            string[] websites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < websites.Length; i++)
            {
                Match match = websiteMatcher.Match(websites[i]);

                if (match.Success)
                {
                    ISmartphoneable browsing = new Smartphone();
                    browsing.Browsing(match.ToString());
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }
            }
        }
    }
}
