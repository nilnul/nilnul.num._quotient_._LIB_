using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.border.co.be_
{
	public partial class Spanned
	{
		static public bool Eval(Duo x) {
			return comparer.Decider.Singleton.subProper( 
				x.lower.mark 
				,
				x.upper.mark
			);
		}
		static public bool Eval(Duo1 x) {
			return comparer.Re.Singleton.subProper( 
				x.lower.mark 
				,
				x.upper.mark
			);
		}

		static public bool Be(nilnul.num.quotient.border.Co x) {
			return comparer.Re1.Singleton.lt( 
				x.lower.mark 
				,
				x.upper.mark
			);
		}



	}
}
