namespace Telephony.Models
{
    using System.Linq;
    using Telephony.Exceptions;
    using Telephony.Interfaces;
    public class StationaryPhone : ICallable
    {
        public string Call(string phoneNr)
        {
            if (!phoneNr.All(ch => char.IsDigit(ch)))
            {
                throw new InvalidPhoneNumberException();
            }

            return $"Dialing... {phoneNr}";
        }
    }
}
