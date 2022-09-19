using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using System.Numerics;

using nilnul.num.quotient.all;

namespace nilnul.num.quotient.stream_
{
	/// <summary>
	/// (1+1/(n+1)) ^(n+1). This converges to e.
	/// </summary>
	public class E
		: nilnul.num.quotient.StreamI3
	{


		BigInteger _index = 0;

	


		public Simplify.Ed1 next()
		{
			_index++;
			return nilnul.num.quotient.all.X.Poly(
				(1+ nilnul.num.quotient.all.X.Inverse (  _index)), (_index) 
			);
		}
	}
}
