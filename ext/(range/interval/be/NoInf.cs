using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.quotient.ext.border.duo.be;
using R = nilnul.num.rational.Rational_InheritFraction2;



namespace nilnul.num.quotient.ext.interval.bek
{
	public class NoInf
			:
		bit.BeI<ext.border.duo.be.Interval1.En>

	{
		static public bool Eval(ext.border.duo.be.Interval1.En obj)
		{
			//return nilnul.order.ext.comparer.bounded.Restricted<R,rational.Comparer>.Be(
			//	obj
			//);

			return obj.notContains(ext_.Inf.Singleton) && obj.notContains(ext_.NegInf.Singleton);

			//return _restricted.Lower.IsRestricted(obj.lower) && _restricted.Upper.IsRestricted(obj.upper)  && ext.comparer.bounded.be.NonEmpty.Eval(obj);


		}

		public bool be(Interval1.En obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}

		public class En : nilnul.bit.be.Asserted<ext.border.duo.be.Interval1.En, NoInf>
		{
			public En(ext.border.duo.be.Interval1.En val)
				: base(val)
			{

			}

			
		}






	}
}
