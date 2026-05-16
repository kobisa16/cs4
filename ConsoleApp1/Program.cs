using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Animal[] animals = new Animal[] 
            {new Dog (16,"Rex"),
            new Cat (5,"Whiskers")
            };





            static void Print(Animal[] animals)
            {
                foreach (var item in animals)
                {
                    Console.WriteLine(item.ToString());
                    if (item is Dog)
                    {
                        ((Dog)item).Bark();
                    }
                    else if (item is Cat)
                    {
                        ((Cat)item).Purr();

                    }
                }

            }

        }
    }
}
