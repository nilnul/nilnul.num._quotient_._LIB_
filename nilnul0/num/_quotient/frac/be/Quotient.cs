using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num._quotient.fraction.be
{

	public partial class Quotient:nilnul.BeI<Fraction>
	{
		static public bool Eval(Fraction fraction) {
			return nilnul.num.integer.duo.op.Gcd.Eval(fraction.numerator, fraction.denominator).val==1;

		}

		public bool be(Fraction obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}
		[Obsolete("op.Simplify.Ed")]
		public class Asserted
				:nilnul.be.Asserted<Fraction,Quotient>
			{
				public Asserted(Fraction f)
					:base(f)
				{

				}
			}


	


	}
}
