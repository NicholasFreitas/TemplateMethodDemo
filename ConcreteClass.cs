using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTemplatePattern
{
    class ConcreteClass : AbstractClass
    {
        public override void PrimitiveMethodOne()
        {
            Console.WriteLine("Primitive Method One");
        }

        public override void PrimitiveMethodTwo()
        {
            Console.WriteLine("Primitive Method Two");
        }

        public override void PrimitiveMethodThreeHook()
        {
            Console.WriteLine("Hook method Three overidden.");
        }

    }
}
