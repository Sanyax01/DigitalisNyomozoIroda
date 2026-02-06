using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class CaseManager
	{
		List<Case> ugyek;

		internal List<Case> Ugyek { get => ugyek; set => ugyek = value; }

		public CaseManager() 
		{
			ugyek = new List<Case>();
		}

		public void UgyLetrehozas(Case ugy)
		{
			if (ugy != null)
			{
				ugyek.Add(ugy);
			}

		}

		public void UgyListazas()
		{
			foreach (var item in ugyek)
			{
				Console.WriteLine(item);
				Console.WriteLine("-----------------------");
			}
		
		}

		public void Szhozaadas(Person szemely, string ugy)
		{
			foreach (var item in ugyek)
			{
				if (item.Ugyazonosito == ugy)
				{ 
					item.Szemelyek.Add(szemely);
				}
			
			}
		
		}

		public void Bhozaadas(Evidence bizonyitek, string ugy)
		{
			foreach (var item in ugyek)
			{
				if (item.Ugyazonosito == ugy)
				{
					item.Bizonyitekok.Add(bizonyitek);
				}

			}

		}


		public override string ToString()
		{
			string s = "";
			foreach (var item in ugyek)
			{
				s = s + $"Ügy: {item.Leiras}, azonosító: {item.Ugyazonosito}\n";
			}
			return s;
		}

	}
}
