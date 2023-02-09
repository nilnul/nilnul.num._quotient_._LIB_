using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.be
{
	public class NonZero
		: nilnul.BeI<Q1>
	{
		public bool be(Q1 obj)
		{
			return obj.numerator == 0;
			throw new NotImplementedException();
		}

		public class En : nilnul.be.Asserted<Q1, NonZero>
		{
			public En(Q1 val) : base(val)
			{


			}
			[Obsolete()]
			static public Q1 Inverse(Q1 q)
			{
				return new Q1(q.denominator, q.numerator);
			}
			static public Q1 _Inverse(Q1 q)
			{
				return new Q1(q.denominator, q.numerator);
			}
		}
	}
}
