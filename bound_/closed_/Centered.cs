using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul._num.bigint.be_;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.bound_.closed_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _CenteredX
	{







		static public num.quotient.bound_.Closed _Create_orderIfNeed(Q1 center, Q1 _radius_nonNeg)
		{
			return  Closed.Create_orderIfNecessary(center -_radius_nonNeg, center +_radius_nonNeg);
		}
		

		static public num.quotient.bound_.Closed CreateClosed_ofRadiusMayNeg(Q1 _radius_nonNeg)
		{
			return  _Create_orderIfNeed(0, _radius_nonNeg);
		}



		static public num.quotient.bound_.Closed CreateClosed(Q1 center, quotient_.Positive1 _radius_nonNeg)
		{
			return  new bound_.Closed(center -_radius_nonNeg, center +_radius_nonNeg);
		}



		static public num.quotient.bound_.Closed _CreateClosed_assumeRadiusNoneg(Q1 center, Q1 _radius_nonNeg)
		{
			return  new Closed (center -_radius_nonNeg, center +_radius_nonNeg);
		}


		



		static public num.quotient.bound_.Closed _CreateClosed_ofRadiusAssumeNonneg( Q1 _radius_nonNeg)
		{
			return  _CreateClosed_assumeRadiusNoneg(0, _radius_nonNeg);
		}
		

	}



}
