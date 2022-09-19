using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using F = nilnul.num._quotient.Fraction1;
using N = nilnul._num.bigint.op.Abs.Ed;
using nilnul.num._num.bigint.be;
using nilnul._num.bigint.be_;
using nilnul._num.bigint.be;

namespace nilnul.num._quotient.fraction.op
{
	[Obsolete()]
	public partial class Simplify
	{


		public class Ed1

		//: F //composition is prefereed to inheritace
		{

			private F _fraction;

			internal static Q Divide(int v, nilnul._num.bigint.be.Natural.Asserted asserted)
			{

				return Divide(v, asserted.val);
				throw new NotImplementedException();
			}

			public F fraction
			{
				get { return _fraction; }
				set
				{

					_fraction = Simplify.Eval(fraction);

				}
			}

			public Ed1(F fraction)
			{
				_fraction = Simplify.Eval(fraction);
			}

			public Ed1(

				BigInteger num
				,
				nilnul._num.bigint.be.Positive.Asserted denominator
			)
			{
				_fraction = Simplify.Eval(num, denominator);
			}

			public Ed1(int num,int denominator):this(
				new F(num,denominator)	
			)
			{

			}

			public Ed1(int num,BigInteger denominator):this(
				new F(num,denominator)	
			)
			{

			}
			public Ed1(BigInteger num,BigInteger denominator):this(
				new F(num,denominator)	
			)
			{

			}

			public Ed1():this(new F())
			{

			}

			public Ed1(BigInteger num)
			: this(
				new F(num)
			 )
		{

			}

			public Ed1(long value1, long value2)
				:this((BigInteger)value1, value2)
			{
				
			}



			public override string ToString()
			{

				return toTxt();
#if DEBUG
				return nilnul.num.quotient.radix.Dec.FroQuotient(this,10).ToString();
#else
				
				return toTxt();


#endif

			}

			public string toTxt() {
				return $"{numerator}/{denominator}";

			}

			public int signInInt { get { return numerator.Sign; } }



			public BigInteger numerator {
				get { return _fraction.numerator; }
			}

			public nilnul._num.bigint.be.Positive.Asserted denominator {
				get { return new nilnul._num.bigint.be.Positive.Asserted( _fraction.denominator.val); }
			}

			public Ed1 toHalf() {
				return this / 2;
			}


			static public implicit operator Q(BigInteger x) {
				return new Q(x);
			}

			static public implicit operator Ed1(Plural.En x) {
				return new Ed1(x);
			}

		static public implicit operator Ed1(nilnul._num.bigint.be.Natural.Asserted  x) {
				return new Ed1(x.val);
			}
			static public implicit operator Q(N x) {
				return new Q(x);
			}


			static public explicit operator nilnul.num.quotient.Q(Ed1 x) {
				return new nilnul.num.quotient.Q(x.numerator,x.denominator);
			}
			static public explicit operator Ed1( nilnul.num.quotient.Q x) {
				return new Ed1(x.numerator,x.denominator.val);
			}


			static public Q operator /(Q a, Q b)
			{

				return Divide(a, b);

			}

			static public Q operator /(Q a, nilnul._num.bigint.be.Positive.Asserted b)
			{

				return Divide(a, b);

			}

			public static Q Divide(Q a, nilnul._num.bigint.be.Positive.Asserted b)
			{
				return Divide(a,b.val);
				throw new NotImplementedException();
			}

			static public Q Divide(Q a, Q b)
			{

				return new Q(
					F.Divide(a.fraction, b.fraction)
				);
			}

			static public Q Divide(long a, long b)
			{

				return new Q(
					a,b
				);
			}




			static public implicit operator Q(int i)
			{
				return new Q(i);
			}

static public implicit operator Q(uint i)
			{
				return new Q(i);
			}
			static public bool operator <(Q a, Q b)
			{

				return (a - b).numerator < 0;



			}
			static public bool operator >=(Q a, Q b)
			{

				return !(a < b);



			}
			static public bool operator <=(Q a, Q b)
			{

				return !(a > b);



			}

			static public bool operator >(Q a, Q b)
			{

				return b<a;



			}

			static public bool operator ==(Q a, Q b)
			{

				return (a.numerator== b.numerator) && (a.denominator==b.denominator);

			}


			static public bool operator !=(Q a, Q b)
			{

				return !(a==b);

			}



			static public Q operator -(Q a)
			{
				return new Q(-a.fraction.numerator, a.fraction.denominator);
			}


			static public Q operator *(Q a, Q b)
			{
				return new Q( a.fraction * b.fraction);
			}

			static public Q operator *(BigInteger  a, Q b)
			{
				return new Q( a * b.fraction);
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




			static public Ed1 Create(int x, int y) {
				return new Q(x, y);
			}


			static public Ed1 _CreateUnit(int _denominator_positive) {
				return new Ed1(1, _denominator_positive);
			}

			static public Ed1 _CreateUnit(BigInteger denominator_nonZero) {
				return new Ed1(1, denominator_nonZero);
			}

			public static Q CreateZero()
			{
				return new Q();
				throw new NotImplementedException();
			}

			static public Q CreateOne()
			{
				return new Q(1);
			}

			static public Q CreateHalf()
			{
				return new Q(1, 2);
			}

			static public Q CreateThird()
			{
				return new Q(1, 3);
			}

			static public Q CreateFourth()
			{
				return new Q(1, 4);
			}

			static public Q CreatePercent(int x) {
				return new Q(x, 100);
			}









		}

	}







}
