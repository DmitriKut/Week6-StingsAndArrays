using System;

namespace ACharacterCounter
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib kasatajalt sisestada ees-ja perekonnanime
			//programm kuvab, mitu "a" tähte on kasutaja ees-ja perekonnanimes kokku

			Console.WriteLine("sisesta eesnimi:");
			string firstName = Console.ReadLine();
			Console.WriteLine("sisesta perekonnanimi:");
			string lastName = Console.ReadLine();

			string fullname = $"{firstName}{lastName}".ToLower();

			Console.WriteLine(fullname);

			int aCounter = 0;

			for (int i = 0; i < fullname.Length; i++)
			{
				if (fullname[i] == 'a')
				{
					aCounter++;
				}
			}
				if (aCounter != 1)
				{
					Console.WriteLine($"Sinu täisnimes {firstName} on {aCounter} 'a' tähte");
				}
				else
				{
					Console.WriteLine($"Sinu täisnimes {firstName} on {aCounter} 'a' täht");
				}

			
		}

	}
}
