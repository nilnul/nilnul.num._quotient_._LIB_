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

namespace nilnul.num.quotient.op_.unary_.simplify
{



	public class Ed

	//: F //composition is prefereed to inheritace
	{

		private F _fraction;

		

		public F fraction
		{
			get { return _fraction; }
			set
			{

				_fraction = _SimplifyX.Op(value);

			}
		}

		public Ed(F fraction)
		{
			this.fraction = (fraction);
		}

		

		public Ed(int num, int denominator) : this(
			new F(num, denominator)
		)
		{

		}

		public Ed(int num, BigInteger denominator) : this(
			new F(num, denominator)
		)
		{

		}
		public Ed(BigInteger num, BigInteger denominator) : this(
			 F.OfDivide(num, denominator)
		)
		{

		}

		public Ed() : this(new F(0))
		{

		}

		public Ed(BigInteger num)
		: this(
			new F(num)
		 )
		{

		}

		public Ed(long value1, long value2)
			: this((BigInteger)value1, value2)
		{

		}

		public Ed(NumI current1, int v):this( current1.toBigint(),v)
		{
		}

		public Ed(NumI1 current1, int v):this( current1.toBigint(),v)
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
			return $"{numerator}/{denominator}";

		}

		public int signInInt { get { return numerator.Sign; } }



		public BigInteger numerator
		{
			get { return _fraction._numerator; }
		}

		public ref num_.ref_.vowless_.Positive denominator
		{
			get {
				return ref( _fraction.denominator);
			}
		}

	

		static public implicit operator Ed(BigInteger x)
		{
			return new Ed(x);
		}

		static public implicit operator Ed(nilnul.Num1 x)
		{
			return new Ed(x);
		}

	

		static public explicit operator nilnul.num.Quotient_unsimplified(Ed x)
		{
			return new nilnul.num.Quotient_unsimplified(x.numerator, x.denominator);
		}
		static public explicit operator Ed(nilnul.num.Quotient_unsimplified x)
		{
			return new Ed(x);
		}


	


		static public Ed OfUnital(int _denominator_positive)
		{
			return new Ed(1, _denominator_positive);
		}

		static public Ed OfUnital(BigInteger denominator_nonZero)
		{
			return new Ed(1, denominator_nonZero);
		}
	}
}
