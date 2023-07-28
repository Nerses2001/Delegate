

using System;
using System.Linq;

namespace Delegate
{
    public class MyClass
    {
        public static void Mtehod1() 
        {
            Console.WriteLine("MyClass.Method()");
        }

        public string StringReturnMehode(string str)
        {
            Console.WriteLine("myClass.StringReturnMehode()");

            return str + "adasdaarwdasdsaewewadsad";
        }

        public static void Method2() 
        {
            Console.WriteLine("MyClass.Method2()");        
        }
        public static void Method3()
        {
            Console.WriteLine("MyClass.Method3()");
        }
    }
}
