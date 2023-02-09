using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.bound_.closed.stream_.nested_._cauchy_
{

	/// <summary>
	/// </summary>
	/// <remarks>
	/// "C" is also the initial of "Cauchy"
	/// </remarks>
	///
	[Obsolete()]
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
		///
		[Obsolete(nameof(ClampI1) + ". signature is the same but the method name is renamed to clamp")]
		void squeeze(nilnul.num.quotient_.Positive1 diameter);
	}



}
