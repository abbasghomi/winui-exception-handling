# WinUI Global Exception Handling

Inspired by this repo:

https://github.com/robibobi/dotnet-global-exceptionhandler



This sample app demonstrate how to catch exceptions from UI thread and other threads globally, but still there is an unresolved issue with this code,

The unresolved issue is no matter we catch and propagate the unhandled error, it still terminates the application but I presume we wanted it handled!



Test Run:

Put break points described below and run the application

1- in namespace WinUIExceptionHandling.ExceptionHandlres, in ApplicationExceptionHandler class on line#10

2- in namespace WinUIExceptionHandling.ExceptionHandlres, in GlobalExceptionHandler class on line#32

