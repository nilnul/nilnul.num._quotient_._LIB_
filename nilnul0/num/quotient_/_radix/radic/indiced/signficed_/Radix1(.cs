using nilnul.bit;
using nilnul.num.natural;
using nilnul.num.quotient._radix;
using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using nilnul.txt;
using nilnul.num_;

namespace nilnul.num.quotient_
{
	/// <summary>
	/// the character class has been defined in nilnul.num.Radix
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <see cref="_radix.radic.indiced.ISignificed"/>
	/// <!---->
	///
	[Obsolete(nameof(Radix2) + ", as this would trim nils;")]
	public class Radix1
		:
	num.quotient_._radix.radic.indiced.ISignificed
	{

		public const char DOT = '.';


		private nilnul.num_._radix.Root _base;

		public nilnul.num_._radix.Root base_
		{
			get { return _base; }
			set { _base = value; }
		}


		/// <summary>
		/// the root or base such as 10, 16, or 2.
		/// </summary>
		public BigInteger baseAsBigInt
		{
			get { return _base.rootAsBigint; }
			set { _base.radic = new num_.Plural(value); }
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
		public BigInteger indicand
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



		public Radix1(BigInteger radix)
			: this(radix, 0)
		{


		}
		public Radix1(natural.be.plural.bigint.Asserted base_)
			: this(base_.val)
		{

		}
		public Radix1(
			nilnul.num_._radix.Root base_
			,
			SignificandIndex float_

			)
		//: this(base_.val, float_.significand, float_.index)
		{
			this._base = base_;
			this._float = float_;


		}

		public Radix1(
			BigInteger base_
			,
			SignificandIndex float_

	)
			: this(new nilnul.num_._radix.Root(new num_.Plural(base_)), float_)
		{


		}

		public Radix1()
			: this(2)
		{

		}
		public Radix1(
			BigInteger base_,
			BigInteger significand,
			BigInteger index
			)
			: this(base_, new SignificandIndex(significand, index))
		{

		}

		public Radix1(
			Radix1 other
			)
			: this(other.base_.rootAsBigint, other._float.significand, other._float.index)
		{

		}
		public Radix1(BigInteger radix, BigInteger significand)
			: this(radix, significand, 0)
		{

		}

		/// <summary>
		/// note the order of the pars: radic, <see cref="nonneg_._radix.IScientific"/>
		/// </summary>
		/// <param name="signified"></param>
		public Radix1((BigInteger radic, BigInteger signific, BigInteger indic) signified) : this(
			signified.radic, signified.signific, signified.indic
		)
		{
		}
		static public Radix1 OfSignific9radic9indic((BigInteger signific, BigInteger radic, BigInteger indic) signified)
		{
			return new Radix1(
			signified.radic, signified.signific, signified.indic
		);
		}

		/// <summary>
		/// simplify this to the standard simplest form.
		/// </summary>
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
			while (_natural_zeros-- > 0)
			{
				appendZero();
			}
		}


		public void appendOne()
		{
			appendZero();
			significand++;
		}





		public nilnul.num.natural.collection.Interval digits()
		{
			return new natural.collection.Interval(baseAsBigInt);
		}

		public void assertIsDigit(BigInteger digit)
		{

			AssertX.True(digits().contains(new Natural2(digit)));

		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="siginificandNewLastDigit">
		/// another git of precision;
		/// </param>
		public void morePrecision(BigInteger siginificandNewLastDigit)
		{

			assertIsDigit(siginificandNewLastDigit);

			significand = significand * baseAsBigInt + siginificandNewLastDigit;

			index -= 1;

		}

		public Radix1 toMorePresion(
			BigInteger siginificandNewLastDigit
		)
		{

			var r = new Radix1(this);

			r.morePrecision(siginificandNewLastDigit);
			return r;

		}
		public Radix1 toReduce()
		{
			var r = new Radix1(this);
			r.reduce();
			return r;
		}


		/// <summary>
		/// <see cref="num.quotient_.Radix2"/>
		/// </summary>
		/// <returns></returns>
		///
		[Obsolete("use the class's newer version as this is a misnomer and it's indeed is a significed")]
		public override string ToString()
		{

			return $"{significand}*{this.baseAsBigInt}^{this.index}"; // as we included the base, there is no need to express each component in the base herein; To express the number in base, we can express it in such way as: 00123010.0310321000 
																	  //return toTxt();
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

		[Obsolete("", true)]
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

		[Obsolete("", true)]
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

		[Obsolete("", true)]
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

		[Obsolete("", true)]
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

		public BigInteger dotPosition
		{
			get
			{
				return significandInRadix.abs.gits.Count() + this.float_.index;
			}
		}

		/// <summary>
		/// 3 for 0.0001, and -3 for 13000.0
		/// </summary>
		public BigInteger scaleAftDot
		{
			get
			{
				return significandInRadix.abs.gits.Count() - dotPosition;
			}
		}

		public nilnul.num.integer_.Radix significandInRadix
		{
			get
			{
				return nilnul.num.integer_.Radix.Create(significand, this.base_.radic);
			}
		}

		public StringBuilder toTxt_noSign_dotInserted_noZeroPrepend()
		{

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

			if (sb.First() == DOT)
			{
				sb.Prepend("0");

			}

			if (sb.Last() == DOT)
			{
				sb.RemoveLast();
			}

			#endregion

			#region sign it

			return sb.Prepend(sign < 0 ? "-" : "").ToString();

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
	Radix1 x
)
		{

			return (x.significand) * nilnul.num.quotient.op_.unary_._IndexX.RetQuotient(x._base.rootAsBigint, x.index)
			;


		}
		static public implicit operator Quotient1(Radix1 x)
		{
			return (x.significand) * nilnul.num.quotient.op_.unary_._IndexX.RetQuotient(x._base.rootAsBigint, x.index)
						;
		}


		public Q1 toQ(

)
		{

			return (significand) * nilnul.num.quotient.op_.unary_._IndexX.RetQuotient(_base.rootAsBigint, index)
			;


		}
		public quotient_.DenomNonnil toDenomNonnil(

)
		{

			return (significand) * nilnul.num.quotient.of_.unary_._IndicX.DenomNonnil(_base.rootAsBigint, index)
			;


		}


		public Rational_InheritFraction2 toRational(
		)
		{

			return (significand) * nilnul.num.rational.op.PowX.Eval_basePlural2(_base.rootAsBigint, index)
			;


		}


		static public Radix1 FroQ(BigInteger radix_plural, nilnul.num.quotient.Q rational, BigInteger digits_natural)
		{

			return FroRational(radix_plural, rational, new Natural_bigInteger(digits_natural));
		}


		static public Radix1 FroRational(
			BigInteger radix_plural,
			Rational_InheritFraction _rational_positive
			,
			natural.Natural_bigInteger digits
		)
		{
			var intFrac = _rational_positive.ToIntAndProper();

			BigInteger quotient = intFrac.Item1;
			BigInteger remainder = intFrac.Item2.numerator;

			BigInteger index = 0;

			while (digits > 0)
			{
				quotient = quotient * radix_plural + BigInteger.DivRem(remainder * radix_plural, _rational_positive.denominatorAsBigInt, out remainder);
				digits--;
				index--;
			}
			return new Radix1(radix_plural, quotient, index);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="radix_plural"></param>
		/// <param name="_rational_positive"></param>
		/// <param name="digits">how many digits following the dot</param>
		/// <returns></returns>

		static public Radix1 FroRational(
			BigInteger radix_plural,
			Rational_InheritFraction2 _rational_positive
			,
			natural.Natural_bigInteger digits
		)
		{

			var intFrac = _rational_positive.ToIntAndProper();

			BigInteger quotient = intFrac.Item1;
			BigInteger remainder = intFrac.Item2.numerator;

			BigInteger index = 0;

			while (digits > 0)
			{

				quotient = quotient * radix_plural + BigInteger.DivRem(remainder * radix_plural, _rational_positive.denominatorAsBigInt, out remainder);
				digits--;
				index--;

			}
			return new Radix1(radix_plural, quotient, index);
		}
		static public Radix1 _FroQuotient(
			BigInteger _root_plural,
			Q1 _rational_positive
			,
			BigInteger _digitsAftDot_natural
		)
		{

			var intFrac = nilnul.num.quotient_.FlooredX.ToFloored(_rational_positive); ;

			BigInteger quotient = intFrac.floor;
			BigInteger remainder = intFrac.proper.en.numerator;

			BigInteger index = 0;

			while (_digitsAftDot_natural > 0)
			{
				quotient = quotient * _root_plural + BigInteger.DivRem(remainder * _root_plural, _rational_positive.denominator.val, out remainder);
				_digitsAftDot_natural--;
				index--;
			}
			return new Radix1(_root_plural, quotient, index);
		}

		static public Radix1 _OvQuotientNonneg(
			BigInteger _root_plural,
			Q1 _nonneg
			,
			BigInteger _digitsAftDot_natural
		)
		{

			var intFrac = nilnul.num.quotient_.FlooredX.ToFloored(_nonneg); ;

			BigInteger significant = intFrac.floor;
			BigInteger remainder = intFrac.proper.en.numerator;

			BigInteger index = 0;

			while (remainder != 0)
			{
				if (_digitsAftDot_natural == 0)
				{
					break;
				}
				significant = significant * _root_plural + BigInteger.DivRem(remainder * _root_plural, _nonneg.denominator.val, out remainder);
				index--;
				_digitsAftDot_natural--;
			}
			return new Radix1(_root_plural, significant, index);

		}

		static public Radix1 _OvQuotient(
			BigInteger _root_plural,
			Q1 quotient
			,
			BigInteger _digitsAftDot_natural
		)
		{
			if (quotient < 0)
			{
				return _OvQuotientNonneg(_root_plural, -quotient, _digitsAftDot_natural);
			}
			return _OvQuotientNonneg(_root_plural, quotient, _digitsAftDot_natural);
		}

		static public Radix1 _OvQuotientNonneg_throwIfResidue(
			BigInteger _root_plural,
			Q1 _nonneg
			,
			BigInteger _digitsAftDot_natural
		)
		{
			var intFrac = nilnul.num.quotient_.FlooredX.ToFloored(_nonneg); ;

			BigInteger significant = intFrac.floor;
			BigInteger remainder = intFrac.proper.en.numerator;

			BigInteger index = 0;

			while (remainder != 0)
			{
				significant = significant * _root_plural + BigInteger.DivRem(remainder * _root_plural, _nonneg.denominator.val, out remainder);
				index--;
				if (_digitsAftDot_natural == 0)
				{
					throw new _radix.xpn_.OverlongException();
				}
				_digitsAftDot_natural--;
			}
			return new Radix1(_root_plural, significant, index);
		}

		static public Radix1 _OvQuotient_throwIfResidue(
			BigInteger _root_plural,
			Q1 quotient
			,
			BigInteger _digitsAftDot_natural
		)
		{
			if (quotient < 0)
			{
				return _OvQuotientNonneg_throwIfResidue(_root_plural, -quotient, _digitsAftDot_natural);
			}
			return _OvQuotientNonneg_throwIfResidue(_root_plural, quotient, _digitsAftDot_natural);
		}


		static public Radix1 _FroQuotient(
			BigInteger root_plural,
			nilnul.num.quotient.Q _rational_positive
			,
			BigInteger digitsAftDot_natural
		)
		{
			var intFrac = nilnul.num.quotient.FlooredX.ToFloored(_rational_positive); ;

			BigInteger quotient = intFrac.floor;
			BigInteger remainder = intFrac.tail.val.numerator;

			BigInteger index = 0;

			while (digitsAftDot_natural > 0)
			{
				quotient = quotient * root_plural + BigInteger.DivRem(remainder * root_plural, _rational_positive.denominator.val, out remainder);
				digitsAftDot_natural--;
				index--;

			}
			return new Radix1(root_plural, quotient, index);
		}

		static public Radix1 _FroQ(
			BigInteger root_plural,
			_quotient.fraction.op.Simplify.Ed1 _rational_positive
			,
			BigInteger digitsAftDot_natural
		)
		{

			var intFrac = nilnul.num.quotient.FlooredX.ToFloored(_rational_positive); ;

			BigInteger quotient = intFrac.floor;
			BigInteger remainder = intFrac.tail.val.numerator;

			BigInteger index = 0;

			while (digitsAftDot_natural > 0)
			{
				quotient = quotient * root_plural + BigInteger.DivRem(remainder * root_plural, _rational_positive.denominator.val, out remainder);
				digitsAftDot_natural--;
				index--;
			}
			return new Radix1(root_plural, quotient, index);
		}


		static public Radix1 FroRational(BigInteger radix_plural, Rational_InheritFraction2 _rational_positive, BigInteger digits_natural)
		{

			return FroRational(radix_plural, _rational_positive, new Natural_bigInteger(digits_natural));
		}






		static public Radix1 Multi(
				BigInteger radix_plural,
				rational.Float significandIndex1
				,
				SignificandIndex significandIndex2



				)
		{
			return new Radix1(radix_plural, significandIndex1.significand * significandIndex2.significand, significandIndex1.index + significandIndex2.index);


			throw new NotImplementedException();
		}

		static public Radix1 Square(Radix1 a

		)
		{
			return new Radix1(a._base.rootAsBigint, a.significand * a.significand, a.index + a.index);// Multi(a.baseAsBigInt, a._significandIndex, a.significandIndex);
		}

		public Radix1 toSquare()
		{
			return Square(this);
		}

		public void negate()
		{
			this.significand = -this.significand;

		}
		public Radix1 toNegate()
		{
			var r = new Radix1(this);
			r.negate();
			return r;
		}

		static public Radix1 Negate(
		   Radix1 a
			)
		{

			var b = new Radix1(a);
			b.negate();
			return b;


		}

		static public Radix1 _Subtract(
			BigInteger radix_plural,
			SignificandIndex a,

			SignificandIndex b

			)
		{

			return _Add(radix_plural, a, b.toNegate());



		}
		static public Radix1 Subtract(
			BigInteger radix_plural,
			SignificandIndex a,

			SignificandIndex b

			)
		{

			return _Add(radix_plural, a, b.toNegate());



		}

		static public Radix1 _Add(

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

		static public Radix1 _Add_smallerFirst(BigInteger radix_plural, SignificandIndex _powerSmaller, SignificandIndex powerMax)
		{


			var t = powerMax.index - _powerSmaller.index;

			return new Radix1(
				radix_plural
				,

				powerMax.significand * nilnul.num.natural.op.PowX2.Do_basePlural_indexNonNeg(radix_plural, t) + _powerSmaller.significand
				,
				_powerSmaller.index

			);

			//throw new NotImplementedException();

		}
	}
}