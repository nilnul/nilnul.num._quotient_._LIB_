using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.border.comparer_.upper
{
	[Obsolete()]
	public class Decider
		:nilnul.comparer.decider_.FroStatic1<Border1, Lower>
	{

		static public readonly Decider Singleton = SingletonByDefault<Decider>.Instance;

		public  bool le(Border1 upper, Q1 ext)
		{
			return    le(upper, Border1.CreateClose(ext));

			//throw new NotImplementedException();
		}
	}
}
