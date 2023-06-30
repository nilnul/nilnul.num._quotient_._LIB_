using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using F = nilnul.num.Quotient_unsimplified;
using nilnul.num._num.bigint.be;
using nilnul._num.bigint.be_;
using nilnul._num.bigint.be;

namespace nilnul.num.quotient_
{
	/// <summary>
	/// simplified
	/// </summary>

	public class Rational
	//: F //composition is prefereed to inheritace
	:
		nilnul.num.QuotientI1
		,
		nilnul.num.quotient_.IRational
	{
		private F _fraction;
		public F fraction
		{
			get { return _fraction; }
			set
			{

				_fraction = quotient.op_.unary_. _SimplifyX.Op(value);

			}
		}

		public Rational(F fraction)
		{
			this.fraction = (fraction);
		}



		public Rational(int num, int denominator) : this(
			new F(num, denominator)
		)
		{

		}

		public Rational(int num, BigInteger denominator) : this(
			new F(num, denominator)
		)
		{

		}
		public Rational(BigInteger num, BigInteger denominator) : this(
			 F.OfDivide(num, denominator)
		)
		{

		}

		public Rational() : this(new F(0))
		{

		}

		public Rational(BigInteger num)
		: this(
			new F(num)
		 )
		{

		}

		public Rational(long value1, long value2)
			: this((BigInteger)value1, value2)
		{

		}

		public Rational(NumI current1, int v) : this(current1.toBigint(), v)
		{
		}

		public Rational(NumI1 current1, int v) : this(current1.toBigint(), v)
		{
		}

		public override string ToString()
		{

			return toTxt();
			//#if DEBUG
			//				return nilnul.num.quotient_.radix_.Dec1.FroQuotient(this,10).ToString();
			//#else
			//	return toTxt();



			//#endif

		}

		public string toTxt()
		{
			return $"{numerator}/{denominator1}";

		}

		public int signInInt { get { return numerator.Sign; } }



		public BigInteger numerator
		{
			get { return _fraction._numerator; }
		}

		public nilnul.num_.Positive1 denominator1
		{
			get
			{
				return new nilnul.num_.Positive1 (_fraction.denominator);
			}
		}
		public ref nilnul.num_.ref_.vowless_.Positive denominator
		{
			get
			{
				return ref (_fraction.denominator);
			}
		}


		static public implicit operator Rational(BigInteger x)
		{
			return new Rational(x);
		}

		static public implicit operator Rational(nilnul.Num1 x)
		{
			return new Rational(x);
		}



		static public explicit operator nilnul.num.Quotient_unsimplified(Rational x)
		{
			return new nilnul.num.Quotient_unsimplified(x.numerator, x.denominator1);
		}
		static public explicit operator Rational(nilnul.num.Quotient_unsimplified x)
		{
			return new Rational(x);
		}





		static public Rational OfUnital(int _denominator_positive)
		{
			return new Rational(1, _denominator_positive);
		}

		static public Rational OfUnital(BigInteger denominator_nonZero)
		{
			return new Rational(1, denominator_nonZero);
		}
	}
}
