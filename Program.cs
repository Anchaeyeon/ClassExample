﻿using System;
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
            public static int counter = 0;
            public void CountParent()
            {
                Parent.counter++;
            }

            public Parent() { Console.WriteLine("Parent()"); }
            public Parent(string name) { Console.WriteLine("Parent(string name)"); }
            public Parent(float param) { Console.WriteLine("Parent(double param)"); }
        }

        class Child : Parent
        {
            public void CountChild()
            {
                Child.counter++;
            }
            public Child() : base("child")
            {
                Console.WriteLine("Child()");
            }
            public Child(string name) : base(name)
            {
                Console.WriteLine("Child(string name)");
            }
            public Child(float param) : base(param)
            {
                Console.WriteLine("Child(float param)");
            }
        }

        public static int number = 10;

        static void Main(string[] args)
        {
            // 섀도잉
            int number = 20;
            Console.WriteLine(number); // 클래스 변수 이름이 가려짐 (shadowing)
            Console.WriteLine(Program.number); //호출하고 싶으면 클래스 변수명으로 사용

            Child childA = new Child("abc");
            Child childB = new Child(3L);
            // int < long < float < double

            Parent parent = new Parent();
            Child child = new Child();

            parent.CountParent();
            child.CountChild();

            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);
        }
    }
}
