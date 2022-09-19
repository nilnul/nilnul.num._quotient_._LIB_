using nilnul.num.quotient.ext.bound.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interval = nilnul.num.quotient.ext.border.duo.be_.Nonempty_Bare.En;

namespace nilnul.num.quotient.interval.duo.op_
{
	public partial class Minus
	{
		static public Interval Eval(
			Interval x
			,
			Interval y
			
		) {

			return Add.Eval(
				x, 
				interval.op_.Negate.Eval(y)	
			);

			

			throw new NotImplementedException();
		
		}
	}
}
