using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed;

namespace nilnul.num._quotient.fraction.op
{
	public partial  class Simplify
	{

	[Obsolete()]

		public class Ed

		//: Fraction //composition is prefereed to inheritace
		{

			private Fraction _fraction;

			public Fraction fraction
			{
				get { return _fraction; }
				set
				{

					_fraction = Simplify.Eval(fraction);

				}
			}

			public Ed(Fraction fraction)
			{
				_fraction = Simplify.Eval(fraction);
			}

			public Ed(

				BigInteger num
				,
				num.natural.__bigint.be.Positive.Asserted denominator
			)
			{
				_fraction = Simplify.Eval(num, denominator);
			}

			public Ed(int num,int denominator):this(
				new Fraction(num,denominator)	
			)
			{

			}

			public Ed(int num,BigInteger denominator):this(
				new Fraction(num,denominator)	
			)
			{

			}
			public Ed(BigInteger num,BigInteger denominator):this(
				new Fraction(num,denominator)	
			)
			{

			}

			public Ed():this(new Fraction())
			{

			}

			public BigInteger numerator {
				get { return _fraction.numerator; }
			}

			public nilnul._num.bigint.be.Positive.Asserted denominator {
				get { return new nilnul._num.bigint.be.Positive.Asserted( _fraction.denominator.val); }
			}

			public Ed(BigInteger num)
			: this(
				new Fraction(num)
			 )
		{

			}

			static public implicit operator nilnul.num.Quotient(Ed ed) {
				return new Quotient(ed.numerator,ed.denominator);
			}


			static public Q operator -(Q a)
			{
				return new Q(-a.fraction.numerator, a.fraction.denominator);
			}


			static public Q operator *(Q a, Q b)
			{
				return new Q( a.fraction * b.fraction);
			}

			static public Q operator +(Q a, Q b)
			{
				return new Q(a.fraction.numerator * b.fraction.denominator + a.fraction.denominator * b.fraction.numerator, a.fraction.denominator * b.fraction.denominator);
			}
			static public Q operator +(BigInteger a, Q b)
			{
				return new Q(a * b.denominator + b.numerator, b.denominator);
			}


			static public Q operator -(Q a, Q b)
			{
				return new Q(a.numerator * b.denominator - a.denominator * b.numerator, a.denominator.val * b.denominator.val);
			}







			static public Ed _CreateUnit(int _denominator_nonZero) {
				return new Ed(1, _denominator_nonZero);
			}

			static public Ed CreateUnit(BigInteger denominator_nonZero) {
				return new Ed(1, denominator_nonZero);
			}

			public static Q CreateZero()
			{
				return new Q();
				throw new NotImplementedException();
			}







		}


	}







}
