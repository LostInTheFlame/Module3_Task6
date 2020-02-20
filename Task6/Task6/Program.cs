using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");

            if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
            {
                int[] numbers = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Введите {i + 1}-й элемент массива: ");
                    if (int.TryParse(Console.ReadLine(), out numbers[i])) { }
                    else
                    {
                        Console.WriteLine("\nОшибка при вводе значения.");
                        Console.ReadKey(true);
                        return;
                    }
                }
                Console.WriteLine("\nЗамена всех элементов массива на противположные по знаку:");
                for (int i = 0; i < size; i++) 
                {
                    Console.WriteLine($"{i+1}-й элемент массива: {numbers[i] * -1}");
                }
            }
            else
            {
                Console.WriteLine("\nОшибка при вводе рамера массива.");
            }
            Console.ReadKey(true);
        }
    }
}
