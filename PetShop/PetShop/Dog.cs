using System;

namespace PetShop
{
    internal class Dog : Animal
    {
        public Dog(string name, uint age) : base(name, age) {}

        public override void say()
        {
            Console.WriteLine($"Dog {name} say: Aww! Aw!");
        }
    }
}
