using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num.quotient.stream_.convergent
{
	/// <summary>
	/// sign of limit. for sign of tail terms, see stream.tail.terms.be
	/// </summary>
	[MayPerpetual]
	static public  class _SignX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="real"></param>
		/// <returns></returns>
		[MayPerpetual]
		static public void Converge(ConvergentI real) {
			//var range = real.bound;

			while (real.bound.containsZero())
			{
				if ( real.bound.isSingleton)
				{
					return;// real;
				}
				real.squeeze( new Positive1.En( real.bound.span.toHalf()));
			}

			while (real.bound.lower.mark==0 || real.bound.upper.mark==0)
			{
				real.squeeze(new Positive1.En(real.bound.span.toHalf()));
			}
		}
		
		[MayPerpetual]
		static public int Sign(ConvergentI real) {

			Converge(real);
			return nilnul.num.quotient.Comparer1.lazy.sign(real.bound.lower.mark);

		}
	}
}