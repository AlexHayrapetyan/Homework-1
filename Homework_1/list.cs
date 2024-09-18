using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
	internal class list
	{
		static void Lists(string[] args)
		{
			List<int> numbers = new List<int>();
			numbers.Add(1);	
			numbers.Add(2);	
			numbers.Add(3);
			numbers.Add(4);
			numbers.Add(5);

			Console.WriteLine(numbers.Sum());
			for(int i = 0; i < numbers.Count; i++)
			{
				Console.WriteLine(numbers[i]);
			}
		}
	}
}
