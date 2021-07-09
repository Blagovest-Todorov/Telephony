using System;

namespace Telephony.Exceptions
{
    public class InvalidURLException : Exception
    {
        private const string Invalid_URL_Ex_Message = "Invalid URL!";
        public InvalidURLException()
            : base(Invalid_URL_Ex_Message) 
        {

        }
    }
}
