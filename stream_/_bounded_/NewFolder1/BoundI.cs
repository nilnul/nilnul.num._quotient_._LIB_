using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_._cauchy_
{
	/// <summary>
	/// the remaining stream will fall in this bound
	/// </summary>
	///
	[Obsolete()]
	public interface BoundI
	{
		/// <summary>
		/// the remaining stream will fall in this bound
		/// </summary>
		nilnul.num.quotient.Range1 bound { get; }
	}
}
