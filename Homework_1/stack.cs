using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
	internal class stack
	{
		static void Stacks(string[] args)
		{
			Stack<int> ints = new Stack<int>();
			ints.Push(1);
			ints.Push(2);
			ints.Push(3);
			ints.Push(4);
			ints.Push(5);
			ints.Pop();
			ints.Pop();
			for(int i = 0; i < ints.Count; i++) 
			{
				Console.WriteLine(ints.ElementAt(i));
			}
		}

	}
}
