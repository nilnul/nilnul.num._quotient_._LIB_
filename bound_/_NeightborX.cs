using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul._num.bigint.be_;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.bound_
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="nameof(Neighbor)"/>
	static public class _CenteredX
	{



		public static num.quotient.Bound CreateSingleton(Q1 _quotient)
		{
			return Bound.CreateClose(_quotient, _quotient);
		}


		public static num.quotient.Bound CreateZero()
		{
			return CreateSingleton(0);
		}




		static public num.quotient.Bound _CreateClose_orderIfNeed(Q1 center, Q1 _radius_nonNeg)
		{
			return  Bound.CreateClose_orderIfNecessary(center -_radius_nonNeg, center +_radius_nonNeg);
		}
		static public num.quotient.Bound _CreateClopen_orderIfNeed(Q1 center, Q1 _radius_nonNeg)
		{
			return  Bound.CreateClopen_orderIfNecessary(center -_radius_nonNeg, center +_radius_nonNeg);
		}

		static public num.quotient.Bound _CreateOpen_orderIfNeed(Q1 center, Q1 _radius_nonNeg)
		{
			return  Bound.CreateOpen_orderIfNecessary(center -_radius_nonNeg, center +_radius_nonNeg);
		}

		static public num.quotient.Bound _CreateOpenClose_orderIfNeed(Q1 center, Q1 _radius_nonNeg)
		{
			return  Bound.CreateOpenClose_orderIfNecessary(center -_radius_nonNeg, center +_radius_nonNeg);
		}

		static public num.quotient.Bound CreateClose_ofRadius(Q1 _radius_nonNeg)
		{
			return  _CreateClose_orderIfNeed(0, _radius_nonNeg);
		}



		static public num.quotient.Bound CreateClose(Q1 center, quotient_.Positive1 _radius_nonNeg)
		{
			return  Bound.CreateClose(center -_radius_nonNeg, center +_radius_nonNeg);
		}



		static public num.quotient.Bound _CreateClose_assumeRadiusNoneg(Q1 center, Q1 _radius_nonNeg)
		{
			return  Bound.CreateClose(center -_radius_nonNeg, center +_radius_nonNeg);
		}


		static public num.quotient.Bound _CreateClopen_assumeRadiusNoneg(Q1 center, Q1 _radius_nonNeg)
		{
			return  Bound.CreateClopen(center -_radius_nonNeg, center +_radius_nonNeg);
		}
		static public num.quotient.Bound _CreateOpen_assumeRadiusNoneg(Q1 center, Q1 _radius_nonNeg)
		{
			return  Bound.CreateOpen(center -_radius_nonNeg, center +_radius_nonNeg);
		}

		static public num.quotient.Bound _CreateOpenClose_assumeRadiusNoneg(Q1 center, Q1 _radius_nonNeg)
		{
			return  Bound.CreateOpenClose(center -_radius_nonNeg, center +_radius_nonNeg);
		}




		static public num.quotient.Bound _CreateClose_ofRadiusAssumeNonneg( Q1 _radius_nonNeg)
		{
			return  _CreateClose_assumeRadiusNoneg(0, _radius_nonNeg);
		}
		static public num.quotient.Bound _CreateClopen_ofRadiusAssumeNonneg( Q1 _radius_nonNeg)
		{
			return  _CreateClopen_assumeRadiusNoneg(0, _radius_nonNeg);
		}

		static public num.quotient.Bound _CreateOpen_ofRadiusAssumeNonneg( Q1 _radius_nonNeg)
		{
			return  _CreateOpen_assumeRadiusNoneg(0, _radius_nonNeg);
		}

		static public num.quotient.Bound _CreateOpenClose_ofRadiusAssumeNonneg( Q1 _radius_nonNeg)
		{
			return  _CreateOpenClose_assumeRadiusNoneg(0, _radius_nonNeg);
		}

	}



}
