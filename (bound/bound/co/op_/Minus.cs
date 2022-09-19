using nilnul.num.quotient.ext.bound.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using B = nilnul.num.quotient.border.duo.be_.Nonempty.En;

namespace nilnul.num.quotient.range.duo.op_
{
	public partial class Minus
	{
		static public B Eval(
			B x
			,
			B y
			
		) {

			return Add.Eval(
				x, 
				range.op_.Negate.Singleton.eval(y)	
			);

			

			throw new NotImplementedException();
		
		}
	}
}
