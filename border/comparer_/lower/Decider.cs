using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.border.comparer_.lower
{
	[Obsolete()]
	public class Decider
		:nilnul.comparer.decider_.FroStatic<Border1, Lower>
	{

		static public readonly Decider Singleton = SingletonByDefault<Decider>.Instance;

		public  bool contains(Border1 lower, Q1 ext)
		{
			return    inside(lower, Border1.CreateClose(ext));

			throw new NotImplementedException();
		}
	}
}
