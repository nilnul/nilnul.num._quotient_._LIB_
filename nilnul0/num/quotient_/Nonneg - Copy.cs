using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.be_.nonneg.vow;
using nilnul.num_;
using nilnul.obj.vow;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient_
{
	public interface NonnegI 
	{
		nilnul.num.quotient.be_.nonneg.vow.En vowed { get; }
	}

	public class Nonneg
		:

		nilnul.num.quotient.be_.nonneg.vow.En
		,
		NonnegI
	{
		public Nonneg(Quotient1 val) : base(val)
		{
		}

		public Nonneg(QuotientI val) : base(val)
		{
		}

		public En vowed => this;

		static public implicit operator Quotient1(Nonneg positive)
		{
			return positive.en;
		}



		static public Q1 operator -(Q1 x, Nonneg y)
		{
			return x - (Q1)y;
		}

		static public Q1 operator -(Nonneg x, Q1 y)
		{
			return (Q1)x - y;
		}

		static public Nonneg operator /(Nonneg x, nilnul.num_.Positive1 y)
		{
			return new Nonneg(
				x.en / y

			);
		}
		static public Nonneg operator /(Nonneg x, Nonneg y)
		{
			return new Nonneg(
				x.en / y.en

			);
		}

		static public Nonneg operator /(Nonneg x, Positive1 y)
		{
			return new Nonneg(
				x.en / y

			);
		}

		static public Q1 operator /(Nonneg x, int y)
		{
			return (
				x.en / y

			);
		}

		static public Nonneg operator *(Nonneg x, Nonneg y)
		{
			return new Nonneg(
					x.en * y.en
				);
		}

		static public Q1 operator +(Q1 x, Nonneg y)
		{
			return x + (Q1)y;
		}

		static public Nonneg operator +(Nonneg x, Nonneg y)
		{
			return new Nonneg( x.en + y.en);
		}

		static public Q1 operator +(Nonneg y, Q1 x)
		{
			return x + (Q1)y;
		}
		static public bool operator ==(Nonneg y,int x)
		{
			return y.en==x;
		}
		static public bool operator !=(Nonneg y,int x)
		{
			return !(y==x);
		}

		static public bool operator <(Nonneg y,int x)
		{
			return y.en <x;
		}
		static public bool operator >(Nonneg y,int x)
		{
			return y.en >x;
		}
		static public bool operator >=(Nonneg y,int x)
		{
			return y >x || y==x;
		}

		static public bool operator <=(Nonneg y,int x)
		{
			return y <x || y==x;
		}





	}
}
