using System;

namespace StringReplace
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm asendab kõik 'o' lauses "Hello World!" tärniga

			string hellow = "Hello World!";

			/* for (int i = 0; i < hellow.Length; i++)
			{
				hellow[i] = '*'; // sõnad on muutumatu
			}*/

			hellow = hellow.Replace('o', '*');
			hellow = hellow.Replace('!', '1');
			Console.WriteLine(hellow);
		}
	}
}
