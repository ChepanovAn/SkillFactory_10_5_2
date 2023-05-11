using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_10_5_2
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();

            var worker1 = new Worker1(Logger);

            while (true)
            {
                try
                {
                    worker1.Work();

                    Console.WriteLine("Введите первое число");

                    int numberOne = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");

                    int numberTwo = int.Parse(Console.ReadLine());

                    ConsoleProcessor consoleProcessor = new ConsoleProcessor();

                    ((ISum)consoleProcessor).Sum(numberOne, numberTwo);
                }
                catch (Exception)
                {
                    worker1.WorkError();
                }
            }      
           
        }
    }
}
