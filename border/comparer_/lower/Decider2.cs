using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.border.comparer_.lower
{
	public class Decider2
		:nilnul.comparer.decider_.FroStatic1<Border2, Lower1>
	{

		static public readonly Decider2 Singleton = SingletonByDefault<Decider2>.Instance;

		public  bool le(Border2 lower, Q1 ext)
		{
			return    le(lower, Border2.CreateClose(ext));

			//throw new NotImplementedException();
		}
	}
}
