using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число или 'q' для завершения:");
            string input = Console.ReadLine()!;

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            if (int.TryParse(input, out int number))
            {
                if (IsSumOfDigitsEven(number))
                {
                    Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите целое число или 'q' для завершения.");
            }
        }
    }

    static bool IsSumOfDigitsEven(int number)
    {
        int sum = 0;

        // Рассчитываем сумму цифр числа
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        // Проверяем, является ли сумма чётной
        return sum % 2 == 0;
    }
}