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
		private string statusz;

		public Suspect(Person gyanusitott, int gyanusszint, string statusz)
		{
			this.gyanusitott = gyanusitott;
			this.gyanusszint = gyanusszint;
			this.statusz = statusz;
		}

		public int Gyanusszint { get => gyanusszint; set => gyanusszint = value; }
		public string Status { get => statusz; set => statusz = value; }
		internal Person Gyanusitott { get => gyanusitott; set => gyanusitott = value; }

		public override string ToString()
		{
			return $"{this.gyanusitott.Nev} - {this.gyanusitott.Eletkor}\nGyanúsítottsági szint(0-100): {this.gyanusszint}";
		}
	}
}
