using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._quotient.fraction
{
	[Obsolete()]
	public class Simplify
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

		static public Fraction Eval(Fraction x)
		{



			var gcd = nilnul.num.i.op.Gcd.Eval(x.numerator, x.denominator);
			return new Fraction(

				nilnul.num.i.op.Divide.Eval(x.numerator, gcd)
				,


				 nilnul.num.i.op.Divide.Eval(x.denominator, gcd)
			);

		}

	}

	[Obsolete()]

		public class Simplified

		//: Fraction //composition is prefereed to inheritace
		{

			private Fraction _fraction;

			public Fraction fraction
			{
				get { return _fraction; }
				set {

					_fraction =Simplify.Eval(fraction);

				}
			}

			public Simplified(Fraction fraction)
			{
				_fraction = Simplify.Eval(fraction);
			}

			public Simplified(

				BigInteger num
				,
				num.natural.__bigint.be.Positive.Asserted denominator
			)
			{
				_fraction = Simplify.Eval(num, denominator);
			}






		}






}
