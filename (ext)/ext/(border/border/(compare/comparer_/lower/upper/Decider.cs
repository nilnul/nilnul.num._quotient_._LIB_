using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.ext.border.comparer_.lower.upper
{
	public class Decider
		:nilnul.comparer.decider_.FroStatic<ext.Border1, UpperComparer>
	{

		static public readonly Decider Singleton = SingletonByDefault<Decider>.Instance;

		public bool contains(  Border1 upper, ExtI ext)
		{
			return inside( Border1.CreateClose(ext), upper);

			throw new NotImplementedException();
		}

	}
}
