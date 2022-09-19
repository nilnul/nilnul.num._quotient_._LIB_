using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.be_;
using nilnul.num_;
using Q1 = nilnul.num.Quotient1;
using P = nilnul.num.quotient_.Positive1;

namespace nilnul.num.quotient_
{
	public class Portion : nilnul.num.quotient.be_.portion.vow.Ee
		,
		nilnul.num.QuotientI1
		
	{
		public BigInteger numerator => ee.numerator;

		public num_.Positive1 denominator1 => ee.denominator1;

		public Portion(Rational val) : base(val)
		{
		}

		public Portion(QuotientI1 val) : base((val))
		{
		}

		

		
		public Portion(int i):this(new nilnul.num.Quotient1(i))
		{

		}

		public Portion(int val, BigInteger denominator_positive) : this( Q1.CreateByDivide(val,denominator_positive))
		{
		}
		public Portion(BigInteger val, BigInteger denominator_positive) : this( Q1.CreateByDivide(val,denominator_positive))
		{
		}

		static public implicit operator Quotient1(Portion positive) {
			return new Q1( positive );
		}
		static public explicit operator Portion(Quotient1 positive) {
			return new Portion(positive);
		}

		

	

		static public Q1 operator -(Q1 x, Portion y)
		{
			return x - (Q1)y;
		}

		static public Q1 operator -(nilnul.num.QuotientI1 x, Portion y)
		{
			return nilnul.num.quotient.combine_.Minus.Singleton.combine(x,y);
		}

		static public Q1 operator -(Portion x, Q1 y)
		{
			return (Q1)x - y;
		}
		static public bool operator ==(Portion x, int y)
		{
			return x.ToClass() == y;
		}
		static public bool operator !=(Portion x, int y)
		{
			return !(x == y );
		}

		static public bool operator <(Portion x, Portion y)
		{
			return x.ToClass() < y;
		}

		static public bool operator >(Portion x, Portion y)
		{
			return x.ToClass() > y;
		}

		static public bool operator >(Portion x, int y)
		{
			return x.ToClass() > y;
		}
		static public bool operator <(Portion x, int y)
		{
			return x.ToClass() < y;
		}

		static public Q1 operator -(Portion x, nilnul.num.QuotientI1 y)
		{
			return nilnul.num.quotient.combine_.Minus.Singleton.combine(x,y);
		}


		static public P operator /(Portion x, nilnul.num_.Positive1 y)
		{
			return new P(
				x.ee.ToClass() / y

			);
		}
		static public Q1 operator /(P x, Portion y)
		{
			return 
				x.en / y

			;
		}

		static public Quotient1 operator /(Portion x, Portion y)
		{
			return 
				x.ToClass() / y

			;
		}

		static public Q1 operator /(Portion x, int y)
		{
			return(
				x.ToClass() / y

			);
		}
		static public Quotient1 operator /(Portion x, uint y)
		{
			return 
				x.ToClass() / y

			;
		}

		static public Portion operator *(Portion x, Portion y)
		{
			return new Portion(
					x.ToClass() * y
				);
		}

		static public Q1 operator +(Portion x, Portion y)
		{
			return  x.ToClass() + y;
		}

		static public Q1 operator +(Portion y, Q1 x)
		{
			return x + y;
		}

		static public Q1 operator +(Q1 x,Portion y )
		{
			return x + y;
		}


	}
}
