using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num.quotient.Q;
using q = nilnul.num.quotient;

namespace nilnul.num.quotient.str.geometic
{
	public class HeadOne
	{
		static public Q Sum(Q rate,int count) {
			
			return rate==1? count:
				( 
					(
						1 - q.op.PowX.Do(rate, count ) 
					)
					/
					(1-rate)
				);
		}
	}
}
