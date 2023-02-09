using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using B = nilnul.num.rational.Bound;//.border;
namespace nilnul.num.quotient.bound
{
	public partial class Lower
	{
		static public BigInteger Floor_infermum(B x)
		{


			return nilnul.num.rational.Rational_InheritFraction2.GetFloor(x.pinpoint);
		}
		static public BigInteger Ceil_infermum(B x)
		{

			if (Rational_InheritFraction2.IsInt(x.pinpoint))
			{
				if (x.eq)
				{
					return nilnul.num.rational.Rational_InheritFraction2.GetCeil(x.pinpoint);
				}
				else
				{
					return nilnul.num.rational.Rational_InheritFraction2.GetCeil(x.pinpoint)+1 ;

				}

			}

			else
			{
				return nilnul.num.rational.Rational_InheritFraction2.GetCeil(x.pinpoint);

			}


		}
	}
}
