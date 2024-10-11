using System;

class Program
{

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
      
        int[] array = { 9, 3, 6, 1, 7, 5, 8, 2, 10, 4 };

        Console.WriteLine("Масив:");
        foreach (int num in array)
        {
            Console.Write(num);
        }

        Array.Sort(array);

        Console.WriteLine("\nМасив після сортування:");
        foreach (int num in array)
        {
            Console.Write(num);
        }
    }
}

