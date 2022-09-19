using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.cut.op
{
	public partial class Multi
	{

		public static Cut Eval(Cut x,Cut y) {
			if (x is null)
			{
				return null;
				
			}
			if (y is null)
			{
				return null;
				
			}



			return new Cut(x.openFalseCloseTrue && y.openFalseCloseTrue, x.pinpoint*y.pinpoint);
		
		}
	}
}
