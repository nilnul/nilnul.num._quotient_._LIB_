using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.str_
{
	

	static public class StartedX
	{
		static public Q1 Min(IEnumerable<Q1> quotients) {
			return quotients.Aggregate( nilnul.num.quotient.CoX.Min);
		}
		static public Q1 Min(params Q1[] quotients) {
			return Min((quotients.AsEnumerable()));
		}


		static public Q1 Max(IEnumerable<Q1> quotients) {
			return quotients.Aggregate( nilnul.num.quotient.CoX.Max);
		}

		static public Q1 Max(params Q1[] quotients) {
			return Max((quotients.AsEnumerable()));
		}

	}
}
