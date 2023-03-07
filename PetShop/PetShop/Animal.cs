using System;

namespace Animals
{
    abstract class Animal
    {
        private string _species = "Animal";
        private string _name;
        private uint _age;

        public Animal(string name, string species, uint age)
        {
            _name = name;
            _species = species;
            _age = age;
        }

        public string Name
        {
            get => _name;
            protected set { _name = value; }
        }

        public string Species
        {
            get => _species; 
            protected set { _species = value; }
        }

        public uint Age
        {
            get => _age;
            protected set { if (value > 0) _age = value; }
        }

        public virtual void Say() 
        {
            Console.WriteLine("I`m Animal!");
        }

        public static void Eat() 
        {
            Console.WriteLine("Eating...");
        }

        public override string ToString()
        {
            return ($"Name: {_name}\nAge: {_age}\nSpecies: {_species}\n");
        }

        public static bool operator==(Animal a, Animal b)
        {
            if ((a.Name == b.Name) & (a.Age == b.Age) & (a.Species == b.Species))
            {
                return true;
            }
            
            return false;
        }

        public static bool operator !=(Animal a, Animal b)
        {
            return !(a == b);
        }
    }
}