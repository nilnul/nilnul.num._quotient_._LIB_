using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using q = nilnul.num.quotient;


namespace nilnul.num.quotient.border.op_.unary_
{
	public  class Negate:q.border.op_.UnaryI
	{

		public q.Border2 op(q.Border2 x) {
			
			return new q.Border2(x.openFalseCloseTrue, -x.mark);
		
		}


		static public Negate Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Negate>.Instance;
			}
		}

	}
}
