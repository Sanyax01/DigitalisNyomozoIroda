using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class CaseStatus
	{
		private string aktualisstatus;

		public CaseStatus(string aktualisstatus)
		{
			this.aktualisstatus = aktualisstatus;
		}

		public string Aktualisstatus { get => aktualisstatus; set => aktualisstatus = value; }


		public string AllapotModositas(string allapot)
		{
			aktualisstatus = allapot;
			return aktualisstatus;

		}
	}
}
