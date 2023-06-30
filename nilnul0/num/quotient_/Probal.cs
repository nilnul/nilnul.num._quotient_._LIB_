using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.be_;
using nilnul.num_;
using Q1 = nilnul.num.quotient_.DenomNonnilI;
using P = nilnul.num.quotient_.Positive1;
using nilnul.num.integer_;
using nilnul.num.quotient_.denomNonnil;

namespace nilnul.num.quotient_
{
	public class Probal : nilnul.num.quotient.be_.probal.vow.Ee
		,
		nilnul.num.quotient_.DenomNonnilI
		
	{


		public ref Nonnil_vowlessRef denominator =>ref eeByRef.denominator;

		public ref  BigInteger numerator =>ref eeByRef.numerator;
		public Probal(DenomNonnil val) : base(val)
		{
		}
		public Probal(QuotientI1 val) : this((val.ToDenomNonnil()))
		{
		}

		public Probal(Rational val) : this( new DenomNonnil(val.numerator,val.denominator))
		{
		}


		

		
		public Probal(int i):this(new nilnul.num.quotient_.DenomNonnil(i))
		{

		}

		public Probal(int val, BigInteger denominator_positive) : this( new DenomNonnil(val,denominator_positive))
		{
		}
		public Probal(BigInteger val, BigInteger denominator_positive) : this( new DenomNonnil(val,denominator_positive))
		{
		}


		static public implicit operator DenomNonnil(Probal positive) {
			return ( positive.eeByRef.ToImpl() );
		}
		static public explicit operator Probal(DenomNonnil positive) {
			return new Probal(positive);
		}

		static public explicit operator Probal(int positive) {
			return new Probal(positive);
		}

	

		static public Q1 operator -(DenomNonnil x, Probal y)
		{
			return x -y.eeByRef;
		}
		static public Q1 operator -(Q1 x, Probal y)
		{
			return x.ToImpl() - y;
		}


		//static public Q1 operator -(nilnul.num.quotient_.DenomNonnil x, Probal y)
		//{
		//	return x-y.eeByRef;
		//}

		static public Q1 operator -(Probal x, DenomNonnil y)
		{
			return x.eeByRef - y;
		}
		static public Q1 operator -(Probal x, Q1 y)
		{
			return x - y.ToImpl();
		}

		static public bool operator ==(Probal x, int y)
		{
			return x.eeByRef.ToImpl() == y;
		}
		static public bool operator !=(Probal x, int y)
		{
			return !(x == y );
		}
		static public bool operator <(DenomNonnil x, Probal y)
		{
			return x < y.eeByRef;
		}
		static public bool operator <(Q1 x, Probal y)
		{
			return x.ToImpl() < y;
		}


		static public bool operator <(Probal x, Probal y)
		{
			return x.eeByRef < y;
		}

		static public bool operator >(DenomNonnil x, Probal y)
		{
			return x > y.eeByRef;
		}
		static public bool operator >(Q1 x, Probal y)
		{
			return x.ToImpl() > y;
		}

		static public bool operator >(Probal x, Probal y)
		{
			return x.eeByRef > y;
		}

		static public bool operator >(Probal x, int y)
		{
			return x.eeByRef.ToImpl() > y;
		}
		static public bool operator <(Probal x, int y)
		{
			return x.eeByRef.ToImpl() < y;
		}

		static public Q1 operator -(Probal x, nilnul.num.QuotientI1 y)
		{
			return (x - y.ToDenomNonnil());
		}


		static public DenomNonnil operator /(Probal x, BigInteger y)
		{
			return (
				x.eeByRef.ToImpl() / y

			);
		}
		static public DenomNonnil operator /(BigInteger x, Probal y)
		{
			return (
				x / y.eeByRef.ToImpl()

			);
		}
		static public Probal operator /(Probal x, nilnul.num_.Positive1 y)
		{
			return new Probal(
				x / y.en

			);
		}
		static public Q1 operator /(DenomNonnil x, Probal y)
		{
			return 	x / y.eeByRef.ToImpl()	;
		}
		static public Q1 operator /(Q1 x, Probal y)
		{
			return 	x.ToImpl() / y;
		}

		static public Q1 operator /(P x, Probal y)
		{
			return 	x.en.ToDenomNonnil() / y	;
		}

		static public Q1 operator /(Probal x, Probal y)
		{
			return 
				x.eeByRef / y

			;
		}

		static public DenomNonnil operator /(Probal x, int y)
		{
			return(
				x.eeByRef.ToImpl() / y

			);
		}
		static public DenomNonnil operator /(Probal x, uint y)
		{
			return 
				x.eeByRef.ToImpl() / y

			;
		}

		static public DenomNonnil operator *(DenomNonnil x, Probal y)
		{
			return 					x * y.eeByRef				;
		}

		static public DenomNonnil operator *(DenomNonnilI x, Probal y)
		{
			return 					x.ToImpl() * y;
		}

		static public Probal operator *(Probal x, Probal y)
		{
			return new Probal(
					x.eeByRef * y
				);
		}


		static public Q1 operator +(Probal x, Probal y)
		{
			return  x.eeByRef + y;
		}
		static public Q1 operator +(Q1 x,Probal y )
		{
			return x + y;
		}

		static public Q1 operator +(Probal y, Q1 x)
		{
			return x + y;
		}



	}
}
