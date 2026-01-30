using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class Case
	{
		private string ugyazonosito;
		private string cim;
		private string leiras;
		private string allapot;
		private List<Person> szemelyek;
		private List<Evidence> bizonyitekok;
		

		public Case(string ugyazonosito, string cim, string leiras, string allapot)
		{
			this.ugyazonosito = ugyazonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.szemelyek = new List<Person>();
			this.bizonyitekok = new List<Evidence>();
		}

		public string Ugyazonosito { get => ugyazonosito; set => ugyazonosito = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public string Allapot { get => allapot; set => allapot = value; }
		internal List<Person> Szemelyek { get => szemelyek; set => szemelyek = value; }
		internal List<Evidence> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }

		public void AllapotModositas(string allapot)
		{
			this.allapot = allapot;
			Console.WriteLine("Állapot frissitve");
		}

		public override string ToString()
		{
			return $"Ügyaznositó:{this.ugyazonosito} - {this.cim}\nLEirás: {this.leiras}\n\tÁllapot: {this.allapot}";
		}
	}
}
