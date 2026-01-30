using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class EvidenceManager
	{
		List<Evidence> bizonyitekok;
		List<Evidence> raktar;

		public EvidenceManager ()
		{
			bizonyitekok = new List<Evidence> ();
			raktar = new List<Evidence> ();

		}


		public void bizonyitekHozaadasa(Evidence bizonyitek)
		{
			if (bizonyitek != null) 
			{
				if (raktar.Contains(bizonyitek))
				{
					raktar.Remove(bizonyitek);
					bizonyitekok.Add(bizonyitek);

				}
				else if (bizonyitekok.Contains(bizonyitek))
				{
					Console.WriteLine("Ez a bizonyiték már létezik!");

				}
				else
				{
					bizonyitekok.Add(bizonyitek);
				}
			}
			
		}

		public Evidence bizonyitekTorlese(Evidence item)
		{
			if (bizonyitekok.Contains(item))
			{
				raktar.Add(item);
				bizonyitekok.Remove(item);
			}
			else 
			{
				Console.WriteLine("Ez a bizonyiték nem létezik!"); 
			}
			return item;
		}
	}
}
