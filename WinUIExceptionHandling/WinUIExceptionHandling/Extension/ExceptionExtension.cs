using Microsoft.UI.Dispatching;
using System;

namespace WinUIExceptionHandling.Extension
{
    public static class ExceptionExtension
    {
        public static void ThrowOnDispatcher(this DispatcherQueue dispatcherQueue, Exception exception)
        {
            if (exception == null)
            {
                dispatcherQueue.TryEnqueue(DispatcherQueuePriority.High, () => throw exception);
            }
        }
    }
}
