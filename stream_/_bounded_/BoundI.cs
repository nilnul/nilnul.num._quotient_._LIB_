using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_._bounded_
{
	/// <summary>
	/// the remaining stream will fall in this bound
	/// </summary>
	public interface BoundI
	{
		/// <summary>
		/// the remaining stream will fall in this bound, which can be open or close or half close, but is generally closed. if the stream fall in this bound, it will fall a closed bound ,formed by using the bound to merge border.
		/// the bound can be open or close. (in real number, we will see that even the bound is open, the limit can be on the border, thus fall in the mergedBorder bound, which is closed.)
		/// we leave the bound the possibility of being not closed, as the stream elements may take part in cases other than defining real number.
		///		for example we define a inversed stream on (1/n) which will aprroach infinity.
		/// </summary>
		nilnul.num.quotient.Bound bound { get; }
	}
}
