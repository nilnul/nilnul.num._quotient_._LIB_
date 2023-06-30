using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.interval.to
{
	static public class ToX
	{
		static public nilnul.num.rational.bound.pair.be.Nonempty.Asserted ToRationalAsserted(this Interval i) {
			return i.toBasedNoEmpty();
		}

	}
}
