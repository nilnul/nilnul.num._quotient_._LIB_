using nilnul.num.quotient._ext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.ext.op
{
	public partial class Abs
	{
		static public num.quotient._ext.ExtI Eval(num.quotient._ext.ExtI x) {
			if (x is _ext.NegInf)
			{
				return new _ext.Inf();
				
			}
			if (x is _ext.Inf)
			{
				return new _ext.NegInf();
			}
			return new _ext.Base(Q.ToAbs((x as  _ext.Base).val));
		}

		static public num.quotient.ExtI Eval(num.quotient.ExtI x) {
			if (x is ext_.NegInf)
			{
				return new ext_.Inf();
				
			}
			if (x is ext_.Inf)
			{
				return x;
			}
			return new ext_.Bare( quotient.op.Abs.Eval((x as  ext_.Bare).q));
		}



	}
}
