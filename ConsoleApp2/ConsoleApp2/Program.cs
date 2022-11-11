// В программе создаётся одномерный массив, заполненный случайными числами.
// есть метод, который находит сумму элементов, стоящих на нечётных позициях.
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Option newArr = new Option();
            int[] arr = newArr.CreateArray();

            Option summ = new Option();
            int showSumm = summ.SummOf_odd(arr);

            Console.WriteLine($"Сумма нечётных элементов равна: {showSumm}.");
        }


    }

    
}
