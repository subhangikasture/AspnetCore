using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Logger
    {
        private Logger() {
            Console.WriteLine("I am a private constructor");
        }
        private static readonly object _locker = new object();
        private static Logger _loggerInstance;

        public static Logger getLoggerInstance
        {
            get
            {
                lock (_locker)
                {
                    if (_loggerInstance == null)
                    {
                        Console.WriteLine("Instance creation");
                        _loggerInstance = new Logger();
                    }
                }
                return _loggerInstance;
            }
        }

        public void Log(string message)
        { 
            Console.WriteLine(message);
        }
    }
}
