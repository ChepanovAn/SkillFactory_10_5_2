using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_10_5_2
{
    public class Worker1 : IWorker
    {
        ILogger Logger { get; }
        public Worker1(ILogger logger)
        {
            Logger = logger;
        }
        public void Work()
        {
            Logger.Event("Операция вычисления");
        }
        public void WorkError()
        {
            Logger.Error("Возникло исключение. Введите число.");
        }
    }
}
