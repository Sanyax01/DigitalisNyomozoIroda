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

		public void Szhozaadas(Person szemely, Case ugy)
		{
			foreach (var item in ugyek)
			{
				if (item.Ugyazonosito == ugy.Ugyazonosito)
				{ 
					item.Szemelyek.Add(szemely);
				}
			
			}
		
		}

		public void Bhozaadas(Evidence bizonyitek, Case ugy)
		{
			foreach (var item in ugyek)
			{
				if (item.Ugyazonosito == ugy.Ugyazonosito)
				{
					item.Bizonyitekok.Add(bizonyitek);
				}

			}

		}

	}
}
