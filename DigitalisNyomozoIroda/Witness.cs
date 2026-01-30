using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class Witness
	{
		private Person szemtanu;
		private string vallomas;
		private string datum;

		public Witness(Person szemtanu, string vallomas, string datum)
		{
			this.szemtanu = szemtanu;
			this.vallomas = vallomas;
			this.datum = datum;
		}

		public string Vallomas { get => vallomas; set => vallomas = value; }
		public string Datum { get => datum; set => datum = value; }
		internal Person Szemtanu { get => szemtanu; set => szemtanu = value; }


		public override string ToString()
		{
			return $"{this.szemtanu.ToString()}\nVallomás: {this.vallomas}\n\tDátum: {this.datum}";
		}
	}
}
