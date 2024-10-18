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

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nМасив після сортування:");
        foreach (int num in array)
        {
            Console.Write(num);
        }
    }
}
