using System;
using System.Linq;

namespace DigitalisNyomozoIroda
{
	internal class DecisionEngine
	{
		public void Donteshozas(DataStore dataStore)
		{
			Console.WriteLine("=== AKTUÁLIS ÜGYEK ÉS GYANÚSÍTOTTAK ===");
			foreach (var ugy in dataStore.Ugyek)
			{
				Console.WriteLine($"Ügy: [{ugy.Ugyazonosito}] - {ugy.Leiras}");
				foreach (var gyan in ugy.Gyanusitottak)
				{
					Console.WriteLine($"  -> {gyan.Gyanusitott.Nev} (Jelenlegi szint: {gyan.Gyanusszint})");
				}
			}
			Console.WriteLine("-------------------------------");

			bool siker = false;
			do
			{
				Console.Write("\nMelyik ügyben szeretne döntést hozni? (ID): ");
				string ugyId = Console.ReadLine();

				Console.Write("Melyik személy gyanúszintjét módosítsuk? (Név): ");
				string nev = Console.ReadLine();

	
				var kivalasztottUgy = dataStore.Ugyek.FirstOrDefault(u => u.Ugyazonosito == ugyId);

				if (kivalasztottUgy != null)
				{
	
					var gyanusitottKapcsolat = kivalasztottUgy.Gyanusitottak
						.FirstOrDefault(g => g.Gyanusitott.Nev.Equals(nev, StringComparison.OrdinalIgnoreCase));

					if (gyanusitottKapcsolat != null)
					{

						int ujSzint = gyanusitottKapcsolat.Gyanusszint;

						foreach (var biz in kivalasztottUgy.Bizonyitekok)
						{
							if (biz.Megbizhatosag > 3)
								ujSzint += 15; 
							else
								ujSzint -= 5;  
						}

		
						ujSzint = Math.Clamp(ujSzint, 0, 100);
						gyanusitottKapcsolat.Gyanusszint = ujSzint;

						Console.WriteLine($"\nSikeres módosítás! {nev} új gyanúszintje: {ujSzint}");

				
						if (ujSzint >= 75)
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine($"!!! FIGYELEM: {nev} gyanúszintje kritikus ({ujSzint})! Letartóztatás javasolt. !!!");
							Console.ResetColor();
						}

						siker = true;
					}
					else
					{
						Console.WriteLine("Hiba: Ez a személy nem szerepel ebben az ügyben!");
					}
				}
				else
				{
					Console.WriteLine("Hiba: Nincs ilyen azonosítójú ügy!");
				}

			} while (!siker);
		}
	}
}