using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.str.to_._sum
{
	public static class X
	{
		static public Q1 Sum( this IEnumerable<Q1> str) {
			var r = Q1.CreateZero();

			foreach (var item in str)
			{
				r += item;
			}
			return r;

		}
	}
}
