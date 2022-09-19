using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.stream.op
{
	static public class _PartialSum_static
	{
		static public Q Eval(StreamI2 stream, int count) {
			var r = Q.CreateZero();

			while (count-->0)
			{
				r += stream.next();

			}
			return r;

		}

		static public Q Eval(StreamI2 stream, BigInteger count) {
			var r = Q.CreateZero();

			while (count-->0)
			{
				r += stream.next();

			}
			return r;

		}

	}
}
