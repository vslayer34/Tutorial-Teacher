using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVCCoreApp
{
    public interface ILog
    {
        void GetInfo(string str);
    }

    public class MyConsoleLogger : ILog
    {
        public void GetInfo(string str)
        {
            Console.WriteLine(str);
        }
    }
}