using System;
using System.IO;

namespace myApp
{
    public static class LogFileHelper
    {
        public static void WriteMessage(string message)
        {
            File.AppendAllText("log-polly.txt", message +
                Environment.NewLine +
                Environment.NewLine);

        }
    }
}