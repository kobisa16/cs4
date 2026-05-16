using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dog : Animal
    {
        public Dog(int age, string name): base (age, name)
        {
            this.Age = age; 
            this.Name = name;
        }

        public void Bark()
        {
            Console.WriteLine("Woof! Woof!");
        }

    }
}
