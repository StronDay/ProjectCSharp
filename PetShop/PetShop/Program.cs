using Animals;
using PetShop;
using System;

class Program
{
    static void Main()
    {
        Cat cat_1 = new("Vasya", "Cat", 2);
        Cat cat_2 = new("Myrzik", "Cat", 3);

        Dog dog_1 = new("Lord", "Dog", 6);
        Dog dog_2 = new("Zews", "Dog", 3);
        Dog dog_3 = new("Lord", "Dog", 6);

        cat_1.Say();
        cat_2.Say();

        dog_1.Say();
        dog_2.Say();

        Console.Write(dog_3);

        Console.WriteLine(dog_1 == dog_3);
    }
}