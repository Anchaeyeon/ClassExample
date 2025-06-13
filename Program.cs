using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Program
    {
        class Parent
        {
            public Parent() { Console.WriteLine("Parent()"); }
            public Parent(string name) { Console.WriteLine("Parent(string name)"); }
            public Parent(double param) { Console.WriteLine("Parent(double param)"); }
        }

        class Child : Parent
        {
            public Child() : base("child")
            {
                Console.WriteLine("Child()");
            }
            public Child(string name) : base(name)
            {
                Console.WriteLine("Child(string name)");
            }
            public Child(double param) : base(param)
            {
                Console.WriteLine("Child(double param)");
            }
        }

        static void Main(string[] args)
        {
            Child childA = new Child("abc");
            Child childB = new Child(3);
            // int < long < float < double
        }
    }
}
