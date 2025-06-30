using System;

namespace ClassExample
{
    public class Dog : Animal
    {
        public new void Eat()
        {
            Console.WriteLine("강아지가 사료를 먹습니다.");
        }
    }
}