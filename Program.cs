﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTemplatePattern
{
    class Program
    {
        /*
         Fairly straightforward. The way the template method work
         is that allows you to abstract away parts of an algorithm 
         when that specific part of the algorithm might have varying 
         implementations.

         You can also add "hooks", optional part of the code that can
         be overridden if there's a specific implementation. However if you
         choose not to, there will be a default implementation.
             
             

            ------------------------------
            | Abstract Class             |
            ------------------------------
            | TemplateMethod()|          | o---- PrimitiveMethodOne()
            | PrimitiveMethodOne()       |       PrimitiveMethodTwo()
            | PrimitiveMethodTwo()       |       PrimitiveMethodThreeHook() 
            | PrimitiveMethodThreeHook() |       PrimitiveMethodFourHook()
            | PrimitiveMethodFourHook()  |
            ------------------------------
                           |
                           |
                           |
                         is-a
                           ^
                           ^
                           |
                           |
            ------------------------------
            |ConcreteClass               | 
            ------------------------------
            |PrimitiveMethodOne()        |
            |PrimitiveMethodTwo()        |
            |PrimitiveMethodThreeHook()  |
            |PrimitiveMethodFourHook()   |
            ------------------------------
            * The first two would need implementations.
            * The second two could be optionally overridden or not. The have default implementations


             */



        static void Main(string[] args)
        {

            var concretion = new ConcreteClass();
            concretion.TemplateMethod();

        }
    }
}
