using nilnul.bit;
using nilnul.num.natural;
using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient._radix
{
	[Obsolete()]
	public  class Radix
	{

		private natural.be.plural.bigint.Asserted _base;

		public natural.be.plural.bigint.Asserted base_
		{
			get { return _base; }
			set { _base = value; }
		}


		public BigInteger baseAsBigInt
		{
			get { return _base.val; }
			set { _base.val = value; }
		}


		public int sign
		{
			get { return significand.Sign; }
		}

		public BigInteger magnitudeAsBigInt
		{
			get
			{
				return BigInteger.Abs(significand);
			}
		}




		private rational.Float _float;

		public rational.Float float_
		{
			get { return _float; }
			set { _float = value; }
		}

		public BigInteger significand
		{
			get
			{
				return _float.significand;
			}
			set
			{
				_float.significand = value;
			}
		}

		public BigInteger index
		{
			get
			{
				return _float.index;
			}
			set
			{
				_float.index = value;
			}
		}

		public int indexAsInt
		{
			get
			{
				return (int)_float.index;
			}
			set
			{
				_float.index = value;
			}
		}




		public Radix(BigInteger radix)
			: this(radix, 0)
		{


		}
		public Radix(natural.be.plural.bigint.Asserted base_)
			: this(base_.val)
		{

		}
		public Radix(
			natural.be.plural.bigint.Asserted base_
			,
			rational.Float float_

			)
		//: this(base_.val, float_.significand, float_.index)
		{
			this._base = base_;
			this._float = float_;


		}

		public Radix(
			BigInteger base_
			,
			rational.Float float_

	)
			: this(new natural.be.plural.bigint.Asserted(base_), float_)
		{


		}

		public Radix()
			: this(2)
		{

		}
		public Radix(
			BigInteger base_,
			BigInteger significand,
			BigInteger index
			)
			: this(base_, new rational.Float(significand, index))
		{

		}

		public Radix(
			Radix other
			)
			: this(other.base_.val, other._float.significand, other._float.index)
		{

		}
		public Radix(BigInteger radix, BigInteger significand)
			: this(radix, significand, 0)
		{

		}

		public void reduce()
		{
			if (significand == 0)
			{
				index = 0;
			}

			BigInteger remainder;
			var q = BigInteger.DivRem(significand, baseAsBigInt, out remainder);

			while (remainder == 0)
			{
				significand = q;
				index++;

				q = BigInteger.DivRem(significand, baseAsBigInt, out remainder);

			}
		}

		public void appendZero()
		{
			significand *= _base.val;
			index--;
		}

		public void appendOne()
		{
			appendZero();
			significand++;
		}

		public void append(BigInteger digits)
		{



		}

		public nilnul.num.natural.collection.Interval digits()
		{
			return new natural.collection.Interval(baseAsBigInt);
		}

		public void assertIsDigit(BigInteger digit)
		{

			AssertX.True(digits().contains(new Natural2(digit)));

		}

		public void morePrecision(BigInteger siginificandNewLastDigit)
		{

			assertIsDigit(siginificandNewLastDigit);

			significand = significand * baseAsBigInt + siginificandNewLastDigit;

			index -= 1;

		}

		public Radix toMorePresion(
	BigInteger siginificandNewLastDigit

	)
		{

			var r = new Radix(this);

			r.morePrecision(siginificandNewLastDigit);
			return r;

		}
		public Radix toReduce()
		{
			var r = new Radix(this);
			r.reduce();
			return r;
		}



		static public bool operator ==(Radix x, int y)
		{
			return x.toQ() == y;
		}
		static public bool operator !=(Radix x, int y)
		{
			return x.toQ() != y;
		}

		static public bool operator ==(Radix x, Q y)
		{
			return x.toQ() == y;
		}
		static public bool operator !=(Radix x, Q y)
		{
			return x.toQ() != y;
		}
		static public bool operator ==(Q x, Radix y)
		{
			return x == y.toQ();
		}
		static public bool operator !=(Q x, Radix y)
		{
			return x != y.toQ();
		}

		public override string ToString()
		{
			return toStr_linear_0_prepended2();
		}

		public string toStr_exp()
		{
			var r = significand.ToString();	//todo: this need to be based on base.
			return r + "*" + this.baseAsBigInt.ToString() + "^" + this.index.ToString();

		}

		public string toStr_func()
		{
			return string.Format("nilnul.num.rational.float_.Float3({0},{1},{2})", baseAsBigInt, significand, index);


		}

		public string toStr_linear()
		{
			var r = significand.ToString();	//todo: this need to be based on base.

			var counter = index;
			if (index == 0)
			{
				return r;

			}
			if (index > 0)
			{

				r += nilnul.obj.str.X.Repeat(0, index);

				return r;
			}
			var significandLength = r.Length;
			var offset = significandLength + index;

			if (offset <= 0)
			{
				r = "." + nilnul.obj.str.X.Repeat(0, -(offset)) + significand;
				return r;


			}
			if (offset == 0)
			{
				return r;

			}
			//offset >0.

			return r.Insert((int)(offset), ".");	//todo:biginteger

		}

		public string toStr_linear_no0_intFirst_()
		{

			var r = significand.ToString();	//todo: this need to be based on base.
			var counter = index;
			if (index == 0)
			{
				return r;

			}
			if (index > 0)
			{

				r += nilnul.obj.str.X.Repeat(0, index);

				return r;
			}

			var significandLength = r.Length;
			var offset = significandLength + index;

			if (offset <= 0)
			{
				r = "." + nilnul.obj.str.X.Repeat(0, -(offset)) + significand;
				return r;


			}
			if (offset == 0)
			{
				return r;

			}
			//offset >0.

			return r.Insert((int)(offset), ".");	//todo:biginteger

		}


		public string toStr_linear_no_0_prepend()
		{
			var r = magnitudeAsBigInt.ToString();	//todo: this need to be based on base.
			var counter = index;
			if (index == 0)
			{
				return sign < 0 ? "-" : "" + r;

			}
			if (index > 0)
			{

				r += nilnul.obj.str.X.Repeat(0, index);

				return sign < 0 ? "-" : "" + r;
			}

			var magniLength = r.Length;
			var offset = magniLength + index;

			if (offset <= 0)
			{
				r = "." + nilnul.obj.str.X.Repeat(0, -(offset)) + r;
				return sign < 0 ? "-" : "" + r;


			}
			if (offset == 0)
			{
				return sign < 0 ? "-" : "" + r;

			}
			//offset >0.

			return sign < 0 ? "-" : "" + r.Insert((int)(offset), ".");	//todo:biginteger

		}

		public string toStr_linear_0_prepended()
		{

			var r = magnitudeAsBigInt.ToString();	//todo: this need to be based on base.

			var counter = index;

			if (index == 0)
			{
				return (sign < 0 ? "-" : "") + r;

			}
			if (index > 0)
			{

				r += nilnul.obj.str.X.Repeat(0, index);

				return (sign < 0 ? "-" : "") + r;
			}

			var significandLength = r.Length;
			var offset = significandLength + index;

			if (offset <= 0)
			{
				r = "0." + nilnul.obj.str.X.Repeat(0, -(offset)) + r;
				return (sign < 0 ? "-" : "") + r;


			}
			if (offset == 0)
			{
				return (sign < 0 ? "-" : "") + r;

			}
			//offset >0.

			return (sign < 0 ? "-" : "") + r.Insert((int)(offset), ".");	//todo:biginteger

		}


		public string toStr_linear_0_prepended2()
		{

			var r = nilnul.num.natural.op.ToStrX.Do(magnitudeAsBigInt, baseAsBigInt);
			var counter = index;
			if (index == 0)
			{
				return (sign < 0 ? "-" : "") + r;
			}
			if (index > 0)
			{
				r += nilnul.obj.str.X.Repeat(0, index);
				return (sign < 0 ? "-" : "") + r;
			}

			var significandLength = r.Length;


			var offsetOfDot = significandLength + index;

			if (offsetOfDot <= 0)
			{
				r = "0." + nilnul.obj.str.X.Repeat(0, -(offsetOfDot)) + r;
				return (sign < 0 ? "-" : "") + r;

			}
			if (offsetOfDot == 0)
			{
				return (sign < 0 ? "-" : "") + r;
			}
			return (sign < 0 ? "-" : "") + r.Insert((int)(offsetOfDot), ".");

		}

		public Rational_InheritFraction2 toRational(
   )
		{

			return (significand) * nilnul.num.rational.op.PowX.Eval_basePlural2(_base.val, index)
			;


		}
		 public Q toQ(
			
   )
		{

			return (significand) * nilnul.num.quotient.op.PowX.Eval_basePlural2(_base.val, index)
			;


		}


		static public Q ToQ(
			Radix x
   )
		{

			return (x.significand) * nilnul.num.quotient.op.PowX.Eval_basePlural2(x._base.val, x.index)
			;


		}

		static public  implicit operator   Q(
			Radix x
   )
		{

			return (x.significand) * nilnul.num.quotient.op.PowX.Eval_basePlural2(x._base.val, x.index)
			;


		}




		static public Radix FroRational(
			BigInteger radix_plural,
			Rational_InheritFraction rational
			,
			natural.Natural_bigInteger digits
		)
		{


			var intFrac = rational.ToIntAndProper();

			BigInteger quotient = intFrac.Item1;
			BigInteger remainder = intFrac.Item2.numerator;



			BigInteger index = 0;



			while (digits > 0)
			{

				quotient = quotient * radix_plural + BigInteger.DivRem(remainder * radix_plural, rational.denominatorAsBigInt, out remainder);
				digits--;
				index--;

			}
			return new Radix(radix_plural, quotient, index);

			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="radix_plural"></param>
		/// <param name="rational"></param>
		/// <param name="digits">how many digits following the dot</param>
		/// <returns></returns>

		static public Radix FroRational(
	BigInteger radix_plural,
	Rational_InheritFraction2 rational
	,
	natural.Natural_bigInteger digits
)
		{


			var intFrac = rational.ToIntAndProper();

			BigInteger quotient = intFrac.Item1;
			BigInteger remainder = intFrac.Item2.numerator;



			BigInteger index = 0;



			while (digits > 0)
			{

				quotient = quotient * radix_plural + BigInteger.DivRem(remainder * radix_plural, rational.denominatorAsBigInt, out remainder);
				digits--;
				index--;

			}
			return new Radix(radix_plural, quotient, index);

			throw new NotImplementedException();
		}


		static public Radix FroRational(BigInteger radix_plural, Rational_InheritFraction2 rational, BigInteger digits_natural)
		{

			return FroRational(radix_plural, rational, new Natural_bigInteger(digits_natural));
		}


		static public Radix FroQ(BigInteger radix_plural, Q rational, BigInteger digits_natural)
		{

			return FroRational(radix_plural, rational, new Natural_bigInteger(digits_natural));
		}



		static public Radix Multi(
				BigInteger radix_plural,
				rational.Float significandIndex1
				,
				Float significandIndex2



				)
		{
			return new Radix(radix_plural, significandIndex1.significand * significandIndex2.significand, significandIndex1.index + significandIndex2.index);


			throw new NotImplementedException();
		}

		static public Radix Square(Radix a

		)
		{
			return new Radix(a._base.val, a.significand * a.significand, a.index + a.index);// Multi(a.baseAsBigInt, a._significandIndex, a.significandIndex);
		}

		public Radix toSquare()
		{
			return Square(this);
		}

		public void negate()
		{
			this.significand = -this.significand;

		}
		public Radix toNegate()
		{
			var r = new Radix(this);
			r.negate();
			return r;
		}

		static public Radix Negate(
		   Radix a
			)
		{

			var b = new Radix(a);
			b.negate();
			return b;


		}

		static public Radix _Subtract(
			BigInteger radix_plural,
			Float a,

			Float b

			)
		{

			return _Add(radix_plural, a, b.toNegate());



		}
		static public Radix Subtract(
			BigInteger radix_plural,
			Float a,

			Float b

			)
		{

			return _Add(radix_plural, a, b.toNegate());



		}

		static public Radix _Add(

			BigInteger radix_plural,
			Float a, Float b
			)
		{

			if (b.index < a.index)
			{
				return _Add_smallerFirst(radix_plural, b, a);
			}
			return _Add_smallerFirst(radix_plural, a, b);


			throw new NotImplementedException();

		}

		static public Radix _Add_smallerFirst(BigInteger radix_plural, Float _powerSmaller, Float powerMax)
		{


			var t = powerMax.index - _powerSmaller.index;

			return new Radix(
				radix_plural
				,

				powerMax.significand * nilnul.num.natural.op.PowX2.Do_basePlural_indexNonNeg(radix_plural, t) + _powerSmaller.significand
				,
				_powerSmaller.index

			);

			throw new NotImplementedException();

		}
	}
}