using System;

namespace Animals
{
    internal class Cat : Animal
    {
        public Cat(string name, string species, uint age) : base(name, species, age) {}

        public override void Say()
        {
            Console.WriteLine($"Cat {Name} say: Maww!");
        }
    }
}
