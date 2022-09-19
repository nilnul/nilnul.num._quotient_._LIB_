using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;
using Fraction = nilnul.num.quotient.Fraction150626;
using nilnul.num.rational;

using Q = nilnul.num.quotient.Q;
using q = nilnul.num.quotient;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient
{
	/// <summary>
	/// </summary>
	/// 
	[Obsolete(
		nameof(
			_quotient.fraction.op.Simplify.Ed1
			)
		,false
		)
		
		]
	public partial class Q
		: fraction._be.Quotient.Be.Asserted
		,IEquatable<Q>

	{
		static public nilnul.num.rational.Rational_InheritFraction2 ToFraction2(Q q) => new Rational_InheritFraction2(q.numerator, q.denominator.val);

		static public Q GetHalf() => new Q(1, 2);

		public BigInteger numerator
		{
			get
			{
				return val.numerator;
			}
			private set {
				val.numerator = value;
			}
		}

		public Q1 toNewVersion() {
			return new Q1(numerator, denominator.val);

		}
		public nilnul.num.natural.__bigint.be.Positive.Asserted denominator
		{
			get
			{
				return val.denominator;
			}
		}

		public BigInteger denominatorAsBigInt
		{
			get
			{
				return val.denominator.val;
			}
		}

		public Q(Fraction150626 f)
			: base(Fraction.Simplify(f))

		{

		}
		public Q(BigInteger numerator, BigInteger denominator)
			: this(new Fraction(numerator, denominator))
		{

		}


		public Q(int numerator, BigInteger denominator)
			: this(new Fraction(numerator, denominator))
		{

		}

		public Q(BigInteger num, nilnul.num.natural.__bigint.be.Positive.Asserted den)
			: this(
				new Fraction(num, den)
			 )
		{

		}

		public bool isPositive {
			get {
				return numerator > 0;
			}
		}

		public bool isNonneg {
			get {
				return numerator >= 0;
			}
		}


		public int signInInt { get { return numerator.Sign; } }

		public Q(BigInteger num)
			: this(
				new Fraction150626(num)
			 )
		{

		}

		public Q()
			: this(0)
		{



		}

		public override string ToString()
		{
			return val.ToString();
		}

		public Q toNegate()
		{
			this.numerator = -this.numerator;
			return this;

		}


		static public Q CreateZero() {
			return new Q();
		}
		static public Q CreateOne() {
			return new Q(1);
		}

		static public Q CreateHalf() {
			return new Q(1, 2);
		}

		static public Q CreateThird() {
			return new Q(1, 3);
		}

		static public Q CreateFourth() {
			return new Q(1, 4);
		}


		static public Q ToAbs(Q x)
		{
			return new Q(BigInteger.Abs(x.numerator), x.denominator);
		}

		static public Q Multiply(Q a, Q b)
		{

			return a.val * b.val;



		}

		static public Tuple<BigInteger, Q> ToIntAndTail(Q x)
		{
			var t = nilnul.num.integer.op.Divide._Eval_floor_divisorPositive__retTuple(x.numerator, x.denominator.val);

			return new Tuple<BigInteger, Q>(
				t.Item1,
				new Q(t.Item2, x.denominator.val)
			);

		}

		public BigInteger toInt() { return ToInt(this); }

		static public BigInteger ToInt(Q x)
		{
			return nilnul.num.integer.op.Divide._Eval_floor_divisorPositive(x.numerator, x.denominatorAsBigInt);


		}

		static public Q Add(Q a, Q b)
		{

			return new Q(a.numerator * b.denominator + a.denominator * b.numerator, a.denominator * b.denominator);



		}
		static public Q Abs(Q a)
		{

			return new Q(BigInteger.Abs(a.numerator), a.denominator);



		}
		static public Q Add(BigInteger a, Q b)
		{

			return new Q(a * b.denominator + b.numerator, b.denominator);



		}
		static public Q Inverse(BigInteger denominator)
		{
			return new Q(1, denominator);
		}
		static public Q Inverse(Q x)
		{
			return new Q(x.denominator.val, x.numerator);
		}

		static public implicit operator Q(Fraction150626 f)
		{
			var gcd = nilnul.num.integer.duo.op.Gcd.Eval(f.numerator, f.denominator);
			return new Q(f.numerator / gcd, f.denominator / gcd);



		}


		static public implicit operator Q(int i)
		{
			return new Q(i);
		}


		static public implicit operator Rational_InheritFraction2(Q q) {
			return new Rational_InheritFraction2(q.numerator, q.denominator.val);
		}

		static public implicit operator Q( nilnul.num.rational.be.Positive.Asserted q) {
			return new Q(q.val.numerator, q.val.denominator.val);
		}



		static public implicit operator Q(Rational_InheritFraction2 q) {
			return new Q(q.numerator, q.denominator.val);
		}

		static public bool operator <(Q a, Q b)
		{

			return (a - b).numerator < 0;



		}
		static public bool operator >=(Q a, Q b)
		{

			return !(a <b);



		}
		static public bool operator <=(Q a, Q b)
		{

			return !(a >b);



		}

		static public bool operator >(Q a, Q b)
		{

			return b < a;



		}

		static public bool operator ==(Q a, Q b)
		{

			return Equals(a, b);

		}


		static public bool operator !=(Q a, Q b)
		{

			return !Equals(a, b);

		}

		static public implicit operator Q(BigInteger f)
		{

			return new Q(f);



		}


		//static public implicit operator Q(Rational_InheritFraction2 f)
		//{

		//	return new Q(f.numerator, f.denominator);



		//}
		//static public explicit operator Rational_InheritFraction2(Q f)
		//{

		//	return new Rational_InheritFraction2(f.numerator, f.denominator.val);



		//}
		static public bool Equals(Q a, Q b)
		{

			return a.numerator == b.numerator && a.denominator == b.denominator;

		}


		static public Q operator *(Q a, Q b)
		{
			return a.val * b.val;
		}
		static public Q operator -(Q a)
		{
			return new Q(-a.numerator, a.denominator);
		}

		static public Q operator +(Q a, Q b)
		{
			return new Q(a.numerator * b.denominator + a.denominator * b.numerator, a.denominator * b.denominator);
		}

		static public Q operator -(Q a, Q b)
		{
			return new Q(a.numerator * b.denominator - a.denominator * b.numerator, a.denominator * b.denominator);
		}

		static public Q operator +(BigInteger a, Q b)
		{
			return new Q(a * b.denominator + b.numerator, b.denominator);
		}

		

	



		public void abs()
		{
			this.numerator = BigInteger.Abs(numerator);
		}



		static public Q operator /(Q a, Q b)
		{

			return Divide(a, b);

		}

		static public Q Divide(Q a, Q b)
		{

			return new Q(

				 Fraction.Divide(a.val, b.val)

			);
		}
		static public Q Divide(int a, int b)
		{

			return new Q(

				a, b

			);
		}

		public bool Equals(Q other)
		{
			return this.numerator == other.numerator && this.denominatorAsBigInt == other.denominatorAsBigInt;
			throw new NotImplementedException();
		}

		// override object.Equals
		public override bool Equals(object obj)
		{
			//       
			// See the full list of guidelines at
			//   http://go.microsoft.com/fwlink/?LinkID=85237  
			// and also the guidance for operator== at
			//   http://go.microsoft.com/fwlink/?LinkId=85238
			//

			if (obj  is null || GetType() != obj.GetType())
			{
				return false;
			}

			// TODO: write your implementation of Equals() here

			return Equals(obj as Q);
			//throw new NotImplementedException();
			return base.Equals(obj);
		}

		// override object.GetHashCode
		public override int GetHashCode()
		{
			// TODO: write your implementation of GetHashCode() here
			return numerator.GetHashCode() ^ denominatorAsBigInt.GetHashCode();
			throw new NotImplementedException();
			
		}

		public Q clone()
		{
			return new Q( this.numerator,this.denominator);
			throw new NotImplementedException();
		}
	}
}
