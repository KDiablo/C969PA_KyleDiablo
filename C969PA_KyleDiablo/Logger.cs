using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C969PA_KyleDiablo
{
    static class Logger
    {
        public static void Log(string message)
        {
            File.AppendAllText("log.txt", $"{DateTime.Now} -- {message}" + Environment.NewLine);
        }
        public static void Log(DateTime time, string message)
        {
            File.AppendAllText("", $"{time} -- {message}" + Environment.NewLine);
        }
        
    }
}
