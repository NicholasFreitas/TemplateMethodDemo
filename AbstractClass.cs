using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTemplatePattern
{
    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Console.WriteLine("Start of Template Method");
            PrimitiveMethodOne();
            Console.WriteLine("... work ...");
            PrimitiveMethodTwo();
            PrimitiveMethodThreeHook();
            PrimitiveMethodFourHook();
            Console.WriteLine("End of Template Method");
        }


        abstract public void PrimitiveMethodOne();

        abstract public void PrimitiveMethodTwo();

        virtual public void PrimitiveMethodThreeHook()
        {
            Console.WriteLine("Default Implementation of Primitive Three");
        }

        virtual public void PrimitiveMethodFourHook()
        {
            Console.WriteLine("Default Implementation of Primitive Four");
        }
        
    }
}
