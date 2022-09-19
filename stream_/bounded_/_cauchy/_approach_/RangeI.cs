using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_._cauchy._approach_
{
	/// <summary>
	/// squeeze from an approach to appraoch to a limit.The limit can be the border point, that is outside the bound if the bound is open. So this should be always taken as a closed interval.
	/// </summary>
	public interface RangeI
	{
		nilnul.num.quotient.Range1 range { get; }
	}
}
