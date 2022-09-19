using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;


namespace nilnul.num.quotient._ext
{
	public partial class NegInf
		:
		nilnul.num.integer._ext._generic.NegInf<Q>
		,

		ExtI
	{
		static public NegInf Singleton = SingletonByDefault<NegInf>.Instance;
	}
}
