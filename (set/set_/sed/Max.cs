using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.set_.sed
{
	static public  class _MaxX
	{

		static public Q1 Max(Q1 a,Q1 b) {
			return a >= b ? a : b;
		}

		static public Q1 _Max(IEnumerable<Q1> _x_seeded) {

			if (_x_seeded.Count()==1)
			{
				return _x_seeded.First();

			}
			return Max(
				_x_seeded.First(), 
				_Max(_x_seeded.Skip(1))
			);
		}
	


	}
}
