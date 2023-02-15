using PetShop;
using System;

class Program
{
    static void Main()
    {
        Cat cat_1 = new("Vasya", 2);
        Cat cat_2 = new("Myrzik", 3);

        Dog dog_1 = new("Lord", 6);
        Dog dog_2 = new("Zews", 3);

        cat_1.say();
        cat_2.say();

        dog_1.say();
        dog_2.say();
    }
}