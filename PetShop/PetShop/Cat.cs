using System;

namespace PetShop
{
    internal class Cat : Animal
    {
        public Cat(string name, uint age) : base(name, age) {}

        public override void say()
        {
            Console.WriteLine($"Cat {name} say: Maww!");
        }
    }
}
