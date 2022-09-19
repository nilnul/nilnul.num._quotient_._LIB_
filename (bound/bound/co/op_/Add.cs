using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interval = nilnul.num.quotient.border.duo.be_.Nonempty.En;

namespace nilnul.num.quotient.range.duo.op_
{
	public  class Add
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

