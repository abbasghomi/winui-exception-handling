using System;
using System.Diagnostics;

namespace WinUIExceptionHandling.ExceptionHandlres
{
    public class ApplicationExceptionHandler : GlobalExceptionHandler, IApplicationExceptionHandler
    {
        public override void OnUnhandledException(Exception e)
        {
            Debug.WriteLine("Exception catched");
        }
    }
}
