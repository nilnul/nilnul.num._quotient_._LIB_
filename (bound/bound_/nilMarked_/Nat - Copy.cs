using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.range_.nilMarked_
{
	static public class _NatX
	{
		static public Range1 _Create(nilnul.num.quotient.Border2 _positive) {
			return new Range1(  Border2.CreateZeroClose(), _positive);
		}

		static public Range1 _CreateClose(nilnul.num.Quotient1 _positive) {
			return _Create(  Border2.CreateClose(_positive));
		}

		static public Range1 _CreateOpen(nilnul.num.Quotient1 _positive) {
			return _Create(  Border2.CreateOpen(_positive));
		}

	}
}
