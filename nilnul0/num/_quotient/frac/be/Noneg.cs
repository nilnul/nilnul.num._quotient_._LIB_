using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using F = nilnul.num._quotient.Fraction1;

namespace nilnul.num._quotient.fraction.be
{

	public partial class Noneg : nilnul.BeI<Fraction1>
	{
		static public bool Eval(Fraction1 fraction)
		{
			return nilnul.num.integer.be.Natural.Eval(fraction.numerator);

		}

		public bool be(Fraction1 obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}
		public class Asserted
				: nilnul.be.Asserted<F, Noneg>
		{
			public Asserted(F f)
				: base(f)
			{

			}

			public Asserted(int num, int den)
				:base(new F(num,den))
			{

			}
		}





	}
}
