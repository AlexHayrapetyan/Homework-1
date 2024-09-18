using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
	internal class queue
	{
		static void queues(string[] args)
		{
			Queue<int> queue = new Queue<int>();
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);
			queue.Enqueue(4);
			queue.Enqueue(5);
			queue.Dequeue();
			queue.Dequeue();
			for(int i = 0; i < queue.Count(); i++) 
			{
				Console.WriteLine(queue.ElementAt(i));
			}
		}

	}
}
