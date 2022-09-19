using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.fro_
{
	public class UnitFrac
	{
		static public  Q1 Eval(BigInteger x) {
			return new Q1(1, x);
		}
	}
}
