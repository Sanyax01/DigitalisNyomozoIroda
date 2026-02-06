using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class Mainn
	{
		static DataStore DataStore = new DataStore();

		static void menu()
		{
			Random r= new Random();
			Console.WriteLine("1.Ügyek kezelése.\n2.Személyek kezelése\n3.Bizonyítékok kezelése\n4.Idővonal megtekintése\n5.Elemzés / döntések\n6.Kilépés\n");
			int input = int.Parse(Console.ReadLine());
			do
			{
				if (input == 1)
				{
					DataStore.ujugy();
					input = 0;
					
				}
				if (input == 2)
				{
					DataStore.szemelyekk();
					input = 0;
				}
				if (input == 3)
				{
					DataStore.bizonyitekokk();
					input = 0;
				}
				if (input == 4)
				{
					DataStore.idovonal();
					input = 0;
				}
				if (input == 5)
				{
					input = 0;
					Console.WriteLine();
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
			Case c = new Case("11111", "Úri gyilkosság", "3 cigányt lelőtek", "Folyamatban");
			Person p = new Person("Jancsi", 24, "Chill guy");
			Person p1 = new Person("Feri", 68, "Gyanus");
			Suspect s = new Suspect(p1, 89, "Őrizetben");
			Witness w = new Witness(p, "Egy kamerával szaladt el", "1977.09.11");
			TimelineEvent t = new TimelineEvent(w.Datum,$"{w.Szemtanu.Nev} vallott");
			Evidence e = new Evidence("987", "fotó", "fotó egy leirásnak megfeleő kameráról", 4);


			Case c2 = new Case("23434", "Bank rablás", "Alacsony ember kirabolt 13 bankot Gyömrőn", "Folyamatban");
			Person p2 = new Person("Ilona", 10, "Biztos hogy gyanus");
			Person p3 = new Person("Béla", 79, "Nem gyanus egyáltalán");
			Person p4 = new Person("Gergő", 18, "Japán");
			Suspect s1 = new Suspect(p2, 14, "Szabad");
			Witness w1 = new Witness(p4, "Alacsony kopasz, női ruhában volt", "2027.04.05");
			TimelineEvent t1 =  new TimelineEvent(w1.Datum,$"{w1.Szemtanu.Nev} vallott");
			Evidence e1 = new Evidence("027", "digitális adat", "9 terrabite kép női ruhákról", 1);


			timeline.Idoponthozzaadas(t);
			timeline.Idoponthozzaadas(t1);
			cmanager.Szhozaadas(p, "11111");
			cmanager.Szhozaadas(p1, "11111");
			cmanager.Bhozaadas(e, "11111");
			cmanager.Szhozaadas(p2, "23434");
			cmanager.Szhozaadas(p3, "23434");
			cmanager.Szhozaadas(p4, "23434");
			cmanager.Bhozaadas(e1, "23434");
			cmanager.UgyLetrehozas(c);
			cmanager.UgyLetrehozas(c2);


			menu();

		}


	}
}
