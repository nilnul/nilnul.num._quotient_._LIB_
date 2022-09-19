using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.range_
{
	static public class _SingletonX
	{
		static public Range1 Create(nilnul.num.Quotient1 q ) {
			return _CloseX.Range(q,q);
		}
	}
}
