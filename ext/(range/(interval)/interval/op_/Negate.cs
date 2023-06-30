using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interval = nilnul.num.quotient.ext.border.duo.be_.Nonempty_Bare.En;

namespace nilnul.num.quotient.interval.op_
{
	public partial class Negate
	{
		static public Interval Eval(Interval x) {
			return new Interval(

				-(x.upper)
				,
				-(x.lower)
				
			);
		}
	}
}

