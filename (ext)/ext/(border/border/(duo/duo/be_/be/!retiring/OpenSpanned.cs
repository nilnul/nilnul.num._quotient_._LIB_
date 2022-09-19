using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.bound.pair.be
{
	public partial class OpenSpanned
	{
		static public bool Eval(Pair x) {
			return Open.Eval(x) && Spanned.Eval(x);
		}

		public class Be:
			nilnul.bit.Be<Pair>
		{
			public Be()
				:base(Eval)
			{

			}

		}
		[Obsolete("Asserted")]
		public class Expr
			: nilnul.bit.be.Asserted<Pair, Be>

		{

			

			public Expr(Pair val)
				: base(val)
			{

			}


		}
		public class Asserted
			: nilnul.bit.be.Asserted<Pair, Be>

		{

			static public bool ContainInt__spanLessThanOne(Q lower, Q upper)
			{

				if (Q.IsInt(lower))
				{
					if (Q.IsInt(upper))
					{
						return false;
					}
					return false;
				}
				if (Q.IsInt(upper))
				{
					return false;
				}

				return Q.GetFloor(lower) != Q.GetFloor(upper);
			}

			public Asserted(Pair val)
				: base(val)
			{

			}


		}

	}
}
