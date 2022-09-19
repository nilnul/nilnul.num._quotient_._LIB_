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

namespace nilnul.num
{
	/// <summary>
	/// guratee that denominator is positive. simplify process is expensive and unnecessary in some cases like comparison of equality.
	/// </summary>
	public class Quotient_NonnilDenom
		:

		num.IQuotient
		,
		_quotient_.numerator_.ByRefI
		,
		_quotient_.denominator_.NonnilByRefI
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
		/// throw exception eagerly such as to break from a possible long chain reaction.

		public nilnul.num.integer_.Nonnil_vowlessRef _denominator;	//=new num_.Positive1(1);

		#endregion

		public ref nilnul.num.integer_.Nonnil_vowlessRef denominator
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
		public Quotient_NonnilDenom(
			in BigInteger num
			,
			in nilnul.num.integer_.Nonnil_vowlessRef denominator
		)
		{
			this._numerator = num;
			this._denominator = denominator;


		}


		public Quotient_NonnilDenom(
			in BigInteger num
			,
			ref BigInteger denominator
		):this(
			in num
			,
			 nilnul.num.integer_.Nonnil_vowlessRef.Of(ref denominator)
		)
		{

		}

		public Quotient_NonnilDenom(
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

		public Quotient_NonnilDenom(
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

		public Quotient_NonnilDenom(
			 BigInteger num
			,
			 BigInteger denominator
		):this(
			in num
			,
			 ref denominator
		)
		{

		}

		public Quotient_NonnilDenom((BigInteger, BigInteger) p)
			:this(
				  p.Item1
				 ,
				  p.Item2
			)
		{
		}

		public Quotient_NonnilDenom(
			_quotient.Dividing dividing
		)
			: this(
				 dividing.numerator, dividing._denominator
			 )
		{

		}
		public Quotient_NonnilDenom(
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

		public Quotient_NonnilDenom(
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
		public Quotient_NonnilDenom(in BigInteger numerator)
			: this(in numerator,   num.integer_.Nonnil_vowlessRef.One)
		{ }

		public Quotient_NonnilDenom( BigInteger numerator)
			: this(in numerator)
		{ }


		public Quotient_NonnilDenom(long a) : this((BigInteger)a)
		{

		}
		public Quotient_NonnilDenom() : this( /*in*/ BigInteger.Zero)
		{

		}


		public Quotient_NonnilDenom inverse()
		{
			return ~(this);
		}


		public override string ToString()
		{
			return _numerator.ToString() + "/" + denominator.ToString();
		}


		static public Quotient_NonnilDenom Simplify(Quotient_NonnilDenom f)
		{
			var gcd = BigInteger.GreatestCommonDivisor(f._numerator, f._denominator.eeByRef); //always positive
			if (gcd.IsOne)
			{
				return f;
			}
			return new Quotient_NonnilDenom(f._numerator / gcd, f.denominator / gcd);

		}

		static public Quotient_NonnilDenom toSimplify(Quotient_NonnilDenom f)
		{
			
			return Simplify(f);

		}

		 public Quotient_NonnilDenom (
			 in BigInteger x
			 ,
			 nilnul.num.integer.be_.NonZero.En y
		)
			:this(in x, y.asserted)
		{

		}
		 public Quotient_NonnilDenom (  BigInteger x, nilnul.num.integer.be_.NonZero.En y)
			:this(in x,y)
		{


		}

	
		 public Quotient_NonnilDenom (num.natural.__bigint.be.Positive.Asserted x, ref BigInteger y)
			:this(x.val, ref y)
		{

			

		}


		 public Quotient_NonnilDenom (num.natural.__bigint.be.Positive.Asserted x, BigInteger y)
			:this(x, ref y)
		{

			

		}



		public void standardize() {
			if (_numerator < 0)
			{
				 _denominator.neg();
			}
		}
		
		public bool beNonneg {
			get {
				standardize();
				return  _numerator >= 0 ;
			}
		}
		public bool beNonpositive {
			get {
				standardize();
				return _numerator <= 0 ;
			}
		}

		public bool beNeg {
			get {
				standardize();
				return _numerator<0;
			}
		}
		public bool bePositive {
			get {
				standardize();
				return _numerator>0;
			}
		}
		public bool beNil {
			get {
				return _numerator.IsZero;
			}
		}

	


		static public implicit operator Quotient_NonnilDenom(BigInteger b)
		{
			return  new Quotient_NonnilDenom(
				in b
			);
		}
		static public implicit operator Quotient_NonnilDenom(int b)
		{
			return  new Quotient_NonnilDenom(
				 b
			);
		}

		static public bool operator ==(Quotient_NonnilDenom x, Quotient_NonnilDenom y) {
			return (x - y).beNil;
		}

		static public bool operator ==(Quotient_NonnilDenom x, int y) {
			return (x - y).beNil;

		}
		static public bool operator !=(Quotient_NonnilDenom x, int y) {
			return ! (x == y);
		}
		static public bool operator !=(Quotient_NonnilDenom x, Quotient_NonnilDenom y) {
			return !(x == y);
		}



		static public bool operator >=(Quotient_NonnilDenom x, Quotient_NonnilDenom y) {

			return (x - y).beNonneg;
		}
		static public bool operator <=(Quotient_NonnilDenom x, Quotient_NonnilDenom y) {
			return (x - y).beNonpositive;
		}

		static public bool operator >(Quotient_NonnilDenom x, Quotient_NonnilDenom y) {
			return (x - y).bePositive;
		}
		static public bool operator <(Quotient_NonnilDenom x, Quotient_NonnilDenom y) {
			return (x - y).beNeg;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Quotient_NonnilDenom operator -(
			Quotient_NonnilDenom a)
		{
			if (a.beNil)
			{
				return Nil;
			}

			return new Quotient_NonnilDenom(
				-a._numerator 
				,
				 a._denominator
			);
		}
		static public Quotient_NonnilDenom operator +(
			Quotient_NonnilDenom a
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

			return  new Quotient_NonnilDenom(
				 a._numerator
				 +
				 b
				 *
				 a._denominator.eeByRef

				 ,

				 a._denominator
			);
		}
		static public Quotient_NonnilDenom operator +(
			BigInteger b
			,
			Quotient_NonnilDenom a
		)
		{
			return a + b;
		}

		static public Quotient_NonnilDenom operator +(
			Quotient_NonnilDenom a
			,
			int b
		)
		{
			return a + (BigInteger)b;

		}

		static public Quotient_NonnilDenom operator +(
			int b
			,
			Quotient_NonnilDenom a
		)
		{
			return a + b;

		}

		static public Quotient_NonnilDenom operator +(Quotient_NonnilDenom a, Quotient_NonnilDenom b)
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
				return b+ a;
			}
			if (a._denominator.eeByRef == -1)
			{
				return -a._numerator + b; //reuse the denominator
			}
			if (b._denominator.eeByRef == -1)
			{
				return a - b.numerator;
			}

			if (a._denominator.eeByRef== b._denominator.eeByRef)
			{
				return new Quotient_NonnilDenom(
					a._numerator+b._numerator
					,
					a._denominator
				);
			}

			if (a._denominator.eeByRef== -b._denominator.eeByRef)
			{
				return new Quotient_NonnilDenom(
					a._numerator-b._numerator
					,
					a._denominator
				);
			}



			return  new Quotient_NonnilDenom(
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


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Quotient_NonnilDenom operator -(
			Quotient_NonnilDenom a
			,
			Quotient_NonnilDenom b
			)
		{
			return a + -b;
		}

		static public Quotient_NonnilDenom operator -(
			Quotient_NonnilDenom a
			,
			BigInteger b
			)
		{
			return a + -b;
		}
		static public Quotient_NonnilDenom operator -(
			BigInteger b,
			Quotient_NonnilDenom a
			)
		{
			return b + -a;
		}


		static public Quotient_NonnilDenom operator -(
			Quotient_NonnilDenom a
			,
			int b
			)
		{
			return a + -b;
		}

		static public Quotient_NonnilDenom operator *(
			Quotient_NonnilDenom b
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
				return new Quotient_NonnilDenom(-b._numerator, in b.denominator);
			}

			if (b._numerator.IsOne)
			{
				return new Quotient_NonnilDenom(in a , in b.denominator);

			}
			if (b._numerator == -1)
			{
				return new Quotient_NonnilDenom(-a , in b.denominator);

			}


			return new Quotient_NonnilDenom(a * b._numerator, in b.denominator);
		}

		static public Quotient_NonnilDenom operator *(BigInteger a, Quotient_NonnilDenom b)
		{

			return b*a;
		}

		static public Quotient_NonnilDenom operator *(Quotient_NonnilDenom a, Quotient_NonnilDenom b)
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

			if (b._denominator.eeByRef==-1)
			{
				return a *  -b._numerator;
			}

			if (a._numerator==1)
			{
				return new Quotient_NonnilDenom(
					in b._numerator
					,
					a.denominator * b.denominator
				);

			}
			if (b._numerator ==1)
			{
				return new Quotient_NonnilDenom(
					in a._numerator
					,
					a.denominator * b.denominator
				);
			}


			return new Quotient_NonnilDenom(
				a._numerator * b._numerator
				,
				a.denominator * b.denominator
			);
		}



		static public Quotient_NonnilDenom operator ~(Quotient_NonnilDenom a)
		{
			return new (
				a._denominator, a._numerator
			);
		}
		static public Quotient_NonnilDenom operator /(Quotient_NonnilDenom a, Quotient_NonnilDenom b)
		{
			return a* ~b;
		}


		static public Quotient_NonnilDenom Inverse(Quotient_NonnilDenom a)
		{

			return ~a;


		}





		static public readonly Quotient_NonnilDenom Nil = new Quotient_NonnilDenom();

		static public readonly Quotient_NonnilDenom One = new Quotient_NonnilDenom(1);
		static public readonly Quotient_NonnilDenom Two = new Quotient_NonnilDenom(2);
		static public readonly Quotient_NonnilDenom Secondth = new Quotient_NonnilDenom(1,2);
		static public readonly Quotient_NonnilDenom Third = new Quotient_NonnilDenom(1,3);
		static public readonly Quotient_NonnilDenom Quarter = new Quotient_NonnilDenom(1,4);


		static public readonly Quotient_NonnilDenom NegOne = new Quotient_NonnilDenom(-1);
		static public readonly Quotient_NonnilDenom NegTwo = new Quotient_NonnilDenom(-2);
		static public readonly Quotient_NonnilDenom NegSecondth = new Quotient_NonnilDenom(-1,2);
		static public readonly Quotient_NonnilDenom NegThird = new Quotient_NonnilDenom(-1,3);
		static public readonly Quotient_NonnilDenom NegQuarter = new Quotient_NonnilDenom(-1,4);



		/// <summary>
		/// to parse a string as fraction
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public Quotient_NonnilDenom Parse(string s)
		{

			///first find the /
			///
			/// 
			string[] terms = s.Split(nilnul.num._quotient.dividing_.Frac.DividerSign);

			switch (terms.Length)
			{
				case 0:
					return  Quotient_NonnilDenom.Nil;
				case 1:
					return new Quotient_NonnilDenom(
						BigInteger.Parse(terms[0])
					);
				case 2:
					return new Quotient_NonnilDenom(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));

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

		static public bool TryParse(string s, out Quotient_NonnilDenom result)
		{

			try
			{
				result = Parse(s);
				return true;
			}
			catch (Exception)
			{
				result = default(Quotient_NonnilDenom);
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

			return (Quotient_NonnilDenom)obj == this;
		}

		// override object.GetHashCode
		public override int GetHashCode()
		{
			return 0;

			//return base.GetHashCode();
		}

	}
}
