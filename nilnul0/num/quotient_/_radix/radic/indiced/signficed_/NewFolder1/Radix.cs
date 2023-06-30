using nilnul.bit;
using nilnul.num.natural;
using nilnul.num.quotient._radix;
using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.txt;

namespace nilnul.num.quotient_
{
	/// <summary>
	/// the character class has been defined in nilnul.num.Radix
	/// </summary>
	///
	/// <see cref="quotient_._radix.radic.indiced.ISignificed"/>
	[Obsolete()]
	public  class Radix
	{

		public const char DOT = '.';


		private nilnul.num_._radix.Root _base;

		public nilnul.num_._radix.Root base_
		{
			get { return _base; }
			set { _base = value; }
		}


		public BigInteger baseAsBigInt
		{
			get { return _base.rootAsBigint; }
			set { _base.radic = new num_.Plural( value); }
		}


		public int sign
		{
			get { return significand.Sign; }
		}

		/// <summary>
		/// aka coefficient
		/// </summary>
		/// 
		[Obsolete()]
		public BigInteger magnitudeAsBigInt
		{
			get
			{
				return BigInteger.Abs(significand);
			}
		}

		public BigInteger absAmplifierAsBigInt
		{
			get
			{
				return BigInteger.Abs(significand);
			}
		}


		private SignificandIndex _float;

		public SignificandIndex float_
		{
			get { return _float; }
			set { _float = value; }
		}

		/// <summary>
		/// aka coefficient
		/// </summary>
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

		[Obsolete(nameof(exponent))]
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

		public BigInteger exponent
		{
			get
			{
				return _float.index;
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
			nilnul.num_._radix.Root base_
			,
			SignificandIndex float_

			)
		//: this(base_.val, float_.significand, float_.index)
		{
			this._base = base_;
			this._float = float_;


		}

		public Radix(
			BigInteger base_
			,
			SignificandIndex float_

	)
			: this(new nilnul.num_._radix.Root( new num_.Plural( base_)), float_)
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
			: this(base_, new SignificandIndex(significand, index))
		{

		}

		public Radix(
			Radix other
			)
			: this(other.base_.rootAsBigint, other._float.significand, other._float.index)
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
				return;
				
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
			significand *= _base.rootAsBigint;
			index--;
		}

		public void _appendZero(int _natural_zeros)
		{
			while (_natural_zeros-->0)
			{
				appendZero();
			}
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


		public override string ToString()
		{
			return toTxt();
		}

		public string toStr_exp()
		{
			var r = significand.ToString(); //todo: this need to be based on base.
			return r + "*" + this.baseAsBigInt.ToString() + "^" + this.index.ToString();

		}

		public string toStr_func()
		{
			return string.Format("nilnul.num.rational.float_.Float3({0},{1},{2})", baseAsBigInt, significand, index);


		}

		[Obsolete("",true)]
		public string toStr_linear()
		{
			var r = significand.ToString(); //todo: this need to be based on base.

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

			return r.Insert((int)(offset), ".");    //todo:biginteger

		}

		[Obsolete("",true)]
		public string toStr_linear_no0_intFirst_()
		{

			var r = significand.ToString(); //todo: this need to be based on base.
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

			return r.Insert((int)(offset), ".");    //todo:biginteger

		}

		[Obsolete("",true)]
		public string toStr_linear_no_0_prepend()
		{
			var r = magnitudeAsBigInt.ToString();   //todo: this need to be based on base.
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

			return sign < 0 ? "-" : "" + r.Insert((int)(offset), ".");  //todo:biginteger

		}

		[Obsolete("",true)]
		public string toStr_linear_0_prepended()
		{

			var r = magnitudeAsBigInt.ToString();   //todo: this need to be based on base.

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

			return (sign < 0 ? "-" : "") + r.Insert((int)(offset), ".");    //todo:biginteger

		}

		public StringBuilder toTxt_noSign_dotInserted_noZeroPrepend() {

			const char dot = '.';

			#region MakeAmplifierLong enough to accomodate the dot position shift.

			var sb = new StringBuilder(

				 nilnul.num.natural.op.ToStrX._Eval_0Empty(absAmplifierAsBigInt, baseAsBigInt)
			);

			var dotPosition = sb.Length + exponent;

			if (dotPosition > sb.Length)
			{
				sb.Append(
					nilnul.obj.str.X.Repeat(0, dotPosition - sb.Length)
					);
			}
			else if (dotPosition < 0)
			{
				sb = sb.Prepend(
					nilnul.obj.str.X.Repeat(
						'0'
						,
						BigInteger.Abs(dotPosition)
					)
				);
				dotPosition = 0;
			}



			#endregion



			sb.Insert(
				(int)(dotPosition)
				,
				dot
			);

			return sb;
		}
		public string toTxt()
		{
			var sb = toTxt_noSign_dotInserted_noZeroPrepend();
			
			#region cosmetic the string (before sign is applied)

			if (sb.First()==DOT)
			{
				sb.Prepend("0");

			}

			if (sb.Last()==DOT)
			{
				sb.RemoveLast();
			}

			#endregion

			#region sign it

			return sb.Prepend(sign<0?"-":"").ToString();


			#endregion

		

		}

		[Obsolete(nameof(toTxt))]

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

		static public Q1 ToQ(
	Radix x
)
		{

			return (x.significand) * nilnul.num.quotient.op.PowX._Eval_basePlural(x._base.rootAsBigint, x.index)
			;


		}
		

		public Q1 toQ(

)
		{

			return (significand) * nilnul.num.quotient.op.PowX._Eval_basePlural(_base.rootAsBigint, index)
			;


		}

		public Rational_InheritFraction2 toRational(
   )
		{

			return (significand) * nilnul.num.rational.op.PowX.Eval_basePlural2(_base.rootAsBigint, index)
			;


		}


		static public Radix FroQ(BigInteger radix_plural, nilnul.num.quotient.Q rational, BigInteger digits_natural)
		{

			return FroRational(radix_plural, rational, new Natural_bigInteger(digits_natural));
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
		static public Radix _FroQuotient(
			BigInteger _root_plural,
			Q1 rational
			,
			BigInteger _digitsAftDot_natural
		)
		{


			var intFrac = nilnul.num.quotient.FlooredX.ToFloored( rational); ;

			BigInteger quotient = intFrac.floor;
			BigInteger remainder = intFrac.tail.val.numerator;



			BigInteger index = 0;



			while (_digitsAftDot_natural > 0)
			{

				quotient = quotient * _root_plural + BigInteger.DivRem(remainder * _root_plural, rational.denominator.val, out remainder);
				_digitsAftDot_natural--;
				index--;

			}
			return new Radix(_root_plural, quotient, index);

			throw new NotImplementedException();
		}



		static public Radix _FroQuotient(
			BigInteger root_plural,
			nilnul.num.quotient.Q rational
			,
			BigInteger digitsAftDot_natural
		)
		{


			var intFrac = nilnul.num.quotient.FlooredX.ToFloored( rational); ;

			BigInteger quotient = intFrac.floor;
			BigInteger remainder = intFrac.tail.val.numerator;



			BigInteger index = 0;



			while (digitsAftDot_natural > 0)
			{

				quotient = quotient * root_plural + BigInteger.DivRem(remainder * root_plural, rational.denominator.val, out remainder);
				digitsAftDot_natural--;
				index--;

			}
			return new Radix(root_plural, quotient, index);

			throw new NotImplementedException();
		}

		static public Radix _FroQ(
			BigInteger root_plural,
			_quotient.fraction.op.Simplify.Ed1 rational
			,
			BigInteger digitsAftDot_natural
		)
		{


			var intFrac = nilnul.num.quotient.FlooredX.ToFloored( rational); ;

			BigInteger quotient = intFrac.floor;
			BigInteger remainder = intFrac.tail.val.numerator;



			BigInteger index = 0;



			while (digitsAftDot_natural > 0)
			{

				quotient = quotient * root_plural + BigInteger.DivRem(remainder * root_plural, rational.denominator.val, out remainder);
				digitsAftDot_natural--;
				index--;

			}
			return new Radix(root_plural, quotient, index);

			throw new NotImplementedException();
		}


		static public Radix FroRational(BigInteger radix_plural, Rational_InheritFraction2 rational, BigInteger digits_natural)
		{

			return FroRational(radix_plural, rational, new Natural_bigInteger(digits_natural));
		}






		static public Radix Multi(
				BigInteger radix_plural,
				rational.Float significandIndex1
				,
				SignificandIndex significandIndex2



				)
		{
			return new Radix(radix_plural, significandIndex1.significand * significandIndex2.significand, significandIndex1.index + significandIndex2.index);


			throw new NotImplementedException();
		}

		static public Radix Square(Radix a

		)
		{
			return new Radix(a._base.rootAsBigint, a.significand * a.significand, a.index + a.index);// Multi(a.baseAsBigInt, a._significandIndex, a.significandIndex);
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
			SignificandIndex a,

			SignificandIndex b

			)
		{

			return _Add(radix_plural, a, b.toNegate());



		}
		static public Radix Subtract(
			BigInteger radix_plural,
			SignificandIndex a,

			SignificandIndex b

			)
		{

			return _Add(radix_plural, a, b.toNegate());



		}

		static public Radix _Add(

			BigInteger radix_plural,
			SignificandIndex a, SignificandIndex b
			)
		{

			if (b.index < a.index)
			{
				return _Add_smallerFirst(radix_plural, b, a);
			}
			return _Add_smallerFirst(radix_plural, a, b);


			throw new NotImplementedException();

		}

		static public Radix _Add_smallerFirst(BigInteger radix_plural, SignificandIndex _powerSmaller, SignificandIndex powerMax)
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