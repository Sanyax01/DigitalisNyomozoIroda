using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class Mainn
	{
		static DecisionEngine decisionEngine = new DecisionEngine();
		static DataStore dataStore = new DataStore();

		static void menu()
		{
			Random r= new Random();
			Console.WriteLine("1.Ügyek kezelése.\n2.Személyek kezelése\n3.Bizonyítékok kezelése\n4.Idővonal megtekintése\n5.Elemzés / döntések\n6.Kilépés\n");
			int input = int.Parse(Console.ReadLine());
			do
			{
				if (input == 1)
				{
					dataStore.ujugy();
					input = 0;
					
				}
				if (input == 2)
				{
					dataStore.szemelyekk();
					input = 0;
				}
				if (input == 3)
				{
					dataStore.bizonyitekokk();
					input = 0;
				}
				if (input == 4)
				{
					dataStore.idovonal();
					input = 0;
				}
				if (input == 5)
				{
					decisionEngine.Donteshozas(dataStore);
					input = 0;
				}
				if (input == 0)
				{
					Console.WriteLine("1.Ügyek kezelése.\n2.Személyek kezelése\n3.Bizonyítékok kezelése\n4.Idővonal megtekintése\n5.Elemzés / döntések\n6.Kilépés\n");
					input = int.Parse(Console.ReadLine());
				}
				else
				{
					Console.WriteLine("Kérem a menüpontból válasszon!");
					input = 0;
					Console.WriteLine();
				}
			}
			while (input != 6);
			



		}



		static void Main(string[] args)
		{
			dataStore.Felhasznalotarolas();
			dataStore.Ugytarolas();
			dataStore.Szemelytarolas();
			dataStore.Gyanusitotttarolas();
			dataStore.Bizonyitektarolas();
			dataStore.Ugygyan();

			menu();

		}


	}
}
