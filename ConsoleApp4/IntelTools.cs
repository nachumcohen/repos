using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    static class IntelTools
    {
        public static string EncryptMessage(string msg)
        {
            string newMsg = "";
            for (int i = msg.Length -1; i >= 0; i--)
            {
                newMsg += msg[i];
            }
            return newMsg;
        }

        public static void LogTransmission(string agentName, string message)
        {
            Console.WriteLine($"{agentName} sent encrypted message: {message}");
        }
    }
}
