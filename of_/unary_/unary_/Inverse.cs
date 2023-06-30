using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using nilnul.num.rational.op;

using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.op_.unary_
{
	static public class _InverseX
	{
		static public Q1 Op(Q1 x) {
			return 1/x;
		}

	}
	public class Inverse
		: UnaryI

	{
		public Q1 op(Q1 par)
		{
			return _InverseX.Op(par);
			//throw new NotImplementedException();
		}

		static public Inverse Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Inverse>.Instance;
			}
		}

	}


}
