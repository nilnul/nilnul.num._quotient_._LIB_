using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient_;
using nilnul.num_;

using N = nilnul.NumI;


using Q1 = nilnul.num.QuotientI;

namespace nilnul.num
{
	[Obsolete()]
	public class Quotient : nilnul.num._quotient.fraction.op.Simplify.Ed1
		, QuotientI
	{
		

		public Quotient(NumI current1, NumI current2)
			:base(current1.toBigint(), current2.toBigint())
		{
			
		}

		public Quotient(nilnul.num.Quotient q):base(q.fraction)
		{

		}

		public Quotient(
			BigInteger num
			,
			nilnul.num_.Positive den
			
		)
			:base(num,den)
		{

		}

		public Quotient(
			BigInteger num,BigInteger den
		)
			:base(num, den
				 
			 )
		{
		}


		public Quotient(int a):this(a,1)
		{

		}
		public Quotient(
			BigInteger num
		)
			:this(num,
				 nilnul.num_.Positive.CreateOne()
			 )
		{
		}

		public Quotient():this(0, new nilnul.num_.Positive( 1)  )
		{

		}

		static public Quotient CreateZero() {
			return new Quotient();
		}

		static public Quotient CreateOne() {
			return new Quotient(1);
		}

		static public Quotient CreateUnit(int _denominator_positive)
		{
			return new Quotient(1, new nilnul.num_.Positive( _denominator_positive));
		}

		static public Quotient CreatePositiveUnital(BigInteger _denominator_positive)
		{
			return new Quotient(1, new nilnul.num_.Positive( _denominator_positive));
		}
		static public Quotient operator +(Quotient a, BigInteger b)
		{
			return new Quotient(a.numerator + a.denominator*b, a.denominator); ;
		}


		static public Quotient operator -(Quotient a, Quotient b)
		{
			return  nilnul.num.quotient.combine_.Minus.Singleton.eval(a,b) ;
		}
		static public Quotient operator -(Quotient a)
		{
			return  new Quotient(-a.numerator,a.denominator) ;
		}


		static public Quotient operator +(Quotient a, Quotient b)
		{
			return new Quotient(a.numerator*b.denominator + a.denominator*b.numerator, a.denominator*b.denominator); ;
		}



		static public Quotient operator *(Quotient a, Quotient b)
		{
			return new Quotient(a.numerator*b.numerator,a.denominator*b.denominator);
		}

		static public Quotient operator /(Quotient a, Quotient b)
		{
			return new Quotient(a.numerator*b.denominator,a.denominator*b.numerator);
		}


		static public implicit operator Quotient(int a)
		{
			return new nilnul.num.Quotient(a) ;
		}



		Positive DenominatorI.denominator
		{
			get
			{
				return new Positive(
					this.denominator
				);
				//throw new NotImplementedException();
			}
		}

		public static Quotient CreateByDivide(int num, int den)
		{
			return new Quotient(num, den);
			throw new NotImplementedException();
		}
	}
}
