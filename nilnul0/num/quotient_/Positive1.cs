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
using En = nilnul.num.quotient_.Positive1;
using nilnul.vow;

namespace nilnul.num.quotient_
{
	public class Positive1 : nilnul.num.quotient.be_.positive.vow.En
		//,
		//PositiveI
		
	{
		//quotient.be_.positive.vow.En EnI<quotient.be_.positive.vow.En>.en => this;

		public Positive1(Quotient1 val) : base(val)
		{
		}

		public Positive1(QuotientI val) : base(new Q1(val))
		{
		}

		

		public Positive1(nilnul.num_.Positive num):this(new Quotient1(num))
		{

		}
		public Positive1(int i):this(new nilnul.num_.Positive(i))
		{

		}

		public Positive1(int val, BigInteger denominator_positive) : this(new Q1(val,denominator_positive))
		{
		}
		public Positive1(BigInteger val, BigInteger denominator_positive) : this(new Q1(val,denominator_positive))
		{
		}

		static public implicit operator Quotient1(Positive1 positive) {
			return positive.en;
		}
		static public explicit operator Positive1(Quotient1 positive) {
			return new Positive1(positive);
		}

		static public explicit operator Positive1(int positive) {
			return new Positive1(positive);
		}

	

		static public Q1 operator -(Q1 x, Positive1 y)
		{
			return x - (Q1)y;
		}

		static public Q1 operator -(Positive1 x, Q1 y)
		{
			return (Q1)x - y;
		}
		static public bool  operator ==( Positive1 x, int i )
		{
			return x.en==i;
		}


		static public bool  operator !=( Positive1 x, int i )
		{
			return !(x==i);
		}
		static public bool  operator >( Positive1 x, int i )
		{
			return x.en>i;
		}

		static public bool  operator <( Positive1 x, int i )
		{
			return x.en<i;
		}

		static public Positive1 operator /(Positive1 x, nilnul.num_.Positive1 y)
		{
			return new Positive1(
				x.en / y

			);
		}

		static public Positive1 operator /(Positive1 x, Positive1 y)
		{
			return new Positive1(
				x.en / y

			);
		}

		static public Q1 operator /(Positive1 x, int y)
		{
			return(
				x.en / y

			);
		}
		static public Positive1 operator /(Positive1 x, uint y)
		{
			return new Positive1(
				x.en / y

			);
		}

		static public Positive1 operator *(Positive1 x, Positive1 y)
		{
			return new Positive1(
					x.en * y.en
				);
		}

		static public Q1 operator +(Q1 x, Positive1 y)
		{
			return x + (Q1)y;
		}

		static public Q1 operator +(Positive1 y, Q1 x)
		{
			return x + (Q1)y;
		}


	}
}
