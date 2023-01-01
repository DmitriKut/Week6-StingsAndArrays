using System;

namespace HOLCounter
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"

			string hw = "Hello World!".ToLower();
			{
				int hCounter = 0;

				for (int i = 0; i < hw.Length; i++)
				{
					if (hw[i] == 'h')
					{
						hCounter++;
					}
				}
				if (hCounter != 1)
				{
					Console.WriteLine($"Hello World! lauses on {hCounter} 'h' tähte");
				}
				else
				{
					Console.WriteLine($"Hello World! lauses on {hCounter} 'h' täht");
				}
			}
			{
				int oCounter = 0;

				for (int i = 0; i < hw.Length; i++)
				{
					if (hw[i] == 'o')
					{
						oCounter++;
					}
				}
				if (oCounter != 1)
				{
					Console.WriteLine($"Hello World! lauses on {oCounter} 'o' tähte");
				}
				else
				{
					Console.WriteLine($"Hello World! lauses on {oCounter} 'o' täht");
				}
			}
			{
				int lCounter = 0;

				for (int i = 0; i < hw.Length; i++)
				{
					if (hw[i] == 'l')
					{
						lCounter++;
					}
				}
				if (lCounter != 1)
				{
					Console.WriteLine($"Hello World! lauses on {lCounter} 'l' tähte");
				}
				else
				{
					Console.WriteLine($"Hello World! lauses on {lCounter} 'l' täht");
				}
			}
		}
	}
}
