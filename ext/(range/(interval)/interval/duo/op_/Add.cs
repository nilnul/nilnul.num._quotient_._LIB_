using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interval = nilnul.num.quotient.ext.border.duo.be_.Nonempty_Bare.En;

namespace nilnul.num.quotient.interval.duo.op_
{
	public partial class Add
	{
		static public Interval Eval(
			Interval x
			,
			Interval y
			
		) {

			return new Interval(

				x.lower+y.lower
				,
				x.upper+y.upper

			);

			throw new NotImplementedException();
		
		}
	}
}

