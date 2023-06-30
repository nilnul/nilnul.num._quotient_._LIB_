using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient._ext
{
	public partial class NegInf1
		:
		nilnul.num.integer._ext.NegInf<Q1>
		,

		ExtI
	{
		static public NegInf1 Singleton = SingletonByDefault<NegInf1>.Instance;
	}
}
