using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient._ext
{
	public partial class Inf
		:

		nilnul.num._ext._generic.Inf<Q>
		,
		
		ExtI
		
	{
		static public Inf Singleton = SingletonByDefault<Inf>.Instance;

	}
}
