using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using System.Numerics;

namespace nilnul.num.quotient.stream_
{
	public class Bernoulli : StreamI3
	{
		BigInteger _index = 0;
		 
		[PartialImplementation]
		public Q1 next()
		{
			return nilnul.num.quotient.str_._BernoulliStatic._Eval(
				(int)
				(_index++)	///this is where the beyond range exception will emerge
				);
		//	throw new NotImplementedException();
		}
	}
}
