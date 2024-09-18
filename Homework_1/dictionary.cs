using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
	internal class dictionary
	{
		static void Dict(string[] args)
		{
			Dictionary<string, int> dict = new Dictionary<string, int>();
			dict.Add("One", 1);
			dict.Add("Two", 2);
			dict.Add("Three", 3);
			dict.Add("Four", 4);
			dict.Add("Five", 5);
			Console.WriteLine(dict.Sum(x => x.Value));
		}
	}
}
