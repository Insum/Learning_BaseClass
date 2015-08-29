using System;

namespace BaseClass
{
    class BaseClass
    {
        public BaseClass()
        {
            Console.Write("Zero Arg. Base Class Constructor is invoked...");
        }

        public BaseClass(string name)
        {
            Console.Write("Parameterized Base Class Constructor is invoked by {0} ", name);
        }
    }

    class SubClass : BaseClass
    {
        public SubClass()
        {
            Console.WriteLine("Zero Arg. Sub Class Constructor is invoked...");
        }

        public SubClass(string name) : base(name)
        {
            Console.Write("Parameterized Sub Class Constructor is invoked by {0} ", name);
        }
    }

    class CallBaseConstructor
    {
        static void Main(string[] args)
        {
            SubClass sc = new SubClass();
            Console.WriteLine("-------------");
            SubClass sc1 = new SubClass("Eldar");

            Console.ReadKey();
        }
    }
}
