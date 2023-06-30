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
	[Obsolete(nameof(Probal))]
	public class Proportion : nilnul.num.quotient.be_.proportion.vow.Ee
		,
		nilnul.num.QuotientI1
		
	{
		public BigInteger numerator => ee.numerator;

		public num_.Positive1 denominator1 => ee.denominator1;

		public Proportion(Rational val) : base(val)
		{
		}

		public Proportion(QuotientI1 val) : base((val))
		{
		}

		

		
		public Proportion(int i):this(new nilnul.num.Quotient1(i))
		{

		}

		public Proportion(int val, BigInteger denominator_positive) : this( Q1.CreateByDivide(val,denominator_positive))
		{
		}
		public Proportion(BigInteger val, BigInteger denominator_positive) : this( Q1.CreateByDivide(val,denominator_positive))
		{
		}

		static public implicit operator Quotient1(Proportion positive) {
			return new Q1( positive );
		}
		static public explicit operator Proportion(Quotient1 positive) {
			return new Proportion(positive);
		}

		static public explicit operator Proportion(int positive) {
			return new Proportion(positive);
		}

	

		static public Q1 operator -(Q1 x, Proportion y)
		{
			return x - (Q1)y;
		}

		static public Q1 operator -(nilnul.num.QuotientI1 x, Proportion y)
		{
			return nilnul.num.quotient.combine_.Minus.Singleton.combine(x,y);
		}

		static public Q1 operator -(Proportion x, Q1 y)
		{
			return (Q1)x - y;
		}
		static public bool operator ==(Proportion x, int y)
		{
			return x.ToClass() == y;
		}
		static public bool operator !=(Proportion x, int y)
		{
			return !(x == y );
		}

		static public bool operator <(Proportion x, Proportion y)
		{
			return x.ToClass() < y;
		}

		static public bool operator >(Proportion x, Proportion y)
		{
			return x.ToClass() > y;
		}

		static public bool operator >(Proportion x, int y)
		{
			return x.ToClass() > y;
		}
		static public bool operator <(Proportion x, int y)
		{
			return x.ToClass() < y;
		}

		static public Q1 operator -(Proportion x, nilnul.num.QuotientI1 y)
		{
			return nilnul.num.quotient.combine_.Minus.Singleton.combine(x,y);
		}


		static public P operator /(Proportion x, nilnul.num_.Positive1 y)
		{
			return new P(
				x.ee.ToClass() / y

			);
		}
		static public Q1 operator /(P x, Proportion y)
		{
			return 
				x.en / y

			;
		}

		static public Quotient1 operator /(Proportion x, Proportion y)
		{
			return 
				x.ToClass() / y

			;
		}

		static public Q1 operator /(Proportion x, int y)
		{
			return(
				x.ToClass() / y

			);
		}
		static public Quotient1 operator /(Proportion x, uint y)
		{
			return 
				x.ToClass() / y

			;
		}

		static public Proportion operator *(Proportion x, Proportion y)
		{
			return new Proportion(
					x.ToClass() * y
				);
		}

		static public Q1 operator +(Proportion x, Proportion y)
		{
			return  x.ToClass() + y;
		}

		static public Q1 operator +(Proportion y, Q1 x)
		{
			return x + y;
		}

		static public Q1 operator +(Q1 x,Proportion y )
		{
			return x + y;
		}


	}
}
