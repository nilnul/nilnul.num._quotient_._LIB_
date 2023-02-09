using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._quotient.fraction.op;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.be_
{
	[Obsolete()]
	public  class GeZeroLeOne:nilnul.BeI<Q1>
	{
		

		public bool be(Q1 obj)
		{
			return obj>=0 && obj <= 1;

			//throw new NotImplementedException();
		}

		public class En
			:
			nilnul.be.Asserted<Q1,GeZeroLeOne>
		{
			public En(Q1 r)
				:base(r)
			{

			}

			public En(BigInteger num, BigInteger den)
				:this(new Q1(num,den))
			{

			}

			public BigInteger numerator {
				get {
					return val.numerator;
				}
			}

			public nilnul._num.bigint.be.Positive.Asserted denominator { get {
					return val.denominator;

			} }

			public override string ToString()
			{
				return val.ToString();
			}

			public BigInteger round() {
				if (val >= Q1.CreateHalf()) return 1;
				return 0;
			}

			public BigInteger ceil() {
				return val == 0 ? 0 : 1;
			}

			public BigInteger floor() {
				return 0;
			}

			static public Tuple<BigInteger, En> ToMixedFrac(Q1 x)
			{
				var t = nilnul.num.integer.op.Divide._Eval_floor_divisorPositive__retTuple(x.numerator, x.denominator.val);

				return new Tuple<BigInteger, En>(
					t.Item1,
					new En(t.Item2, x.denominator.val)
				);

			}


		}
	}
}
