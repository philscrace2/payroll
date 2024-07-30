using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NGuava;

namespace ClassLibrary1
{
    public class Controller
    {
        public Controller(IEventBus bus)
        {
            bus.Register(this);
        }

        [Subscribe]
        public void DoSomething(SomeEvent someEvent)
        {
            Console.Write("Hello World!");
        }
    }
}
