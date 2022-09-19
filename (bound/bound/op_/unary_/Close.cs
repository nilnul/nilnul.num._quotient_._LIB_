using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.quotient.border.duo.be_;
using R1 = nilnul.num.quotient.Bound;
using q = nilnul.num.quotient;

namespace nilnul.num.quotient.bound.op_.unary_
{
	/// <summary>
	/// by merging border
	/// </summary>
	public partial class MergeBorder
		: bound.op_.UnaryI
	{






		public R1 op(R1 arg)
		{
			return R1.CreateClose(arg.lower.mark, arg.upper.mark );

			
		}

		static public MergeBorder Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<MergeBorder>.Instance;
			}
		}

	}
}
