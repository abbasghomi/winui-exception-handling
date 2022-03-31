using Microsoft.UI.Dispatching;
using System;

namespace WinUIExceptionHandling.ExceptionHandlres
{
    public interface IApplicationExceptionHandler
    {
        DispatcherQueue ApplicationDispatcherQueue { get; set; }

        void OnUnhandledException(Exception e);
    }
}