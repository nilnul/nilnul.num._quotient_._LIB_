using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;
using nilnul._num.bigint.be;
using nilnul.num_;

namespace nilnul.num
{
	/// <summary>
	/// guratee that denominator is positive. simplify process is expensive and unnecessary in some cases like comparison of equality.
	/// </summary>
	public class Quotient_unsimplified
		:
		quotient_.ByRefI
		,
		nilnul.num._quotient.dividing_.IFrac  /// when we requires the divisor to be nonnil, the allowed scope is a Holed range, which is not contiguous. To require it to be positive, we achieve the same with simpler means.
	{
		#region fields

		public BigInteger _numerator;

		public ref BigInteger numerator
		{
			get { return ref _numerator; }
			//set { _numerator = value; }
		}


		/// <summary>
		/// 
		/// </summary>
		/// use class (struct better) to achieve performance.

		public nilnul.num_.ref_.vowless_.Positive _denominator;	//=new num_.Positive1(1);

		#endregion

		public ref nilnul.num_.ref_.vowless_.Positive denominator
		{
			get
			{
				return ref  _denominator ;
			}

			
		}

		public int sign
		{
			get { return _numerator.Sign; }
		}
		public Quotient_unsimplified(
			in BigInteger num
			,
			in nilnul.num_.ref_.vowless_.Positive denominator
		)
		{
			this._numerator = num;
			this._denominator = denominator;


		}

		public Quotient_unsimplified(
			_quotient.Dividing dividing
		)
			:this(
				 dividing.denominator<0? ( -dividing.numerator,-dividing._denominator):(dividing.numerator,dividing._denominator)
			 )
		{

		}
		public Quotient_unsimplified(
			in BigInteger num
			,
			 nilnul.num_.ref_.vowless_.Positive denominator
		):this(
			in num
			,
			in denominator
		)
		{
		


		}

		public Quotient_unsimplified(
			 BigInteger num
			,
			in  nilnul.num_.ref_.vowless_.Positive denominator
		):this(
			in num
			,
			in denominator
		)
		{

		}

		public Quotient_unsimplified(
			 BigInteger num
			,
			  nilnul.num_.ref_.vowless_.Positive denominator
		):this(
			in num
			,
			in denominator
		)
		{

		}


		//public Unsimplified(
		//	in BigInteger num
		//	,
		//	in BigInteger denominator
		//):this(
		//	in num
		//	,
		//	 num_.ref_.vowless_.Positive.Of(ref denominator)
		//)
		//{

		//}
		public Quotient_unsimplified(
			in BigInteger num
			,
			ref BigInteger denominator
		):this(
			in num
			,
			 num_.ref_.vowless_.Positive.Of(ref denominator)
		)
		{

		}

		public Quotient_unsimplified(
			in BigInteger num
			,
			 BigInteger denominator
		):this(
			in num
			,
			ref denominator
		)
		{

		}

		public Quotient_unsimplified(
			 BigInteger num
			,
			ref BigInteger denominator
		):this(
			in num
			,
			 ref denominator
		)
		{

		}

		public Quotient_unsimplified(
			 BigInteger num
			,
			 BigInteger denominator
		):this(
			in num
			,
			  denominator
		)
		{

		}

		public Quotient_unsimplified((BigInteger, BigInteger) p)
			:this(
				  p.Item1
				 ,
				  p.Item2
			)
		{
		}
		public Quotient_unsimplified(in BigInteger numerator)
			: this(in numerator,   num_.ref_.vowless_.Positive.One)
		{ }

		public Quotient_unsimplified( BigInteger numerator)
			: this(in numerator)
		{ }


		public Quotient_unsimplified(long a) : this((BigInteger)a)
		{

		}
		public Quotient_unsimplified() : this( /*in*/ BigInteger.Zero)
		{

		}


		public Quotient_unsimplified inverse()
		{
			return ~(this);
		}


		public override string ToString()
		{
			return _numerator.ToString() + "/" + denominator.ToString();
		}


		static public Quotient_unsimplified Simplify(Quotient_unsimplified f)
		{
			var gcd = BigInteger.GreatestCommonDivisor(f._numerator, f._denominator.eeByRef);
			return new Quotient_unsimplified(f._numerator / gcd, f.denominator / gcd);

		}

		static public Quotient_unsimplified OfDivide(in BigInteger x, nilnul.num.integer.be_.NonZero.En y)
		{

			if (y.asserted > 0)
			{
				return new Quotient_unsimplified(in x,  nilnul.num_.ref_.vowless_.Positive.Of(y.asserted));
			}

			return new Quotient_unsimplified(-x,  nilnul.num_.ref_.vowless_.Positive.Of(-y.asserted));

		}
		static public Quotient_unsimplified OfDivide(  BigInteger x, nilnul.num.integer.be_.NonZero.En y)
		{

			return OfDivide(in x, y);

		}

		static public Quotient_unsimplified OfDivide(in BigInteger x,in BigInteger y)
		{

			if (y > 0)
			{
				return new Quotient_unsimplified(in x,  y);
			}

			return new Quotient_unsimplified(-x, -y);

		}
		static public Quotient_unsimplified OfDivide( BigInteger x,  BigInteger y)
		{

			

			return OfDivide(in x, in y);

		}

		static public Quotient_unsimplified OfDivide(num.natural.__bigint.be.Positive.Asserted x, BigInteger y)
		{

			if (y < 0)
			{
				return new Quotient_unsimplified(-x.val, -y);

			}
			return new Quotient_unsimplified(x.val,  y);

		}




	

		static public Quotient_unsimplified Multi(Quotient_unsimplified a, Quotient_unsimplified b)
		{
			return new Quotient_unsimplified(a._numerator * b._numerator, a.denominator.eeByRef * b.denominator.eeByRef);
		}
		static public Quotient_unsimplified Divide(Quotient_unsimplified a, Quotient_unsimplified b)
		{
			return Multi(a, Inverse(b));
		}

		static public implicit operator Quotient_unsimplified(BigInteger b)
		{
			return  new Quotient_unsimplified(
				in b
			);
		}
		static public implicit operator Quotient_unsimplified(int b)
		{
			return  new Quotient_unsimplified(
				 b
			);
		}

		static public Quotient_unsimplified operator +(Quotient_unsimplified a, Quotient_unsimplified b)
		{
			return  new Quotient_unsimplified(
				 a._numerator
				 *
				 b._denominator.eeByRef
				 +
				 b._numerator
				 *
				 a._denominator.eeByRef

				 ,

				 a._denominator.eeByRef * b._denominator.eeByRef
			);
		}

		static public Quotient_unsimplified operator +(
			Quotient_unsimplified a
			,
			int b
		)
		{
			return  new Quotient_unsimplified(
				 a._numerator
				 
				 +
				 b
				 *
				 a._denominator.eeByRef

				 ,

				 a._denominator.eeByRef
			);
		}

		static public Quotient_unsimplified operator -(
			Quotient_unsimplified a)
		{
			return new Quotient_unsimplified(
				-a._numerator 
				,
				 a._denominator
			);
		}


		static public Quotient_unsimplified operator -(
			Quotient_unsimplified a
			,
			Quotient_unsimplified b
			)
		{
			return a + -b;
		}

		static public Quotient_unsimplified operator -(
			Quotient_unsimplified a
			,
			int b
			)
		{
			return a + -b;
		}


		static public bool operator ==(Quotient_unsimplified x, Quotient_unsimplified y) {
			return (x - y).numerator == 0;
		}

		static public bool operator ==(Quotient_unsimplified x, int y) {
			return (x - y).numerator == 0;

		}
		static public bool operator !=(Quotient_unsimplified x, int y) {
			return ! (x == y);
		}
		static public bool operator !=(Quotient_unsimplified x, Quotient_unsimplified y) {
			return !(x == y);
		}

		static public bool operator >=(Quotient_unsimplified x, Quotient_unsimplified y) {
			return (x - y).numerator >= 0;
		}
		static public bool operator <=(Quotient_unsimplified x, Quotient_unsimplified y) {
			return (x - y).numerator <= 0;
		}

		static public bool operator >(Quotient_unsimplified x, Quotient_unsimplified y) {
			return (x - y).numerator > 0;
		}
		static public bool operator <(Quotient_unsimplified x, Quotient_unsimplified y) {
			return (x - y).numerator < 0;
		}

		static public Quotient_unsimplified operator *(Quotient_unsimplified a, Quotient_unsimplified b)
		{
			return new Quotient_unsimplified(a._numerator * b._numerator, a.denominator.eeByRef * b.denominator.eeByRef);
		}
		static public Quotient_unsimplified operator *(BigInteger a, Quotient_unsimplified b)
		{
			return new Quotient_unsimplified(a * b._numerator, b.denominator);
		}



		static public Quotient_unsimplified operator ~(Quotient_unsimplified a)
		{
			return  OfDivide(
				a._denominator, a._numerator
			);
		}
		static public Quotient_unsimplified operator /(Quotient_unsimplified a, Quotient_unsimplified b)
		{
			return a* ~b;
		}


		static public Quotient_unsimplified Inverse(Quotient_unsimplified a)
		{

			return ~a;


		}





		static public readonly Quotient_unsimplified Nil = new Quotient_unsimplified();

		static public readonly Quotient_unsimplified One = new Quotient_unsimplified(1);
		static public readonly Quotient_unsimplified Two = new Quotient_unsimplified(2);
		static public readonly Quotient_unsimplified Secondth = new Quotient_unsimplified(1,2);
		static public readonly Quotient_unsimplified Third = new Quotient_unsimplified(1,3);
		static public readonly Quotient_unsimplified Quarter = new Quotient_unsimplified(1,4);


		static public readonly Quotient_unsimplified NegOne = new Quotient_unsimplified(-1);
		static public readonly Quotient_unsimplified NegTwo = new Quotient_unsimplified(-2);
		static public readonly Quotient_unsimplified NegSecondth = new Quotient_unsimplified(-1,2);
		static public readonly Quotient_unsimplified NegThird = new Quotient_unsimplified(-1,3);
		static public readonly Quotient_unsimplified NegQuarter = new Quotient_unsimplified(-1,4);



		/// <summary>
		/// to parse a string as fraction
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public Quotient_unsimplified Parse(string s)
		{

			///first find the /
			///
			/// 
			string[] terms = s.Split(nilnul.num._quotient.dividing_.Frac.DividerSign);

			switch (terms.Length)
			{
				case 0:
					return  Quotient_unsimplified.Nil;
				case 1:
					return new Quotient_unsimplified(
						BigInteger.Parse(terms[0])
					);
				case 2:
					return new Quotient_unsimplified(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));

				default:
					throw new Exception(
						string.Format(
							"There are more than two terms sperated by {0}."
							,
							nilnul.num._quotient.dividing_.Frac.DividerSign
						)
					);
					break;
			}

		}

		static public bool TryParse(string s, out Quotient_unsimplified result)
		{

			try
			{
				result = Parse(s);
				return true;
			}
			catch (Exception)
			{
				result = default(Quotient_unsimplified);
				return false;

			}

		}



	}
}
