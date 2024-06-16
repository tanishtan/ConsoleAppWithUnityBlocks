using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWithUnityBlocks
{
    public interface IBasicService
    {
        void Execute();
    }
    public class BasicService : IBasicService
    {
        private int _counter = 123;
        public BasicService() { 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ctor called");
            Console.ResetColor();
        }
        public void Execute()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"Execute called with counter at {_counter}");
            _counter++;
        }
    }
}
