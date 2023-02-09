using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using B = nilnul.num.rational.Bound;
namespace nilnul.num.quotient.bound
{
	public partial class Upper
	{
		static public BigInteger Ceil_supremum(B x)
		{


			return nilnul.num.rational.Rational_InheritFraction2.GetCeil(x.pinpoint);
		}
		static public BigInteger Floor_supremum(B x)
		{

			if (Rational_InheritFraction2.IsInt(x.pinpoint))
			{
				if (x.eq)
				{
					return nilnul.num.rational.Rational_InheritFraction2.GetFloor(x.pinpoint);
				}
				else
				{
					return nilnul.num.rational.Rational_InheritFraction2.GetFloor(x.pinpoint)-1 ;

				}

			}

			else
			{
				return nilnul.num.rational.Rational_InheritFraction2.GetFloor(x.pinpoint);

			}


		}
	}
}
