using System;

public class Option
{
	public int[] CreateArray()
	{
		int[] arr = new int[new Random().Next(1, 20)];

		for(int i = 0; i < arr.Length; i++)
        {
			arr[i] = new Random().Next(1, 1000);
        }
		
		return arr;
	}

	public int Result(int[] arr)
    {
		int min = arr[0], max = arr[0];

		for(int i = 1; i < arr.Length; i++)
        {
			if (min > arr[i]) min = arr[i];
			if (max < arr[i]) max = arr[i];
        }

		return max - min;
    }
}
