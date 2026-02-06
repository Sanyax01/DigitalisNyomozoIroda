using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozoIroda
{
	internal class TimeLineEvents
	{
		List<TimelineEvent> events;

		internal List<TimelineEvent> Events { get => events; set => events = value; }

		public TimeLineEvents()
		{
			events = new List<TimelineEvent>();
		}

		public void Idoponthozzaadas(TimelineEvent ido)
		{
			if (ido != null)
			{
				events.Add(ido);
			}

		}

		public override string ToString()
		{
			string s = "";
			foreach (var item in events)
			{
				s = s + $"Időpont: {item.Datum}, esemény: {item.Esemeny}\n";
			}
			return s;
		}

	}
}
