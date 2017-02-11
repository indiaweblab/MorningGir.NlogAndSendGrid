using NLog;
using System;

namespace MorningGir.NlogAndSendGrid
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            Console.WriteLine("Start Log Test");

            logger.Error("Error Mail Log Test");

            Console.WriteLine("End Log Test");
        }
    }
}
