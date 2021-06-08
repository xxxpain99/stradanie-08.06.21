using System;

namespace ConsoleApp22
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<int> ert = new MyList<int>();
			ert.Add(45);
			ert.Add(55);
			ert.Add(65);
			ert.AddFront(89);
			ert.Print();

		}
	}
}
