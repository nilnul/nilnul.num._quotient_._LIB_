using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed;
using F = nilnul.num._quotient.Fraction1;
using nilnul._num.bigint.be;

namespace nilnul.num._quotient.fraction.op
{
	public partial class Simplify
	{
		static public Fraction Eval(
			BigInteger numerator
			,
			num.natural.__bigint.be.Positive.Asserted denominator
		)
		{
			var gcd = nilnul.num.i.op.Gcd.Eval(numerator, denominator);
			return new Fraction(

				nilnul.num.i.op.Divide.Eval(numerator, gcd)
				,

				 nilnul.num.i.op.Divide.Eval(denominator, gcd)
			);

		}
		public static F Eval(BigInteger num, Positive.Asserted denominator)
		{
			return Eval(new F(num,denominator));

			throw new NotImplementedException();
		}




		static public Fraction Eval(Fraction x)
		{



			var gcd = nilnul.num.i.op.Gcd.Eval(x.numerator, x.denominator);
			return new Fraction(

				nilnul.num.i.op.Divide.Eval(x.numerator, gcd)
				,


				 nilnul.num.i.op.Divide.Eval(x.denominator, gcd)
			);

		}



		static public Fraction1 Eval(Fraction1 x)
		{
			var gcd = nilnul.num.integer.duo.op.Gcd.Eval(x.numerator, x.denominator);
			return new Fraction1(
				nilnul.num.integer.duo.op.Divide.Eval(x.numerator, gcd)
				,
				 nilnul.num.integer.duo.op.Divide.Eval(x.denominator, gcd)
			);

		}
	}
}
