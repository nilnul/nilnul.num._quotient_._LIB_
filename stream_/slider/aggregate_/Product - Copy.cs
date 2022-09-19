using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider.aggregate_
{
	static public class _ProductX
	{
		static public _prod.Ret Aggregate(this IEnumerable<SliderI2> streams) {
			return new _prod.Ret(streams);
		}

		static public _prod.Ret Aggregate(params SliderI2[] streams)
		{
			return new _prod.Ret(streams);
		}


	}
}
