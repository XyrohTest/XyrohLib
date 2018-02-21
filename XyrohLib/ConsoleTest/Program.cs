﻿using System;
using com.xyroh.lib;


namespace ConsoleTest
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionHandler;

            //XyrohLib.Test();

            XyrohLib.setFileLog("test.log");
            XyrohLib.setCrashreporter("https://39b42ba5c36b4f6c97592672d3f0e1fc:05c1dc1d83a24e2190026a85ca585410@sentry.io/292140");
            //XyrohLib.Test();
            XyrohLib.Log("test log 10 ");
            


            throw new Exception("KaBlam2");


            //logger.Log("test from console");
        }



        static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            XyrohLib.LogException("unhandled exception", ex);
            //XyrohLib.LogCrash("unhandled exception", ex);
            Environment.Exit(1);
        }
    }
}
