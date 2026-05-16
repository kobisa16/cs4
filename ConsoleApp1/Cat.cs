using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal sealed class Cat : Animal
    {
        public Cat(int age, string name): base(age, name)
        {
            this.Age = age;
            this.Name = name;
        }
        public void Purr()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }
}
