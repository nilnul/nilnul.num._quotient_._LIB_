using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.border.duo.be_;
using q = nilnul.num.quotient;

namespace nilnul.num.quotient.range.rel_
{
	static public class _InsideX
		
	{
		static public bool Inside(Nonempty.En d, Nonempty.En r)
		{
			return  nilnul.num.quotient.border.comparer_.lower.Decider1.Singleton.ge( 
				
				d.lower, r.lower
			)
			&& 
			nilnul.num.quotient.border.comparer_.upper.Decider.Singleton.le(
				d.upper
				,
				r.upper	
			)
			;


			//throw new NotImplementedException();
		}


		

	}
}
