using System;

namespace DontPanic
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm asendab kõik 'o' tähed lauses "Don't Panic" nulliga - 0;
			//programm asendab kõik 'a' tähed samas lauses 4-ga.

			string dp = "Don't Panic";

			dp = dp.Replace('o', '0');
			dp = dp.Replace('a', '4');
			Console.WriteLine(dp);
		}

	}
	
}
