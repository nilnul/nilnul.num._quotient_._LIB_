using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.ext_
{
	public partial class NegInf
		:
		ExtA,

		nilnul.ext_.NegInfI<Q1>
		,

		ExtI
	{
		static public NegInf Singleton = SingletonByDefault<NegInf>.Instance;
	}
}
