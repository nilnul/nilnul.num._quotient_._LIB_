using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B = nilnul.num.quotient.Bound;


namespace nilnul.num.quotient.bound_.nilMarked_
{
	static public class _NatX
	{
		static public B _Create(nilnul.num.quotient.Border2 _positive) {
			return new B(  Border2.CreateZeroClose(), _positive);
		}

		static public B _CreateClose(nilnul.num.Quotient1 _positive) {
			return _Create(  Border2.CreateClose(_positive));
		}

		static public B _CreateOpen(nilnul.num.Quotient1 _positive) {
			return _Create(  Border2.CreateOpen(_positive));
		}

	}
}
