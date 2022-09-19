using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._quotient.fraction.op;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.be
{
	[Obsolete("Proper")]
	public partial class Tail1:nilnul.BeI<Q1>
	{
		

		public bool be(Q1 obj)
		{
			return obj>=0 && obj < 1;

			throw new NotImplementedException();
		}

		public class En
			:
			nilnul.be.Asserted<Q1,Tail1>
		{
			public En(Q1 r)
				:base(r)
			{

			}

			public En(BigInteger num, BigInteger den)
				:this(new Q1(num,den))
			{

			}

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

		}
	}
}
