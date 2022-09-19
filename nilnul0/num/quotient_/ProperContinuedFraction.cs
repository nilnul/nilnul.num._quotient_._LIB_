using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Fraction2 = nilnul.num.quotient.Fraction150626;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.form.continuedFraction
{
	public class ProperContinuedFraction
	{
		private nilnul.num.StrI _numStr;

		public nilnul.num.StrI numStr
		{
			get { return _numStr; }
			set { _numStr = value; }
		}

		static public Q _ToFraction(IEnumerable<BigInteger> denominators_notNull)
		{

			if (denominators_notNull.Count() == 0)
			{
				return new Q();

			}

			return Q.Inverse( Q.Add(

					denominators_notNull.First(),
					_ToFraction(denominators_notNull.Skip(1))
				));


		}
		static public Q _ToFraction(IEnumerable<num.natural.__bigint.be.Positive.Asserted> denominators_notNull)
		{

			if (denominators_notNull.Count() == 0)
			{
				return new Q();

			}

			return Q.Inverse( Q.Add(

					denominators_notNull.First().val,
					_ToFraction(denominators_notNull.Skip(1))
				));


		}
		static public Q _ToFraction(nilnul.num.type.StrI<BigInteger> denominators_notNull)
		{

			if (denominators_notNull.length == 0)
			{
				return new Q();

			}

			return Q.Inverse( Q.Add(

					denominators_notNull.elementAt(0),
					_ToFraction( nilnul.num.type.str.ExtensionMethods.Skip( denominators_notNull,1))
				));


		}

		static public Q _ToFraction(nilnul.num.type.StrI<num.natural.__bigint.be.Positive.Asserted> denominators_notNull)
		{

			if (denominators_notNull.length == 0)
			{
				return new Q();

			}

			return Q.Inverse( Q.Add(

					denominators_notNull.elementAt(0).val,
					_ToFraction( nilnul.num.type.str.ExtensionMethods.Skip( denominators_notNull,1))
				));


		}
	}
}
