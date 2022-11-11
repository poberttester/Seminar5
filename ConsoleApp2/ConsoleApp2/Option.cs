using System;

class Option
{
    internal int[] CreateArray() // метод возвращает массив случайного размера и заполняется случайными числами
    {
        int[] arr = new int[new Random().Next(1, 50)];        

        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(-100, 101);
        }

        return arr;
    }

    internal int SummOf_odd(int [] arr) // метод возвращает сумму нечётных элементов массива
    {
        int summ = 0;
        for(int i = 1; i < arr.Length; i += 2)
        {
            summ += arr[i]; 
        }
        return summ;
    }
}
