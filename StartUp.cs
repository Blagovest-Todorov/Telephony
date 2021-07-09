using System;
using Telephony.Models;
using Telephony.Exceptions;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main()            
        {
            string[] phoneNumbers = Console.ReadLine()
                .Split().ToArray();

            string[] urls = Console.ReadLine()
                .Split().ToArray();

            Smartphone smart = new Smartphone();
            StationaryPhone statPhone = new StationaryPhone();

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                string currPhoneNr = phoneNumbers[i];

                try
                {
                    if (currPhoneNr.Length == 7)
                    {
                        Console.WriteLine(statPhone.Call(currPhoneNr));
                    }
                    else if (currPhoneNr.Length == 10)
                    {
                        Console.WriteLine(smart.Call(currPhoneNr));
                    }
                    else
                    {
                        throw new InvalidPhoneNumberException();
                    }
                }
                catch (InvalidPhoneNumberException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            for (int i = 0; i < urls.Length; i++)
            {
                string currUrl = urls[i];

                try
                {
                    Console.WriteLine(smart.Browse(currUrl));
                }
                catch (InvalidURLException ex)
                {
                    Console.WriteLine(ex.Message);
                } 
            }
        }
    }
}
