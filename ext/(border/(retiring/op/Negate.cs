using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.ext.bound.op
{
	public partial class Negate
	{
		static public Bound Eval(Bound x) {

			return new Bound
				(x.openFalseCloseTrue, 
				ext.op.Negate.Eval(x.pinpoint)
			);
		
		}
	}
}
namespace nilnul.num.rational.ext.bound.op
{
	public partial class Negate
	{
		static public Bound Eval(Bound x) {

			return new Bound
				(x.openFalseCloseTrue, 
				ext.op.Negate.Eval(x.pinpoint)
			);
		
		}
	}
}
