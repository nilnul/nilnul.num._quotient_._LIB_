using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.quotient.border.duo.be_;
using R1 = nilnul.num.quotient.bound_.Closed;//.border.duo.be_.Nonempty.En;
using q = nilnul.num.quotient;

namespace nilnul.num.quotient.bound_.closed.op_.unary_
{
	public static class _NegateX
	{
		static public R1 Negate(this R1 x)
		{
			return new R1(
			-(x.upper.mark)
				,
				-(x.lower.mark)

			);
		}

	}

	public  class Negate
		: UnaryI
	{


		static public Negate Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Negate>.Instance;
			}
		}



		public R1 op(R1 arg)
		{
			return _NegateX.Negate(arg);

			//throw new NotImplementedException();
		}
	}
}
