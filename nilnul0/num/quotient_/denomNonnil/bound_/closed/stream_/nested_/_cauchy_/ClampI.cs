using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil.bound_.closed.stream_.nested_._cauchy_
{

	/// <summary>
	/// moveNext() multiple times till the bound is small enough;
	/// </summary>
	/// <remarks>
	/// "C" is also the initial of "Cauchy"
	/// </remarks>
	/// alias:
	///		clamp
	///		clasp
	///		squeeze
	///		converge
	public interface ClampI
	{
		/// <summary>
		/// implementations are free to make the boundDiameterLe, elDistanceLt, or boundDiameterLt, because we can, from the bound, know whether the boundDiameter le or lt, as well as the elDistance le or lt.
		/// we suggest to implement this as diameterLe, which is easy, and which is also collateral with closed bound
		/// </summary>
		/// <param name="diameter">
		/// </param>
		/// <remarks>
		/// </remarks>
		void clamp(nilnul.num.quotient_.denomNonnil_.Positive diameter);
	}



}
