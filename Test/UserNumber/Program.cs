﻿using System;

namespace ArithmeticMean
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter your number: ");
			string userNumber = Console.ReadLine();
            Console.Write("Amount of symbols number: ");
			Console.Write($"{userNumber.Length}\n");
            int[] z = new int[userNumber.Length];
			for (int i = 0;i < userNumber.Length;i++)
			{
				z[i] = Convert.ToInt32(userNumber[i].ToString());
			}
			int summ = 0;
			for (int i = 0;i < userNumber.Length;i++)
			{
				summ += z[i];
			}
			Console.WriteLine("The sum of numeric: {0}.", summ);
			int averageValue = summ / z.Length;
			Console.WriteLine("Average value is {0}.", averageValue);
			
			Console.ReadLine();
		}
	}
}
