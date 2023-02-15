using System;

namespace PetShop
{
    abstract class Animal
    {   
        public Animal(string name, uint age)
        {
            _name = name;
            _age = age;
        }

        public virtual void say() 
        {
            Console.WriteLine("I`m Animal!");
        }
        public void eat() 
        {
            Console.WriteLine("Eating...");
        }

        public string name
        {
            get { return _name; }
            protected set { _name = value; }
        }
        public uint age
        {
            get { return _age; }
            protected set { if(value > 0) _age = value; }
        }

        private string _name;
        private uint _age;
    }
}