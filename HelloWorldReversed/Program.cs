using System;

namespace HelloWorldReversed
{
	class Program
	{
		static void Main(string[] args)
		{
			//program kuvab lauset "Hello, World!" tagurpidi.

			Console.WriteLine("Hello, World!");
			string hw = "Hello World!";



			for (int i = hw.Length - 1; i >= 0; i--)
			{
				Console.Write(hw[i]);
			}
		}
	}
}
