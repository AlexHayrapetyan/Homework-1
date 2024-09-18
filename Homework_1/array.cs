using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
	internal class array
	{
		static void Main(string[] args)
		{
			int[] arr = new int[4];
			arr[0] = 4;
			arr[1] = 15;
			arr[2] = 33;
			arr[3] = 12;
			double b = arr.Sum()/arr.Length;
			Console.WriteLine(b);
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 == 0) 
				{
					Console.WriteLine(arr[i]);
				}
			}
		}

	}
}
