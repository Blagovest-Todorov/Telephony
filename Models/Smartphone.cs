using System;
using System.Linq;
using Telephony.Exceptions;
using Telephony.Interfaces;

namespace Telephony.Models
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Browse(string urlSite)
        {
            if (urlSite.Any(ch => char.IsDigit(ch)))
            {
                throw new InvalidURLException();
            }

            return $"Browsing: {urlSite}!";
        }

        public string Call(string phoneNr)
        {
            if (!phoneNr.All(ch => char.IsDigit(ch)))
            {
                throw new InvalidPhoneNumberException();
            }

            return $"Calling... {phoneNr}";
        }
    }
}
