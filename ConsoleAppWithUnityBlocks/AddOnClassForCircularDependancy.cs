using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWithUnityBlocks
{
    public class AddOnClassForCircularDependancy
    {
        private readonly IBasicService _basicService;
        private readonly ServiceDependentClass _serviceDependentClass;

        public AddOnClassForCircularDependancy(IBasicService basicService, ServiceDependentClass serviceDependentClass)
        {
            _basicService = basicService;
            _serviceDependentClass = serviceDependentClass;
        }
        public void StartNew()
        {
            _serviceDependentClass.Start();
            Console.WriteLine("Executing the basicservice imple");
            _basicService.Execute();
            Console.WriteLine("Executed the basicservice imple");
        }
    }
}
