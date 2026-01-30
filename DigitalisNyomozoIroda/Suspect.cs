using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class Suspect
	{
		private Person gyanusitott;
		private int gyanusszint;

		public Suspect(Person gyanusitott, int gyanusszint)
		{
			this.gyanusitott = gyanusitott;
			this.gyanusszint = gyanusszint;
		}

		public int Gyanusszint { get => gyanusszint; set => gyanusszint = value; }
		internal Person Gyanusitott { get => gyanusitott; set => gyanusitott = value; }

		public override string ToString()
		{
			return $"{this.gyanusitott.Nev} - {this.gyanusitott.Eletkor}\nGyanúsítottsági szint(0-100): {this.gyanusszint}";
		}
	}
}
