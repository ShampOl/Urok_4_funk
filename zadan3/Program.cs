using System;

class Program
{
    static void Main()
    {
        int arraySize = 5;

        int[] originalArray = new int[arraySize];

        Random random = new Random();
        for (int i = 0; i < arraySize; i++)
        {
            originalArray[i] = random.Next(1, 101); 
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(originalArray);

        ReverseArray(originalArray);

        Console.WriteLine("\nПеревернутый массив:");
        PrintArray(originalArray);
    }

    static void ReverseArray(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
   
       