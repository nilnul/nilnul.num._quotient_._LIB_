using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.quotient.fraction._be
{
	public partial class Quotient
	{
		static public bool Eval(Fraction150626 fraction) {
			return nilnul.num.integer.duo.op.Gcd.Eval(fraction.numerator, fraction.denominator).val==1;

		}

		public class Be :nilnul.bit.Be<Fraction150626>
		{
			public Be()
				:base(Eval)
			{

			}

			public class Asserted
				:nilnul.bit.be.Asserted<Fraction150626,Be>
			{
				public Asserted(Fraction150626 f)
					:base(f)
				{

				}
			}


		}


	}
}
