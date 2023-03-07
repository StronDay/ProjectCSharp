using System;

namespace Animals
{
    internal class Dog : Animal
    {
        public Dog(string name, string species, uint age) : base(name, species, age) {}

        public override void Say()
        {
            Console.WriteLine($"Dog {Name} say: Aww! Aw!");
        }
    }
}
