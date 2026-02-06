using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class DataStore
	{
		List<User> felhasznalok;
		List<Case> ugyek;
		List<Person> szemelyek;
		List<Evidence> bizonyitekok;

		public List<User> Felhasznalok { get => felhasznalok; set => felhasznalok = value; }
		public List<Case> Ugyek { get => ugyek; set => ugyek = value; }
		public List<Person> Szemelyek { get => szemelyek; set => szemelyek = value; }
		public List<Evidence> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }

		public DataStore()
		{
			Felhasznalok = new List<User>();
			Ugyek = new List<Case>();
			Szemelyek = new List<Person>();
			Bizonyitekok = new List<Evidence>();

		}

		static Case c = new Case("11111", "Úri gyilkosság", "3 cigányt lelőtek", "Folyamatban");
		static Person p = new Person("Jancsi", 24, "Chill guy");
		static Person p1 = new Person("Feri", 68, "Gyanus");
		static Suspect s = new Suspect(p1, 89, "Őrizetben");
		static Witness w = new Witness(p, "Egy kamerával szaladt el", "1977.09.11");
		static TimelineEvent t = new TimelineEvent(w.Datum, $"{w.Szemtanu.Nev} vallott");
		static Evidence e = new Evidence("987", "fotó", "fotó egy leirásnak megfeleő kameráról", 4);


		static Case c2 = new Case("23434", "Bank rablás", "Alacsony ember kirabolt 13 bankot Gyömrőn", "Folyamatban");
		static Person p2 = new Person("Ilona", 10, "Biztos hogy gyanus");
		static Person p3 = new Person("Béla", 79, "Nem gyanus egyáltalán");
		static Person p4 = new Person("Gergő", 18, "Japán");
		static Suspect s1 = new Suspect(p2, 14, "Szabad");
		static Witness w1 = new Witness(p4, "Alacsony kopasz, női ruhában volt", "2027.04.05");
		static TimelineEvent t1 = new TimelineEvent(w1.Datum, $"{w1.Szemtanu.Nev} vallott");
		static Evidence e1 = new Evidence("027", "digitális adat", "9 terrabite kép női ruhákról", 1);
		public void Felhasznalotarolas(List<User> users)
		{
			User u = new User("Arion", "4678", "elemző");
			User u1 = new User("Gobma", "666", "nyomozó");
			User u2 = new User("Vince", "1233", "admin");
			felhasznalok.Add(u);
			felhasznalok.Add(u1);
			felhasznalok.Add(u2);
		}

		public void Ugytarolas(List<Case> cases)
		{
			ugyek.Add(c);
			ugyek.Add(c2);
		}

		public void Szemelytarolas(List<Person> persons)
		{

			szemelyek.Add(p);
			szemelyek.Add(p1);
			szemelyek.Add(p2);
			szemelyek.Add(p3);
			szemelyek.Add(p4);
		}

		public void Bizonyitektarolas(List<Evidence> evidences)
		{
			bizonyitekok.Add(e);
			bizonyitekok.Add(e1);
		}
		static CaseManager cmanager = new CaseManager();
		static TimeLineEvents timeline = new TimeLineEvents();
		static Random r = new Random();
		public void hozzarendelesek()
		{
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

		}

		public void ujugy()
		{
			Console.WriteLine("Új ügy létrehozása:\n");
			int azo = r.Next(10000, 100000);
			string azonosito = azo.ToString();
			Console.WriteLine("Cím: ");
			string cim = Console.ReadLine();
			Console.WriteLine("Leirás: ");
			string leiras = Console.ReadLine();
			Console.WriteLine("Állapot: ");
			string allapot = Console.ReadLine();
			Case c = new Case(azonosito, cim, leiras, allapot);
			cmanager.UgyLetrehozas(c);
			Console.WriteLine();

		}

		public void szemelyekk()
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
			Person p = new Person(nev, kor, leiras);
			cmanager.Szhozaadas(p, ugy);
			Console.WriteLine();
		}

		public void bizonyitekokk()
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
			Console.WriteLine();
		}

		public void idovonal()
		{
			Console.WriteLine("Idővonal:");
			Console.WriteLine(timeline);
			Console.WriteLine();

		}
	}
}
