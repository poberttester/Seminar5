// В программе задаётся массив заполненный случайными положительными трёхзначными числами.
// В программе есть метод, который покажет количество чётных чисел в массиве.
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Play with array");
            
            var randArray = randomArray();
            fillArray(randArray);
            showArray(randArray);

        }

        static int[] randomArray() // метод возвращает пустой массив со случайным размером
        {
            Random rand = new Random();
            int size = rand.Next(0, 101);
            int[] randArray = new int[size];
            return randArray;
        }

        static void fillArray(int [] arr) // метод заполнения массива случайными положительными трёхзначными числами
        {
            Random rand = new Random();

            for (int i = 0; i < arr.Length;i++)
            {
                arr[i] = rand.Next(100, 1000);
            }
        }
        

        static void showArray(int[] arr) // метод выводит значения массива на экран консоли
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        
    }
}
