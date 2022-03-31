using System;

namespace WinUIExceptionHandling.Exceptions
{
    public class UnknownAppDomainException : Exception
    {
        public UnknownAppDomainException(string msg) : base(msg)
        {
        }
    }
}
