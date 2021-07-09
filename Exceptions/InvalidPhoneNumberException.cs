using System;

namespace Telephony.Exceptions
{
    public class InvalidPhoneNumberException : Exception
    {
        private const string Invalid_Phone_Ex_Message = "Invalid number!";
        public InvalidPhoneNumberException()
            : base(Invalid_Phone_Ex_Message)
        {

        }
    }
}
