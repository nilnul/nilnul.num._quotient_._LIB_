using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient
{

	[Obsolete()]
	static public class FlooredX
	{

		static public Floored1 ToFloored(this Q1 x) {
			var t = nilnul.num.integer.duo.op.Divide._Eval_floor_divisorPositive__retTuple(x.numerator, x.denominator.val);

			return new Floored1(
				t.Item1,
				new be.Tail1.En(t.Item2, x.denominator.val)
			);

		}

		static public Floored ToFloored(this Q x) {
			var t = nilnul.num.integer.op.Divide._Eval_floor_divisorPositive__retTuple(x.numerator, x.denominator.val);

			return new Floored(
				t.Item1,
				new be.Tail.Asserted(t.Item2, x.denominator.val)
			);

		}
		static public Floored ToFloored(this _quotient.fraction.Simplified x) {
			var t = nilnul.num.integer.op.Divide._Eval_floor_divisorPositive__retTuple(x.fraction.numerator, x.fraction.denominator.val);

			return new Floored(
				t.Item1,
				new be.Tail.Asserted(t.Item2, x.fraction.denominator.val)
			);

		}

		static public BigInteger Round(this Q x) {
			return x.ToFloored().round();
		}

		static public BigInteger Ceil(this Q x) {
			return x.ToFloored().ceil();

		}

		static public BigInteger Floor(this Q x) {
			return x.ToFloored().floor;

		}



	}

}
