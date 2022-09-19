using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.ext.border.duo.be
{
	public partial class Singleton
	{
		static public bool Eval(Duo1 x) {

			return x.isClose()  
				&& 
				ext.comparer.Decider.Singleton.Equals( x.lower.mark, x.upper.mark);
		
		}
	}
}
