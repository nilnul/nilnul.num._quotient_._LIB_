using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.set_.seeded.op_
{
	public  class Max
	{

		static public Q1 Eval(Q1 a,Q1 b) {
			return a < b ? b : a;
		}

		static public Q1 _Eval(IEnumerable<Q1> _x_seeded) {

			if (_x_seeded.Count()==1)
			{
				return _x_seeded.First();

			}
			return Eval(
				_x_seeded.First(), 
				_Eval(_x_seeded.Skip(1))
			);
		}
	


	}
}
