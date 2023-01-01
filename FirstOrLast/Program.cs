using System;

namespace FirstOrLast
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib kastutajal sisestada ees-ja perekonnanime;
			//programm kontrollib andmete pikkust;
			//programm kuvab kumb nendest on pikem, kas ees-või perekonnanmi.

			Console.WriteLine("sisesta eesnimi:");
			string firstName = Console.ReadLine();

			// int firstNameLength = firstName.Length;
			Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");

			Console.WriteLine("sisesta perekonnanimi:");
			string lastName = Console.ReadLine();

			// int firstNameLength = firstName.Length;
			Console.WriteLine($"Sinu eesnimes on {lastName.Length} sümbolit.");

			if (firstName.Length < lastName.Length)
			{
				Console.WriteLine("Perekonnanimi on pikem, kui eesnimi.");
			}
			else if (firstName.Length > lastName.Length)
			{
				Console.WriteLine("Eesmini on pikem, kui perekonnanimi.");
			}
			else
			{
				Console.WriteLine("Eesmini ja perekonnanimi on sama pikkusega.");
			}

			Console.WriteLine("Kena päeva!");
		}
	}
}
