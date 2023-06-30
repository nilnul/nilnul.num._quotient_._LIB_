using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.ext.border.comparer_.lower
{
	public class Decider
		:nilnul.comparer.decider_.FroStatic<ext.Border1, LowerComparer>
	{

		static public readonly Decider Singleton = SingletonByDefault<Decider>.Instance;

		public  bool contains(Border1 lower, ExtI ext)
		{
			return inside(lower, Border1.CreateClose(ext));

			throw new NotImplementedException();
		}
	}
}
