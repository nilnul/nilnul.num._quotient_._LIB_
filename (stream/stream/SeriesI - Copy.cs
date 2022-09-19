using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream
{
	/// <summary>
	/// the start element of the series is 0. the runner-up element of the series is the start element of the stream
	/// </summary>
	public interface SeriesI1
		: nilnul.num.quotient.stream._series_.AccumulatedI
		,
		nilnul.num.quotient.stream._series_.MoveNextI
	{

	}
}
