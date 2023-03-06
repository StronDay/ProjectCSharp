using System;
using MyList;

class Program
{
    static void Main()
    {
        MyList<int> list = new MyList<int>(1, 0);
        List<int> list2 = new List<int>();

        Console.WriteLine($"capacity: {list.Capacity}");
        Console.WriteLine($"size: {list.Size}\n");

        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        Console.WriteLine("Array: ");
        list.Print();

        Console.WriteLine($"\ncapacity: {list.Capacity}");
        Console.WriteLine($"size: {list.Size}\n\n\n");

        Console.WriteLine($"capacity: {list2.Capacity}");
        Console.WriteLine($"size: {list2.Count}\n");

        list2.Add(1);
        list2.Add(2);
        list2.Add(3);
        list2.Add(4);
        list2.Add(5);

        Console.WriteLine("Array: ");
        for (int i = 0; i < list2.Count; i++)
        {
            Console.WriteLine(list2[i]);
        }

        Console.WriteLine($"\ncapacity: {list2.Capacity}");
        Console.WriteLine($"size: {list2.Count}");
    }
}