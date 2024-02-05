using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {
        private static Logger _instance;
        private static readonly object lockObject = new object();
        private readonly string logFilePath;

        private Logger()
        {
            logFilePath = "application.log";
        }

        public static Logger Instance()
        {
                if (_instance == null)
                {
                    lock (lockObject)
                    {
                    if (_instance == null)
                        {
                            _instance = new Logger();
                        }
                    }
                }
                return _instance;
        }

        public void Log(string message)
        {
            string logEntry = $"{DateTime.Now}: {message}\n";
            lock (lockObject)
            {
                File.AppendAllText(logFilePath, logEntry);
            }
        }
    }
}
