using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using q = nilnul.num.quotient;

namespace nilnul.num.quotient.border.op_.unary_
{
	public  class Square:num.quotient.border.op_.UnaryI
	{

		public  num.quotient.Border2 op(num.quotient.Border2 x) {
			
			return new q.Border2(x.openFalseCloseTrue,
				nilnul.num.quotient.op_.unary_._SquareX.Square(x.mark)
			);
		
		}

		static public Square Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Square>.Instance;
			}
		}

	}
}
