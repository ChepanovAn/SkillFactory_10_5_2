using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_10_5_2
{
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}
