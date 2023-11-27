using System;

class Program
{
    static void Main()
    {
        int arraySize = 8; 

        Random random = new Random();

        int[] numbersArray = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            numbersArray[i] = random.Next(100, 1000);
        }

        Console.WriteLine("Сгенерированный рандомно массив:");
        foreach (int number in numbersArray)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        int evenCount = CountEvenNumbers(numbersArray);
        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    }

    static int CountEvenNumbers(int[] array)
    {
        int count = 0;

        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}