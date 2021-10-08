using System;

namespace ArrayStringBuilderClass
{
    class Student
    {
        public string Name;
        public string Surname;
        public int Age;

        public void PrintFullName()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }
    }
}
