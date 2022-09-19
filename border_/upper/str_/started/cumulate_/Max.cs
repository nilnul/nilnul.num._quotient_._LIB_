using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.border_.upper.str_.started.cumulate_
{
	static public class _MaxX
	{


		static public Border2 Max(IEnumerable<Border2> bounds_nonEmpty)
		{
			if (bounds_nonEmpty.Count() == 1)
			{
				return bounds_nonEmpty.First();
			}
			return op_.binary_._MaxX.Max(bounds_nonEmpty.First(), Max(bounds_nonEmpty.Skip(1)));
		}

		static public Border2 Max(params Border2[] bounds)
		{
			return Max(bounds as IEnumerable<Border2>);
		}


	}
}
