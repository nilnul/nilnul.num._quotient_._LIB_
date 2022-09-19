using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient._ext
{
	public partial class Inf1
		:

		nilnul.num._ext._generic.Inf<Q1>
		,
		
		ExtI
		
	{
		static public Inf1 Singleton = SingletonByDefault<Inf1>.Instance;

	}
}
