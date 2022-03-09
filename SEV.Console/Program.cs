using System;

namespace SEV.TestConsole
{
    class Program : BaseController
    {
        private static void Main()
        {
            Console.ForegroundColor = CCInfo;
            Console.WriteLine("SEV Client API Example Code C# .Net Core");
            Console.WriteLine();
            ActionSeporator();
            Console.ForegroundColor = CCInfo;
            Console.WriteLine("See our API documentation website on URL:");
            Console.WriteLine("https://prepaid.allservices.nl/api");
            Console.ForegroundColor = CCDefault;
            ActionSeporator();

            new Commands().Options();
        }
    }
}