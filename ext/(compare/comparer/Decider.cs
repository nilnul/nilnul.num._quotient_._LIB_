using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.ext.comparer
{
	public class Decider
		:nilnul.ext.comparer.decider_.froExtComparer.froBareComparer.FroStatic<Q1,quotient.Comparer1>
	{

		static public readonly Decider Singleton = SingletonByDefault<Decider>.Instance;


	}
}
