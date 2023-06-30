using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil.stream_.multi.series_.cauchy
{
	static public class _LimitX
	{
		static public DenomNonnil _Limit_1openUnialAsRate(DenomNonnil head, DenomNonnil rate) {
			return head / (1-rate);
		}
		static public DenomNonnil _Limit_1openUnialAsRate( DenomNonnil rate) {
			return 1 / (1-rate);
		}


	}
}
