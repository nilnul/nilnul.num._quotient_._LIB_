using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using nilnul.num.rational.op;

using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.op_.unary_
{
	static public class _NegX
	{
		static public Q1 Op(Q1 x) {
			return -x;
		}

	}
	public class Neg
		: UnaryI

	{
		public Q1 op(Q1 par)
		{
			return -par;
			//throw new NotImplementedException();
		}

		static public Neg Singleton
		{
			get
			{
				return nilnul.Singleton1<Neg>.Instance;
			}
		}

	}


}
