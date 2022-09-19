using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.quotient.ext.border.duo.be;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;



namespace nilnul.num.quotient.ext.interval.be
{
	public class Bound
			:
		bit.BeI<ext.border.duo.be.Interval1.En>

	{
		static public bool Eval(ext.border.duo.be.Interval1.En obj)
		{
			//return nilnul.order.ext.comparer.bounded.Restricted<R,rational.Comparer>.Be(
			//	obj
			//);

			return (obj.lower.mark is ext_.Bare) && (obj.upper.mark is ext_.Bare);

			//return _restricted.Lower.IsRestricted(obj.lower) && _restricted.Upper.IsRestricted(obj.upper)  && ext.comparer.bounded.be.NonEmpty.Eval(obj);


		}

		public bool be(Interval1.En obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}

		public class En : nilnul.bit.be.Asserted<ext.border.duo.be.Interval1.En, Bound>
		{
			

			public En(ext.border.duo.be.Interval1.En val)
				: base(val)
			{

			}

			public En(Border1 border11, Border1 border12)
				:this(
					new ext.border.duo.be.Interval1.En(border11,border12)	 
					 )
			{
				
			}

			public En(quotient.Border1 border11, quotient.Border1 border12)
				:this(
					(ext.Border1)border11
					 ,
					(ext.Border1)border12	 
				 )
			{
				
			}

			public quotient.Border1 lower {
				get {
					return new quotient.Border1 (
						val.lower.openFalseCloseTrue,
						((ext_.Bare) (val.lower.mark) ).q);
				}
			}
			public quotient.Border1 upper {
				get {
					return new quotient.Border1(val.upper.openFalseCloseTrue,
						
						((ext_.Bare) (val.upper.mark) ).q
						);
				}
			}



			static public En Multi(
			En x
			,
			En y
		)
			{

				var lowerLower = x.lower* y.lower;

				var lowerUpper = x.lower * y.upper;

				var upperLower = x.upper * y.lower;
				var upperUpper = x.upper * y.upper;

				var r = new En(
					
					quotient.border.comparer_.Lower.Min(lowerLower, lowerUpper, upperLower, upperUpper)
					,
					quotient.border.comparer_.Upper.Max(lowerLower, lowerUpper, upperLower, upperUpper)

				);

				return r;


				throw new NotImplementedException();
			}
		}






	}
}
