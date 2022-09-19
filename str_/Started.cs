using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.str_
{
	public class Started
		: nilnul.str_.Started<Q1, StrI2>
	{
		public Started(Q1 seed, StrI2 tail) : base(seed, tail)
		{
		}
	}

	
}
