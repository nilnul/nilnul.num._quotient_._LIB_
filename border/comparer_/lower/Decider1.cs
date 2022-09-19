using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.border.comparer_.lower
{
	[Obsolete(nameof(Re))]
	public class Decider1
		:nilnul.comparer.decider_.FroStatic1<Border1, Lower>
	{

		static public readonly Decider1 Singleton = SingletonByDefault<Decider1>.Instance;

		public  bool le(Border1 lower, Q1 ext)
		{
			return    le(lower, Border1.CreateClose(ext));

			//throw new NotImplementedException();
		}
	}
}
