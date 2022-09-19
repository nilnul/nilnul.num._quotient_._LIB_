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
	public class Natural : nilnul.num.quotient.be_.integer_.nonneg.vow.Ee
		,
		nilnul.num.QuotientI1
		
	{
		public BigInteger numerator => ee.numerator;

		public num_.Positive1 denominator1 => ee.denominator1;

		public Natural(Quotient1 val) : base(val)
		{
		}

		public Natural(QuotientI1 val) : base((val))
		{
		}

		

		
		public Natural(int i):this(new nilnul.num.Quotient1(i))
		{

		}

		
		static public implicit operator Quotient1(Natural positive) {
			return new Q1( positive );
		}
		static public explicit operator Natural(Quotient1 positive) {
			return new Natural(positive);
		}

		

	

		static public Q1 operator -(Q1 x, Natural y)
		{
			return x - (Q1)y;
		}

		static public Q1 operator -(nilnul.num.QuotientI1 x, Natural y)
		{
			return nilnul.num.quotient.combine_.Minus.Singleton.combine(x,y);
		}

		static public Q1 operator -(Natural x, Q1 y)
		{
			return (Q1)x - y;
		}
		static public bool operator ==(Natural x, int y)
		{
			return x.ToClass() == y;
		}
		static public bool operator !=(Natural x, int y)
		{
			return !(x == y );
		}

		static public bool operator <(Natural x, Natural y)
		{
			return x.ToClass() < y;
		}

		static public bool operator >(Natural x, Natural y)
		{
			return x.ToClass() > y;
		}

		static public bool operator >(Natural x, int y)
		{
			return x.ToClass() > y;
		}
		static public bool operator <(Natural x, int y)
		{
			return x.ToClass() < y;
		}



		static public Natural operator +(Natural x, Natural y)
		{
			return new Natural(  x.ToClass() + y );
		}

		static public Q1 operator +(Natural y, Q1 x)
		{
			return x + y;
		}

		static public Q1 operator +(Q1 x,Natural y )
		{
			return x + y;
		}


	}
}
