using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_10_5_2
{
    class Logger : ILogger
    {
        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine(message);
        }

        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;

            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine(message);
        }
    }
}
