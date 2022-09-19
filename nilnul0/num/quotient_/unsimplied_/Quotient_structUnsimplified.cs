using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;
using nilnul._num.bigint.be;
using nilnul.num_;

namespace nilnul.num.quotient_.unsimplified_
{
	/// <summary>
	/// guratee that denominator is positive.
	/// </summary>
	/// making this struct to try to achieve performance.
	public struct StrucUnsimplified
		:QuotientI1
		,
		nilnul.num._quotient.dividing_.IFrac  /// when we requires the divisor to be nonnil, the allowed scope is a Holed range, which is not contiguous. To require it to be positive, we achieve the same with simpler means.
	{
		#region fields

		public BigInteger _numerator;

		public BigInteger numerator
		{
			get { return _numerator; }
			set { _numerator = value; }
		}


		/// <summary>
		/// 
		/// </summary>
		/// use class (struct better) to achieve performance.

		public nilnul.num_.Positive_byRef _denominator;	//=new num_.Positive1(1);

		#endregion

		public ref nilnul.num_.Positive_byRef denominator1
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
		public StrucUnsimplified(
			BigInteger num
			,
			nilnul.num_.Positive_byRef denominator
		)
		{
			this._numerator = num;
			this._denominator = denominator;


		}
		public StrucUnsimplified(
			BigInteger num
			,
			BigInteger denominator
		):this(
			num
			,
			new num_.Positive_byRef(denominator)
		)
		{
			


		}

		public StrucUnsimplified(BigInteger numerator)
			: this(numerator, new num_.Positive1(1))
		{ }

		



	

		public StrucUnsimplified inverse()
		{
			return Inverse(this);
		}





		public override string ToString()
		{
			return _numerator.ToString() + "/" + denominator1.ToString();
		}





		static public StrucUnsimplified Simplify(StrucUnsimplified f)
		{
			var gcd = nilnul.num.i.op.Gcd.Eval(f._numerator, f.denominator1);
			return new StrucUnsimplified(f._numerator / gcd, f.denominator1 / gcd);




		}

		static public StrucUnsimplified CreateByDivide(BigInteger x, nilnul.num.integer.be_.NonZero.En y)
		{

			if (y.asserted > 0)
			{
				return new StrucUnsimplified(x, new Positive_byRef(y.asserted));
			}

			return new StrucUnsimplified(-x, new Positive_byRef(-y.asserted));

		}

		static public StrucUnsimplified CreateByDivide(BigInteger x, BigInteger y)
		{

			if (y > 0)
			{
				return new StrucUnsimplified(x, new num_.Positive1(y));
			}

			return new StrucUnsimplified(-x, new num_.Positive1(-y));

		}


		static public StrucUnsimplified CreateQuarter()
		{
			return new StrucUnsimplified(1, 4);
		}

		static public StrucUnsimplified Divide(BigInteger x, BigInteger y)
		{

			if (y < 0)
			{
				return new StrucUnsimplified(-x, -y);

			}
			return new StrucUnsimplified(x, y);

		}

		static public StrucUnsimplified Multi(StrucUnsimplified a, StrucUnsimplified b)
		{
			return new StrucUnsimplified(a._numerator * b._numerator, a.denominator1.eeByRef * b.denominator1.eeByRef);
		}
		static public StrucUnsimplified Divide(StrucUnsimplified a, StrucUnsimplified b)
		{
			return Multi(a, Inverse(b));
		}

		static public StrucUnsimplified operator +(StrucUnsimplified a, StrucUnsimplified b)
		{
			return  StrucUnsimplified.CreateByDivide(
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

		static public StrucUnsimplified operator +(
			StrucUnsimplified a
			,
			int b
		)
		{
			return  StrucUnsimplified.CreateByDivide(
				 a._numerator
				 
				 +
				 b
				 *
				 a._denominator.eeByRef

				 ,

				 a._denominator.eeByRef
			);
		}

		static public StrucUnsimplified operator -(
			StrucUnsimplified a)
		{
			return new StrucUnsimplified(
				-a._numerator 
				,
				 a._denominator
			);
		}


		static public StrucUnsimplified operator -(
			StrucUnsimplified a
			,
			StrucUnsimplified b
			)
		{
			return a + -b;
		}

		static public StrucUnsimplified operator -(
			StrucUnsimplified a
			,
			int b
			)
		{
			return a + -b;
		}


		static public bool operator ==(StrucUnsimplified x, StrucUnsimplified y) {
			return (x - y).numerator == 0;
		}

		static public bool operator ==(StrucUnsimplified x, int y) {
			return (x - y).numerator == 0;

			return x == new StrucUnsimplified(y);
		}
		static public bool operator !=(StrucUnsimplified x, int y) {
			return ! (x == y);
		}
		static public bool operator !=(StrucUnsimplified x, StrucUnsimplified y) {
			return !(x == y);
		}



		static public StrucUnsimplified operator *(StrucUnsimplified a, StrucUnsimplified b)
		{
			return new StrucUnsimplified(a._numerator * b._numerator, a.denominator1.eeByRef * b.denominator1.eeByRef);
		}
		static public StrucUnsimplified operator *(BigInteger a, StrucUnsimplified b)
		{
			return new StrucUnsimplified(a * b._numerator, b.denominator1);
		}



		static public StrucUnsimplified operator ~(StrucUnsimplified a)
		{
			return  StrucUnsimplified.CreateByDivide(
				a._denominator.asInteger, a._numerator
			);
		}
		static public StrucUnsimplified operator /(StrucUnsimplified a, StrucUnsimplified b)
		{
			return a* ~b;
		}

		static public StrucUnsimplified Divide(num.natural.__bigint.be.Positive.Asserted x, BigInteger y)
		{

			if (y < 0)
			{
				return new StrucUnsimplified(-x.val, -y);

			}
			return new StrucUnsimplified(x.val, y);

		}

		static public StrucUnsimplified Inverse(StrucUnsimplified a)
		{

			return Divide(a.denominator1, a._numerator);


		}



		static public StrucUnsimplified ToFraction2(long a)
		{
			return new StrucUnsimplified(a, 1);
		}






		/// <summary>
		/// to parse a string as fraction
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public StrucUnsimplified Parse(string s)
		{

			///first find the /
			///
			/// 
			string[] terms = s.Split(nilnul.num._quotient.dividing_.Frac.DividerSign);

			switch (terms.Length)
			{
				case 0:
					return new StrucUnsimplified();
				case 1:
					return new StrucUnsimplified(
						BigInteger.Parse(terms[0])
					);
				case 2:
					return new StrucUnsimplified(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));

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

		static public bool TryParse(string s, out StrucUnsimplified result)
		{

			try
			{
				result = Parse(s);
				return true;
			}
			catch (Exception)
			{
				result = default(StrucUnsimplified);
				return false;

				throw;
			}

		}



	}
}
