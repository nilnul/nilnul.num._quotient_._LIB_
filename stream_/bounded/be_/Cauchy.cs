using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.bounded.be_
{
	/// <summary>
	/// convergent:
	/// given arbitrary positive Q <var>q</var>, we can find N <var>n</var> such that  for any <var>i, j</var>, where i, j >N,  (|the element[i] - element[j]|) &le;q. 
	/// </summary>
	///<remarks>
	/// if we change
	///		> in (i,j>N)    to  >=
	///		and/or
	///		the &le; to &lt,
	///	the definition is the same
	///	
	/// </remarks>
	public interface CauchyI: nilnul.num.quotient.stream_.bounded.BeI
	{
		
		

	}
	/// <summary>
	/// </summary>
	///
	public abstract class CauchyA : CauchyI
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		/// by inpsecting the function of n->q of the term of the stream.

		public abstract bool be(BoundedI obj);		

	

	}


}
