using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.set_.sed
{
	static public  class _MinX
	{

		static public Q1 Min(Q1 a, Q1 b)
		{
			return a <= b ? a : b;
		}

		static public Q1 _Min(IEnumerable<Q1> _x_seeded)
		{

			if (_x_seeded.Count() == 1)
			{
				return _x_seeded.First();

			}
			return Min(
				_x_seeded.First(),
				_Min(_x_seeded.Skip(1))
			);
		}


	}
}
