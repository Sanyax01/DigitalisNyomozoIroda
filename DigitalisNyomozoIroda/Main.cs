using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class Mainn
	{
		static CaseManager cmanager = new CaseManager();
		static TimeLineEvents timeline = new TimeLineEvents();

		static void menu()
		{
			Random r= new Random();
			Console.WriteLine("1.Ügyek kezelése.\n2.Személyek kezelése\n3.Bizonyítékok kezelése\n4.Idővonal megtekintése\n5.Elemzés / döntések\n6.Kilépés\n");
			int input = int.Parse(Console.ReadLine());
			do
			{
				if (input == 1)
				{
					
					Console.WriteLine("Új ügy létrehozása:\n");
					int azo = r.Next(10000,100000);
					string azonosito = azo.ToString();
					Console.WriteLine("Cím: ");
					string cim = Console.ReadLine();
					Console.WriteLine("Leirás: ");
					string leiras = Console.ReadLine();
					Console.WriteLine("Állapot: ");
					string allapot = Console.ReadLine();
					Case c = new Case(azonosito,cim,leiras,allapot);
					cmanager.UgyLetrehozas(c);
					input = 0;
					Console.WriteLine();
				}
				if (input == 2)
				{
					Console.WriteLine("Új személy ügyhöz hozzáadása:\n");
					Console.WriteLine("Név: ");
					string nev = Console.ReadLine();
					Console.WriteLine("Kor: ");
					int kor = int.Parse(Console.ReadLine());
					Console.WriteLine("Megjegyzés: ");
					string leiras = Console.ReadLine();
					Console.WriteLine(cmanager);
					Console.WriteLine("Melyik ügyhöz kivánja hozzá adni a személyt?(adja meg az ügyazonositot) ");
					string ugy = Console.ReadLine();
					Person p = new Person(nev,kor,leiras);
					cmanager.Szhozaadas(p,ugy);
					input = 0;
					Console.WriteLine();
				}
				if (input == 3)
				{
					Console.WriteLine("Új bizonyiték ügyhöz hozzáadása:\n");
					int azo = r.Next(100, 1000);
					string azonosito = azo.ToString();
					Console.WriteLine("Típus: ");
					string tipus = Console.ReadLine();
					Console.WriteLine("Leirás: ");
					string leiras = Console.ReadLine();
					Console.WriteLine("Megbízhatóság(1-5): ");
					int megbizhato = int.Parse(Console.ReadLine());
					Console.WriteLine(cmanager);
					Console.WriteLine("Melyik ügyhöz kivánja hozzá adni a személyt?(adja meg az ügyazonositot) ");
					string ugy = Console.ReadLine();
					Evidence e = new Evidence(azonosito, tipus, leiras, megbizhato);
					cmanager.Bhozaadas(e, ugy);
					input = 0;
					Console.WriteLine();
				}
				if (input == 4)
				{
					Console.WriteLine("Idővonal:");
					Console.WriteLine(timeline);
					input = 0;
					Console.WriteLine();
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
