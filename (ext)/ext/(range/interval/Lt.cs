using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.ext.border.duo.be;
using Interval1 = nilnul.num.quotient.ext.border.duo.be.Interval1.En;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.ext.interval
{

	/// <summary>
	/// not reflexive; asymmetric; transitive
	/// </summary>
	public class Lt
		:nilnul.OrdI<ext.border.duo.be.Interval1.En>
	{
		

		public bool contains(Interval1 d, Interval1 r)
		{
			return ext.comparer.Decider.Singleton.subProper(d.upper.mark, r.lower.mark) 
				
				|| 
				(
					ext.comparer.Decider.Singleton.Equals(d.upper.mark, r.lower.mark)

					&& 

					(
						!(d.upper.isClose && r.lower.isClose )
					)
				)
			;
			throw new NotImplementedException();
		}
	}
}
