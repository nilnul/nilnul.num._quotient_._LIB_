using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using S = nilnul.num.quotient.stream_.SliderI1;

namespace nilnul.num.quotient.stream_.slider.aggregate_
{
	static public class _ProdX
	{
		static public _prod.Ret Aggregate(this IEnumerable<S> streams) {
			return new _prod.Ret(streams);
		}

		static public _prod.Ret Aggregate(params S[] streams)
		{
			return new _prod.Ret(streams);
		}


	}
}
