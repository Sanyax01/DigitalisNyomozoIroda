using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class TimelineEvent
	{
		private string datum;
		private string esemeny;

		public TimelineEvent(string datum, string esemeny)
		{
			this.datum = datum;
			this.esemeny = esemeny;
		}

		public string Datum { get => datum; set => datum = value; }
		public string Esemeny { get => esemeny; set => esemeny = value; }

		public override string ToString() 
		{
			return $"Dátum:{this.datum} esemény:{this.esemeny}";
		}
	}
}
