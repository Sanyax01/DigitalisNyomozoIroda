using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class DecisionEngine
	{
		static List<string> azonositok = new List<string>();
		static List<string> szemelyek = new List<string>();
		public void Donteshozas(DataStore dataStore)
		{
			

			string ugy = "";
			string szemely = "";
			string eredmeny = "Nincs döntés";
			bool talalt = false;

			do
			{
				Console.Write("Ügyazonosító: ");
				ugy = Console.ReadLine();
				Console.Write("Személy neve: ");
				szemely = Console.ReadLine();

				
				var kivalasztottUgy = dataStore.Ugyek.FirstOrDefault(u => u.Ugyazonosito == ugy);

				if (kivalasztottUgy != null)
				{
					
					var gyanusitott = kivalasztottUgy.Gyanusitottak.FirstOrDefault(g => g.Gyanusitott.Nev == szemely);

					if (gyanusitott != null)
					{
						
						bool vanErosBizonyitek = kivalasztottUgy.Bizonyitekok.Any(b => b.Megbizhatosag > 3);

						if (vanErosBizonyitek)
							eredmeny = $"{szemely} Bűnös!";
						else
							eredmeny = $"{szemely} Nem bűnös (nincs elég erős bizonyíték)";

						talalt = true; 
					}
					else
					{
						Console.WriteLine("Hiba: Ez a személy nem gyanúsított ebben az ügyben!");
					}
				}
				else
				{
					Console.WriteLine("Hiba: Nincs ilyen ügyazonosító!");
				}

			} while (!talalt);

			Console.WriteLine("\nEredmény: " + eredmeny);
		}



	}
}
