using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;
using nilnul._num.bigint.be;
using nilnul.num_;
using System.Runtime.CompilerServices;
using nilnul.num.quotient;
using nilnul.num.quotient_.denomNonnil;

namespace nilnul.num.quotient_
{
	/// <summary>
	/// guratee that denominator is positive. simplify process is expensive and unnecessary in some cases like comparison of equality.
	/// </summary>
	public class DenomNonnil
		:

		num.IQuotient
		,
		_quotient_.numerator_.ByRefI
		,
		_quotient_.denominator_.NonnilByRefI
		,
		_quotient.IDividing
		, DenomNonnilI
	//,
	//nilnul.num._quotient.dividing_.IFrac  /// when we requires the divisor to be nonnil, the allowed scope is a Holed range, which is not contiguous. To require it to be positive, we achieve the same with simpler means.
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
		/// throw exception eagerly such as to break from a possible long chain reaction.

		public nilnul.num.integer_.Nonnil_vowlessRef _denominator;  //=new num_.Positive1(1);

		#endregion

		public ref nilnul.num.integer_.Nonnil_vowlessRef denominator
		{
			get
			{
				return ref _denominator;
			}


		}

		public int sign
		{
			get { return _numerator.Sign; }
		}
		public DenomNonnil(
			in BigInteger num
			,
			in nilnul.num.integer_.Nonnil_vowlessRef denominator
		)
		{
			this._numerator = num;
			this._denominator = denominator;


		}


		public DenomNonnil(
			in BigInteger num
			,
			ref BigInteger denominator
		) : this(
			in num
			,
			 nilnul.num.integer_.Nonnil_vowlessRef.Of(ref denominator)
		)
		{

		}

		public DenomNonnil(
			in BigInteger num
			,
			 BigInteger denominator
		) : this(
			in num
			,
			ref denominator
		)
		{

		}

		public DenomNonnil(
			 BigInteger num
			,
			ref BigInteger denominator
		) : this(
			in num
			,
			 ref denominator
		)
		{

		}

		public DenomNonnil(
			 BigInteger num
			,
			 BigInteger denominator
		) : this(
			in num
			,
			 ref denominator
		)
		{

		}

		public DenomNonnil((BigInteger, BigInteger) p)
			: this(
				  p.Item1
				 ,
				  p.Item2
			)
		{
		}

		public DenomNonnil(
			_quotient.Dividing dividing
		)
			: this(
				 dividing.numerator, dividing._denominator
			 )
		{

		}
		public DenomNonnil(
			in BigInteger num
			,
			 nilnul.num_.ref_.vowless_.Positive denominator
		) : this(
			in num
			,
			 denominator.eeByRef
		)
		{
		}

		public DenomNonnil(
			 BigInteger num
			,
			  nilnul.num_.ref_.vowless_.Positive denominator
		) : this(
			in num
			,
			 denominator.eeByRef
		)
		{
		}
		public DenomNonnil(in BigInteger numerator)
			: this(in numerator, num.integer_.Nonnil_vowlessRef.One)
		{ }

		public DenomNonnil(BigInteger numerator)
			: this(in numerator)
		{ }


		public DenomNonnil(long a) : this((BigInteger)a)
		{

		}
		public DenomNonnil() : this( /*in*/ BigInteger.Zero)
		{

		}


		public DenomNonnil inverse()
		{
			return ~(this);
		}


		public override string ToString()
		{
			return _numerator.ToString() + "/" + denominator.ToString();
		}


		static public DenomNonnil Simplify(DenomNonnil f)
		{
			var gcd = BigInteger.GreatestCommonDivisor(f._numerator, f._denominator.eeByRef); //always positive
			if (gcd.IsOne)
			{
				return f;
			}
			return new DenomNonnil(f._numerator / gcd, f.denominator / gcd);

		}

		public DenomNonnil toSimplify()
		{

			return Simplify(this);

		}

		public DenomNonnil(
			in BigInteger x
			,
			nilnul.num.integer.be_.NonZero.En y
	   )
		   : this(in x, y.asserted)
		{

		}
		public DenomNonnil(BigInteger x, nilnul.num.integer.be_.NonZero.En y)
		   : this(in x, y)
		{


		}


		public DenomNonnil(num.natural.__bigint.be.Positive.Asserted x, ref BigInteger y)
		   : this(x.val, ref y)
		{



		}


		public DenomNonnil(num.natural.__bigint.be.Positive.Asserted x, BigInteger y)
		   : this(x, ref y)
		{



		}

		public DenomNonnil(QuotientI1 a) : this(a.numerator, a.denominator1)
		{
		}

		public DenomNonnil(QuotientI a):this(a.numerator,a.denominator)
		{
		}

	

		public void standardize()
		{
			if (_numerator < 0)
			{
				_denominator.neg();
			}
		}

		public bool beNonneg
		{
			get
			{
				standardize();
				return _numerator >= 0;
			}
		}
		public bool beNonpositive
		{
			get
			{
				standardize();
				return _numerator <= 0;
			}
		}

		public bool beNeg
		{
			get
			{
				standardize();
				return _numerator < 0;
			}
		}
		public bool bePositive
		{
			get
			{
				standardize();
				return _numerator > 0;
			}
		}
		public bool beNil
		{
			get
			{
				return _numerator.IsZero;
			}
		}




		static public implicit operator DenomNonnil(BigInteger b)
		{
			return new DenomNonnil(
				in b
			);
		}
		static public implicit operator DenomNonnil(int b)
		{
			return new DenomNonnil(
				 b
			);
		}
		static public implicit operator DenomNonnil(uint b)
		{
			return new DenomNonnil(
				 b
			);
		}

		static public implicit operator DenomNonnil(long b)
		{
			return new DenomNonnil(
				 b
			);
		}
		static public implicit operator DenomNonnil(ulong b)
		{
			return new DenomNonnil(
				 b
			);
		}


		static public implicit operator DenomNonnil(
			nilnul.Num_ofIn b
		)
		{
			return new DenomNonnil(
				 b
			);
		}

		static public implicit operator DenomNonnil(
			nilnul.Num1 b
		)
		{
			return new DenomNonnil(
				 b
			);
		}

		static public bool operator ==(DenomNonnil x, DenomNonnil y)
		{
			return (x - y).beNil;
		}
		static public bool operator ==(DenomNonnil x, DenomNonnilI y)
		{
			return (x - y).beNil;
		}


		static public bool operator ==(DenomNonnil x, int y)
		{
			return (x - y).beNil;

		}
		static public bool operator !=(DenomNonnil x, int y)
		{
			return !(x == y);
		}
		static public bool operator !=(DenomNonnil x, DenomNonnil y)
		{
			return !(x == y);
		}

		static public bool operator !=(DenomNonnil x, DenomNonnilI y)
		{
			return !(x == y);
		}

		static public bool operator >=(DenomNonnil x, DenomNonnil y)
		{
			return (x - y).beNonneg;
		}
		static public bool operator >=(DenomNonnil x, DenomNonnilI y)
		{
			return (x - y).beNonneg;
		}

		static public bool operator <=(DenomNonnil x, DenomNonnil y)
		{
			return (x - y).beNonpositive;
		}
		static public bool operator <=(DenomNonnil x, DenomNonnilI y)
		{
			return (x - y).beNonpositive;
		}

		static public bool operator >(DenomNonnil x, DenomNonnil y)
		{
			return (x - y).bePositive;
		}

		static public bool operator >(DenomNonnil x, DenomNonnilI y)
		{
			return (x - y).bePositive;
		}


		static public bool operator <(DenomNonnil x, DenomNonnil y)
		{
			return (x - y).beNeg;
		}
		static public bool operator <(DenomNonnil x, DenomNonnilI y)
		{
			return (x - y).beNeg;
		}



		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DenomNonnil operator -(
			DenomNonnil a)
		{
			if (a.beNil)
			{
				return Nil;
			}

			return new DenomNonnil(
				-a._numerator
				,
				 a._denominator
			);
		}
		static public DenomNonnil operator +(
			DenomNonnil a
			,
			BigInteger b
		)
		{
			if (a.beNil)
			{
				return b;
			}
			if (b.IsZero)
			{
				return a;
			}

			return new DenomNonnil(
				 a._numerator
				 +
				 b
				 *
				 a._denominator.eeByRef

				 ,

				 a._denominator
			);
		}
		static public DenomNonnil operator +(
			BigInteger b
			,
			DenomNonnil a
		)
		{
			return a + b;
		}

		static public DenomNonnil operator +(
			DenomNonnil a
			,
			int b
		)
		{
			return a + (BigInteger)b;

		}

		static public DenomNonnil operator +(
			int b
			,
			DenomNonnil a
		)
		{
			return a + b;

		}

		static public DenomNonnil operator +(DenomNonnil a, DenomNonnil b)
		{
			if (a.beNil)
			{
				return b;
			}
			if (b.beNil)
			{
				return a;
			}
			if (a._denominator.eeByRef.IsOne)
			{
				return a._numerator + b;  //reuse the denominator

			}
			if (b._denominator.eeByRef.IsOne)
			{
				return b + a;
			}
			if (a._denominator.eeByRef == -1)
			{
				return -a._numerator + b; //reuse the denominator
			}
			if (b._denominator.eeByRef == -1)
			{
				return a - b.numerator;
			}

			if (a._denominator.eeByRef == b._denominator.eeByRef)
			{
				return new DenomNonnil(
					a._numerator + b._numerator
					,
					a._denominator
				);
			}

			if (a._denominator.eeByRef == -b._denominator.eeByRef)
			{
				return new DenomNonnil(
					a._numerator - b._numerator
					,
					a._denominator
				);
			}



			return new DenomNonnil(
				 a._numerator
				 *
				 b._denominator.eeByRef
				 +
				 b._numerator
				 *
				 a._denominator.eeByRef

				 ,

				 a._denominator * b._denominator
			);
		}

		static public DenomNonnil operator +(DenomNonnil a, DenomNonnilI b)
		{
			return new DenomNonnil(
				 a._numerator
				 *
				 b.denominator.eeByRef
				 +
				 b.numerator
				 *
				 a._denominator.eeByRef
				 ,
				 a._denominator * b.denominator
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DenomNonnil operator -(
			DenomNonnil a
			,
			DenomNonnil b
			)
		{
			return a + -b;
		}

		static public DenomNonnil operator -(
			DenomNonnil a
			,
			DenomNonnilI b
			)
		{
			return a + -(b.ToImpl());
		}

		static public DenomNonnil operator -(
			DenomNonnil a
			,
			BigInteger b
			)
		{
			return a + -b;
		}
		static public DenomNonnil operator -(
			BigInteger b,
			DenomNonnil a
			)
		{
			return b + -a;
		}


		static public DenomNonnil operator -(
			DenomNonnil a
			,
			int b
			)
		{
			return a + -b;
		}

		static public DenomNonnil operator *(
			DenomNonnil b
			,
			BigInteger a
		)
		{
			if (a.IsZero)
			{
				return Nil;
			}
			if (b.beNil)
			{
				return Nil;
			}
			if (a.IsOne)
			{
				return b;
			}
			if (a == -1)
			{
				return new DenomNonnil(-b._numerator, in b.denominator);
			}

			if (b._numerator.IsOne)
			{
				return new DenomNonnil(in a, in b.denominator);

			}
			if (b._numerator == -1)
			{
				return new DenomNonnil(-a, in b.denominator);

			}


			return new DenomNonnil(a * b._numerator, in b.denominator);
		}

		static public DenomNonnil operator *(BigInteger a, DenomNonnil b)
		{

			return b * a;
		}

		static public DenomNonnil operator *(DenomNonnil a, DenomNonnil b)
		{
			if (a.beNil)
			{
				return Nil;
			}
			if (b.beNil)
			{
				return Nil;
			}
			if (a._denominator.eeByRef.IsOne)
			{
				return a._numerator * b;
			}
			if (b._denominator.eeByRef.IsOne)
			{
				return a * b._numerator;
			}

			if (a._denominator.eeByRef == -1)
			{
				return -a._numerator * b;
			}

			if (b._denominator.eeByRef == -1)
			{
				return a * -b._numerator;
			}

			if (a._numerator == 1)
			{
				return new DenomNonnil(
					in b._numerator
					,
					a.denominator * b.denominator
				);

			}
			if (b._numerator == 1)
			{
				return new DenomNonnil(
					in a._numerator
					,
					a.denominator * b.denominator
				);
			}


			return new DenomNonnil(
				a._numerator * b._numerator
				,
				a.denominator * b.denominator
			);
		}

		static public DenomNonnil operator *(DenomNonnil a, DenomNonnilI b)
		{
			

			return new DenomNonnil(
				a._numerator * b.numerator
				,
				a.denominator * b.denominator
			);
		}


		static public DenomNonnil operator ~(DenomNonnil a)
		{
			return new(
				a._denominator, a._numerator
			);
		}
		static public DenomNonnil operator /(DenomNonnil a, DenomNonnil b)
		{
			return a * ~b;
		}


		static public DenomNonnil Inverse(DenomNonnil a)
		{

			return ~a;


		}





		static public readonly DenomNonnil Nil = new DenomNonnil();

		static public readonly DenomNonnil One = new DenomNonnil(1);
		static public readonly DenomNonnil Two = new DenomNonnil(2);
		static public readonly DenomNonnil Secondth = new DenomNonnil(1, 2);
		static public readonly DenomNonnil Third = new DenomNonnil(1, 3);
		static public readonly DenomNonnil Quarter = new DenomNonnil(1, 4);


		static public readonly DenomNonnil NegOne = new DenomNonnil(-1);
		static public readonly DenomNonnil NegTwo = new DenomNonnil(-2);
		static public readonly DenomNonnil NegSecondth = new DenomNonnil(-1, 2);
		static public readonly DenomNonnil NegThird = new DenomNonnil(-1, 3);
		static public readonly DenomNonnil NegQuarter = new DenomNonnil(-1, 4);



		/// <summary>
		/// to parse a string as fraction
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public DenomNonnil Parse(string s)
		{

			///first find the /
			///
			/// 
			string[] terms = s.Split(nilnul.num._quotient.dividing_.Frac.DividerSign);

			switch (terms.Length)
			{
				case 0:
					return DenomNonnil.Nil;
				case 1:
					return new DenomNonnil(
						BigInteger.Parse(terms[0])
					);
				case 2:
					return new DenomNonnil(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));

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

		static public bool TryParse(string s, out DenomNonnil result)
		{

			try
			{
				result = Parse(s);
				return true;
			}
			catch (Exception)
			{
				result = default(DenomNonnil);
				return false;

			}

		}

		// override object.Equals
		public override bool Equals(object obj)
		{
			//       
			// See the full list of guidelines at
			//   http://go.microsoft.com/fwlink/?LinkID=85237  
			// and also the guidance for operator== at
			//   http://go.microsoft.com/fwlink/?LinkId=85238
			//

			if (obj == null || GetType() != obj.GetType())
			{
				return false;
			}

			return (DenomNonnil)obj == this;
		}

		// override object.GetHashCode
		public override int GetHashCode()
		{
			return 0;

			//return base.GetHashCode();
		}

	}
}
