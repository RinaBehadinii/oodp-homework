using Singleton;

Logger logger1 = Logger.Instance();
logger1.Log("Application started");

Logger logger2 = Logger.Instance();
logger2.Log("Application is running");

if (logger1 == logger2)
{
    Console.WriteLine("Logger is a singleton and both variables contain the same instance.");
}
else
{
    Console.WriteLine("Logger failed, variables contain different instances.");
}