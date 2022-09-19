using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using R1 = nilnul.num.quotient.bound_.Closed;//.Range1;//.duo.be_.Nonempty.En;

using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.bound_.closed.op_.unary_
{
	static public class _ScaleX
	{
		static public R1 Scale(Q1 scale, R1 cut) {


			if (scale==0)
			{
				return new R1();

			}
			if (scale>0)
			{
				return new R1(
					(scale* cut.lower)
					, 
					(scale*cut.upper)
				);
			}

			return new R1(
					(scale*cut.upper)

					, 
					(scale* cut.lower)
			
			);
		
		}

	}
}
