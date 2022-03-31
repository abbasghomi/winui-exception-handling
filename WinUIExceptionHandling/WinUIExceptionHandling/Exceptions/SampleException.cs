using System;

namespace WinUIExceptionHandling.Exceptions
{
    class SampleException : Exception
    {
        public SampleException(string message) : base(message)
        {
        }
    }
}
