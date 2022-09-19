using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.border_.lower.str_.started.cumulate_
{
	static public class _MinX
	{



		static public Border2 Min(IEnumerable<Border2> bounds_nonEmpty)
		{
			if (bounds_nonEmpty.Count() == 1)
			{
				return bounds_nonEmpty.First();
			}
			return op_.binary_._MinX.Min(bounds_nonEmpty.First(), Min(bounds_nonEmpty.Skip(1)));



		}

		static public Border2 Min(params Border2[] bounds)
		{
			return Min(bounds as IEnumerable<Border2>);
		}

	
	}
}
