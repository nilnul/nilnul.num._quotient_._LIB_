using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.str_.started
{
	public static class _AvgX
	{
		static public Q1 _Avg(this IEnumerable<Q1> _started) {
			return str._SumX.Sum(_started) / _started.Count();
		}
	}
}
