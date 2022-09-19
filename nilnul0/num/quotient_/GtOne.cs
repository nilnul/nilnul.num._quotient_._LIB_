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
	public class GtOne : nilnul.num.quotient.be_.gtOne.vow.Ee
		,
		nilnul.num.QuotientI1
		
	{
		public BigInteger numerator => ee.numerator;

		public num_.Positive1 denominator1 => ee.denominator1;

		public GtOne(Quotient1 val) : base(val)
		{
		}

		public GtOne(QuotientI1 val) : base((val))
		{
		}

		

		
		public GtOne(int i):this(new nilnul.num.Quotient1(i))
		{

		}

		public GtOne(int val, BigInteger denominator_positive) : this(new Q1(val,denominator_positive))
		{
		}
		public GtOne(BigInteger val, BigInteger denominator_positive) : this(new Q1(val,denominator_positive))
		{
		}

		static public implicit operator Quotient1(GtOne positive) {
			return new Q1( positive );
		}
		static public explicit operator GtOne(Quotient1 positive) {
			return new GtOne(positive);
		}

		static public explicit operator GtOne(int positive) {
			return new GtOne(positive);
		}

	

		static public Q1 operator -(Q1 x, GtOne y)
		{
			return x - (Q1)y;
		}

		static public Q1 operator -(nilnul.num.QuotientI1 x, GtOne y)
		{
			return nilnul.num.quotient.combine_.Minus.Singleton.combine(x,y);
		}

		static public Q1 operator -(GtOne x, Q1 y)
		{
			return (Q1)x - y;
		}
		static public bool operator ==(GtOne x, int y)
		{
			return x.ToClass() == y;
		}
		static public bool operator !=(GtOne x, int y)
		{
			return !(x == y );
		}

		static public bool operator <(GtOne x, GtOne y)
		{
			return x.ToClass() < y;
		}

		static public bool operator >(GtOne x, GtOne y)
		{
			return x.ToClass() > y;
		}

		static public bool operator >(GtOne x, int y)
		{
			return x.ToClass() > y;
		}
		static public bool operator <(GtOne x, int y)
		{
			return x.ToClass() < y;
		}

		static public Q1 operator -(GtOne x, nilnul.num.QuotientI1 y)
		{
			return nilnul.num.quotient.combine_.Minus.Singleton.combine(x,y);
		}


		static public P operator /(GtOne x, nilnul.num_.Positive1 y)
		{
			return new P(
				x.ee.ToClass() / y

			);
		}
		static public P operator /(P x, GtOne y)
		{
			return new P(
				x.en / y

			);
		}

		static public Quotient1 operator /(GtOne x, GtOne y)
		{
			return 
				x.ToClass() / y

			;
		}

		static public Q1 operator /(GtOne x, int y)
		{
			return(
				x.ToClass() / y

			);
		}
		static public Quotient1 operator /(GtOne x, uint y)
		{
			return 
				x.ToClass() / y

			;
		}

		static public GtOne operator *(GtOne x, GtOne y)
		{
			return new GtOne(
					x.ToClass() * y
				);
		}

		static public GtOne operator +(GtOne x, GtOne y)
		{
			return new GtOne( x.ToClass() + y);
		}

		static public Q1 operator +(GtOne y, Q1 x)
		{
			return x + y;
		}

		static public Q1 operator +(Q1 x,GtOne y )
		{
			return x + y;
		}


	}
}
