using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using Animals;

namespace PetShop
{
    internal class PetShop
    {
        private Dictionary<uint, Shelf> _data;

        private uint _balance = 0;
        private uint _margin = 100;
        private uint _shelfCounter;

        public struct Shelf
        {
            private Animal _animal;
            private uint _price;

            public Shelf(Animal animal, uint price)
            {
                _animal = animal;
                _price = price;
            }

            public uint Price
            {
                get => _price;
                set => _price = value;
            }
        }

        public PetShop() 
        {
            _balance = 0;
            _data = new Dictionary<uint, Shelf>();
        }

        public PetShop(uint balance)
        {
            _balance = balance;
            _data = new Dictionary<uint, Shelf>();
        }

        public void Add(Animal animal, uint price) 
        {
            _data.Add(_shelfCounter++, new Shelf(animal, price));
        }

        public void Bye(Shelf shelf)
        {
            if (_balance < shelf.Price)
            {
                Console.WriteLine("Not enough money(...");
                return;
            }

            _balance -= shelf.Price;
            _data.Add(_shelfCounter++, shelf);
        }

        public void Sell(uint shelfCounter) 
        {
            if (_data.Remove(_shelfCounter))
            {
                Console.WriteLine("The animal was successfully sold.");
            }
            else
            {
                Console.WriteLine("There is no such shelf.");
            }
        }

        public void ResetShop()
        {
            _data.Clear();
        }

        public void GetInfo() 
        {

        }

        public void GetPetInfo(uint id) 
        {

        }
    }
}
