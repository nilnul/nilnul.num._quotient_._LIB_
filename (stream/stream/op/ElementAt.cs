using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num.quotient.Q;
using q = nilnul.num.quotient;
using nilnul.num._num.bigint.be;
using System.Numerics;

namespace nilnul.num.quotient.stream.op
{
	public class ElementAt
	{

		static public Q Eval(StreamI2 stream, BigInteger n) {
			while (n-->0)
			{
				stream.next();
			}
			return stream.next();
		}


		static public Q Eval(StreamI2 stream, Natural.Asserted n) {
			while (n.val-->0)
			{
				stream.next();
			}
			return stream.next();
		}
	}
}
