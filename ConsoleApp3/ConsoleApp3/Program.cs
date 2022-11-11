// Программа создаёт массив вещественных чисел и находит разницу между максимальным и минимальным элементов массива.
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выводим значение на экран");
            Option option = new Option();
            
            int[] arr = option.CreateArray();
            Console.WriteLine(option.Result(arr));
        }
    }
}
