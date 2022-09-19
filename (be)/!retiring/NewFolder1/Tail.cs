using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.be
{
	public partial class Tail
	{
		static public bool Eval(Q x) {
			return x.isNonneg && x < 1;
		}

		public class Be:nilnul.bit.Be<Q>
			
		{
			public Be()
				:base(Eval)
			{

			}
		}
		public class Asserted
			:
			nilnul.bit.be.Asserted<Q,Be>
		{
			public Asserted(Q r)
				:base(r)
			{

			}

			public Asserted(BigInteger num, BigInteger den)
				:this(new Q(num,den))
			{

			}

			public override string ToString()
			{
				return val.ToString();
			}

			public BigInteger round() {
				if (val >= Q.CreateHalf()) return 1;
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
