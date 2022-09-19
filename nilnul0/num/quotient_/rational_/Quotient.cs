using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient_;
using nilnul.num_;

using N = nilnul.NumI;


using Q1 = nilnul.num.Quotient1;

namespace nilnul.num
{
	[Obsolete("making the numerator and denominator coprime would be performant bad in contrast with uncoprimed version, in which we only need the denominator to be positive. The equality of quotient can be achieved by minus, which is algebra involving multiplying only and fast while copriming invoving division, an invert operation, has to go through trial and backtrack.")]
	public class Quotient1 : nilnul.num._quotient.frac.convert_.simplify.Ed
		,QuotientI
		,
		nilnul.num._quotient_.DenominatorI1
		,
		IEqualityComparer<Quotient1>
		,
		nilnul.num.QuotientI1
	{
		public Positive1 denominator1 => new Positive1( base.denominator);

		[Obsolete()]
		public Quotient1(NumI current1, NumI current2)
			:base(current1.toBigint(), current2.toBigint())
		{
			
		}
		public Quotient1(NumI1 current1, NumI1 current2)
			:base(current1.toBigint(), current2.toBigint())
		{
			
		}

		public Quotient1(nilnul.num.QuotientI1 q):this(q.numerator,q.denominator1)
		{

		}


		public Quotient1(Num current1, Num current2)
			:base(current1.toBigint(), current2.toBigint())
		{
			
		}

		public Quotient1(NumI current1):this( current1, 1)
		{

		}

		public Quotient1(_quotient.Frac frac):base( frac)
		{

		}


		public Quotient1(Num x):this(x as NumI)
		{

		}

		

		public Quotient1(
			BigInteger num
			,
			nilnul.num_.Positive den
			
		)
			:base(num,den)
		{

		}
		public Quotient1(
			int num
			,
			nilnul.num_.Positive den
			
		)
			:base(num,den)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="num"></param>
		/// <param name="den"></param>
		/// 
		//[Obsolete( " this shall be vowed; any logic otherwise shall be put in "+nameof(CreateByDivide))]
		//Note: this herits simplify.Ed so this constructor is ok.

		public Quotient1(
			BigInteger num,BigInteger den
		)
			:base(
				// _quotient.Frac.CreateByDivide(num, den)

				 num, den
				 
			 )
		{
			//base.
		}


		public Quotient1(int a):this(a,1)
		{

		}
		public Quotient1(
			BigInteger num
		)
			:this(num,
				 nilnul.num_.Positive1.CreateOne()
			 )
		{
		}

		public Quotient1():this(0, new nilnul.num_.Positive( 1)  )
		{

		}

		public Quotient1(N current1, int v):base(current1,v)
		{
		}
		public Quotient1(NumI1 current1, int v):base(current1,v)
		{
		}
		public Quotient1(NumI1 current1) : this(current1, 1)
		{
		}
		public Quotient1(Num1 current1) : this(current1, 1)
		{
		}
		public Quotient1(uint current1) : this(new BigInteger(current1))
		{
		}

		public Quotient1(QuotientI a):base( a.numerator,a.denominator)
		{
		}

		

		static public Quotient1 CreateZero() {
			return new Quotient1();
		}

		static public Quotient1 CreateOne() {
			return new Quotient1(1);
		}
		static public Quotient1 CreateUnit(int _denominator_positive)
		{
			if (_denominator_positive>0)
			{
			return new Quotient1(1, new nilnul.num_.Positive( _denominator_positive));

			}
			return new Quotient1(-1, new nilnul.num_.Positive( -_denominator_positive));
		}
		static public Quotient1 CreateHalf()
		{
			return new Quotient1(1, 2);
		}

		static public Quotient1 CreateUnit(BigInteger _denominator_positive)
		{
			if (_denominator_positive<0)
			{
			return new Quotient1(-1, new nilnul.num_.Positive( -_denominator_positive));

			}

			return new Quotient1(1, new nilnul.num_.Positive( _denominator_positive));
		}

		static public Quotient1 CreateUnit(nilnul.NumI _denominator_positive)
		{
			
			return CreateUnit(_denominator_positive.toBigint());
				
			
		}

		static public Quotient1 CreateUnit(nilnul.NumI1 _denominator_positive)
		{
			return CreateUnit(_denominator_positive.toBigint());
		}

		static public Quotient1 CreateUnit(nilnul.Num1 _denominator_positive)
		{
			return CreateUnit((nilnul.NumI1)_denominator_positive);
		}


		static public Quotient1 CreatePositiveUnital(BigInteger _denominator_positive)
		{
			return new Quotient1(1, new nilnul.num_.Positive( _denominator_positive));
		}
		static public Quotient1 operator +(Quotient1 a, BigInteger b)
		{
			return new Quotient1(a.numerator + a.denominator*b, a.denominator); ;
		}


		
		static public Quotient1 operator -(Quotient1 a)
		{
			return  new Quotient1(-a.numerator,a.denominator) ;
		}


		static public Quotient1 operator +(Quotient1 a, Quotient1 b)
		{
			return new Quotient1(a.numerator*b.denominator + a.denominator*b.numerator, a.denominator*b.denominator); ;
		}

		static public Quotient1 operator +(Quotient1 a, QuotientI b)
		{
			return new Quotient1(a.numerator*b.denominator + a.denominator*b.numerator, a.denominator*b.denominator); ;
		}


		static public Quotient1 operator *(Quotient1 a, Quotient1 b)
		{
			return new Quotient1(a.numerator*b.numerator,a.denominator*b.denominator);
		}

		static public Quotient1 operator *(Quotient1 a, QuotientI b)
		{
			return new Quotient1(a.numerator*b.numerator,a.denominator*b.denominator);
		}

		static public Quotient1 operator /(Quotient1 a, Quotient1 b)
		{
			return new Quotient1(a.numerator*b.denominator,a.denominator*b.numerator);
		}

		static public Quotient1 operator /(Quotient1 a, nilnul.num_.Positive1 b)
		{
			return new Quotient1(a.numerator,a.denominator*b);
		}

		static public bool operator <(Q1 a, Q1 b)
		{

			return (a - b).numerator < 0;



		}
		static public bool operator >=(Q1 a, Q1 b)
		{

			return !(a < b);



		}
		static public bool operator <=(Q1 a, Q1 b)
		{

			return !(a > b);



		}

		static public bool operator >(Q1 a, Q1 b)
		{

			return b < a;



		}

		static public bool operator ==(Q1 a, Q1 b)
		{

			return (a.numerator == b.numerator) && (a.denominator == b.denominator);

		}


		static public bool operator !=(Q1 a, Q1 b)
		{

			return !(a == b);

		}



		


		

		static public Q1 operator *(BigInteger a, Q1 b)
		{
			return new Q1(a * b.numerator, b.denominator);
		}
		static public Q1 operator *(int a, Q1 b)
		{
			return ((BigInteger)a) *b;
		}

		static public Q1 operator *(Q1 b, BigInteger a )
		{
			return new Q1(a * b.numerator, b.denominator);
		}

		static public Q1 operator ^(Q1 b, nilnul.NumI1 a )
		{
			return nilnul.num.quotient.op_.unary_.Poly.Op(b,a);
		}


		static public Q1 operator *(Q1 b, int a )
		{
			return new Q1(a * b.numerator, b.denominator);
		}


		static public Q1 operator +(BigInteger a, Q1 b)
		{
			return new Q1(a * b.denominator + b.numerator, b.denominator);
		}


		static public Q1 operator -(Q1 a, Q1 b)
		{
			return new Q1(a.numerator * b.denominator - a.denominator * b.numerator, a.denominator.val * b.denominator.val);
		}




		static public implicit operator Quotient1(int a)
		{
			return new nilnul.num.Quotient1(a) ;
		}
		static public implicit operator Quotient1(BigInteger a)
		{
			return new nilnul.num.Quotient1(a) ;
		}

		static public implicit operator Quotient1(uint a)
		{
			return new nilnul.num.Quotient1(a) ;
		}
		static public implicit operator Quotient1(long a)
		{
			return new nilnul.num.Quotient1(a) ;
		}

		static public implicit operator Quotient1(ulong a)
		{
			return new nilnul.num.Quotient1(a) ;
		}

		static public implicit operator Quotient1(nilnul.Num a)
		{
			return new nilnul.num.Quotient1(a) ;
		}

		static public implicit operator Quotient1(nilnul.Num1 a)
		{
			return new nilnul.num.Quotient1(a) ;
		}

		static public Quotient1 Ov(QuotientI1 interfaced) {
			if (interfaced is Quotient1 q)
			{
				return q;
			}
			return new Q1(
				interfaced
			);
		}


		

		public static Quotient1 CreateByDivide(int num, int den)
		{
			return new Quotient1(
				_quotient.Frac.CreateByDivide(num,den)
				
				);
			//throw new NotImplementedException();
		}

		public static Quotient1 CreateByDivide(BigInteger num, BigInteger den)
		{
			return new Quotient1(

					_quotient.Frac.CreateByDivide(num, den)

				

			);
		}

		public bool Equals(Q1 a, Q1 b)
		{
			return    (a.numerator == b.numerator) && (a.denominator == b.denominator);

		}

		public int GetHashCode(Q1 obj)
		{
			return obj.numerator.GetHashCode() & obj.denominator.GetHashCode();
		}

		public override string ToString()
		{
			if (denominator1==1)
			{
				return numerator.ToString();
			}
			///for frac, the denominator is always reserved even if it's nil.
			return base.ToString();
		}
	}
}
