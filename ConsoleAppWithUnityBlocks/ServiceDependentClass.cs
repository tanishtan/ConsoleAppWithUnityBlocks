using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ConsoleAppWithUnityBlocks
{

    public class ServiceDependentClass
    {
        private IBasicService _service;
        public ServiceDependentClass(IBasicService service)
        {
            Console.WriteLine("with parameters");
            _service = service;
        }
        public ServiceDependentClass()
        {
            Console.WriteLine("without parameters");
            _service = new BasicService();
        }

        //peroperty injector
        
        private IBasicService _newService;
        [Unity.Dependency]
        public IBasicService NewService
        {
            get { return _newService; }
            set { _newService = value; }
        }

        private IBasicService _methodService;
        [InjectionMethod] // [FromServices]
        public void InjectoToMethod(IBasicService service)
        {
            _methodService = service;
        }
        public void StartWithInjection()
        {
            Console.WriteLine("StartWithInjection IBasicService begins execution");
            _methodService.Execute();
            Console.WriteLine("StartWithInjection IBasicService finishes execution...");
        }
        public void Start()
        {
            Console.WriteLine("Service IBasicService begins execution");
            _service.Execute();
            Console.WriteLine("Service IBasicService finishes execution...");
        }
        public void StartProperty()
        {
            Console.WriteLine("Service IBasicService Property Dependancy begins execution");
            _newService.Execute();
            Console.WriteLine("Service IBasicService Property Dependancy finishes execution...");
        }
    }
}
