using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num._quotient.fraction.Simplified;
using System.Numerics;
using nilnul.num.rational.op;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.op
{
	[Obsolete()]
	public partial class Abs

	{
		

		static public _quotient.fraction.Simplified Eval(_quotient.fraction.Simplified x) {
			return new _quotient.fraction.Simplified(BigInteger.Abs( x.fraction.numerator), x.fraction.denominator);
		}


		static public Q1 Eval(Q1 x) {
			return new Q1(BigInteger.Abs( x.fraction.numerator), x.fraction.denominator);
		}




		public class Done
		{
			private _quotient.fraction.Simplified _result;

			public _quotient.fraction.Simplified result
			{
				get { return _result; }
				set { _result = value; }
			}

			public Done(_quotient.fraction.Simplified x)
			{
				_result = Eval(x);
			}
			public BigInteger ceil() {
				return FlooredX.ToFloored(this._result).ceil();
			}

			public BigInteger truncate() {
				return FlooredX.ToFloored(this._result).floor;
			}
		}
	}


}
