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

namespace nilnul.num.quotient_.nonneg_._radix.radic.indiced
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	///
	public class Amplified
	{

		public const char DOT = '.';

		private quotient_._radix.basic.Indiced _indiced;

		public quotient_._radix.basic.Indiced indiced
		{
			get { return _indiced; }
			set { _indiced = value; }
		}



		public nilnul.num_._radix.Root radic
		{
			get { return _indiced.base_; }
		}


		/// <summary>
		/// the root or base such as 10, 16, or 2.
		/// </summary>
		public BigInteger radicAsInteger
		{
			get { return _indiced.base_.rootAsBigint; }
			set { _indiced.base_.radic = new num_.Plural(value); }
		}


		private nilnul.Num_ofIn _precision;

		public nilnul.Num_ofIn precision
		{
			get { return _precision; }
			set { _precision = value; }
		}



		public BigInteger indic
		{
			get
			{
				return _indiced.indic;
			}

		}



		public int indicAsInt
		{
			get
			{
				return (int)_indiced.indic;
			}
			set
			{
				_indiced.indic = value;
			}
		}


		public Amplified(
			quotient_._radix.basic.Indiced
			 base_
			,
			nilnul.Num_ofIn float_

			)
		//: this(base_.val, float_.significand, float_.index)
		{
			this._indiced = base_;
			this.precision = float_;


		}

		public Amplified(
			quotient_._radix.basic.Indiced
			 base_
			,

			BigInteger float_
	)
			: this(base_, Num_ofIn.Of(float_))
		{


		}



		public Amplified(
			Amplified other
			)
			: this(other.indiced, other.precision)
		{

		}

		static public Amplified Of_0radic_1indic_2precision(
			BigInteger base_,
			BigInteger indic,
			BigInteger precision
			)

		{
			return new Amplified(
							  new quotient_._radix.basic.Indiced(base_, indic), precision
		);

		}
		/// <summary>
		/// no indic;
		/// </summary>
		/// <param name="radix"></param>
		/// <param name="precision"></param>
		/// <returns></returns>
		static public Amplified OfRadicPrecision(BigInteger radix, BigInteger precision)
		{
			return Amplified.Of_0radic_1indic_2precision(radix, 0, precision);

		}

		/// <summary>
		/// simplify this to the standard simplest form.
		/// </summary>
		public void reduce()
		{
			if (precision == 0)
			{
				this._indiced.indic = 0;
				return;

			}


			BigInteger remainder;
			var q = BigInteger.DivRem(precision, radicAsInteger, out remainder);

			while (remainder == 0)
			{
				this.precision = Num_ofIn.Of(q);
				this.indiced.indic++;

				q = BigInteger.DivRem(precision, radicAsInteger, out remainder);

			}
		}

		/// <summary>
		/// not change the value; so when incrementing precision, decrease the indic meanwhile;
		/// </summary>
		public void incrementPrecision()
		{
			precisionAsInteger = precision * radicAsInteger;
			this._indiced.indic--;
		}

		public void _incrementPrecision(int _natural_zeros)
		{
			while (_natural_zeros-- > 0)
			{
				incrementPrecision();
			}
		}






		public nilnul.num.natural.collection.Interval digits()
		{
			return new natural.collection.Interval(radicAsInteger);
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
		public void append2precision(BigInteger siginificandNewLastDigit)
		{

			assertIsDigit(siginificandNewLastDigit);

			precisionAsInteger = precisionAsInteger * radicAsInteger + siginificandNewLastDigit;

			_indiced.indic -= 1;

		}

		public Amplified toMorePresion(
			BigInteger siginificandNewLastDigit
		)
		{

			var r = new Amplified(this);

			r.append2precision(siginificandNewLastDigit);
			return r;

		}
		public Amplified toReduce()
		{
			var r = new Amplified(this);
			r.reduce();
			return r;
		}


		/// <summary>
		/// <see cref="num.quotient_.Radix2"/>
		/// </summary>
		/// <returns></returns>
		///
		public override string ToString()
		{

			return $"{precision}*{this._indiced}"; // as we included the base, there is no need to express each component in the base herein; To express the number in base, we can express it in such way as: 00123010.0310321000 
												   //return toTxt();
		}








		public BigInteger precisionAsInteger
		{
			get => this.precision;
			private set
			{
				_precision = Num_ofIn.Of(value);
			}
		}





		public quotient_.DenomNonnil toDenomNonnil(

)
		{
			return (precision) * indiced.toDenomNonnil();




		}






		static public Amplified Multi(
				BigInteger radix_plural,
				rational.Float significandIndex1
				,
				SignificandIndex significandIndex2



				)
		{
			return Amplified.Of_0radic_1indic_2precision(radix_plural
,
significandIndex1.index + significandIndex2.index
				,
significandIndex1.significand * significandIndex2.significand
			);


			throw new NotImplementedException();
		}

		static public Amplified Square(Amplified a

		)
		{
			return Amplified.Of_0radic_1indic_2precision(
				a.radicAsInteger
				,
				a.indic + a.indic
				,
				a.precisionAsInteger * a.precision
			);// Multi(a.baseAsBigInt, a._significandIndex, a.significandIndex);
		}

		public Amplified toSquare()
		{
			return Square(this);
		}





		static public Amplified _Add(

			BigInteger radix_plural,
			SignificandIndex a,
			SignificandIndex b
			)
		{

			if (b.index < a.index)
			{
				return _Add_smallerFirst(radix_plural, b, a);
			}
			return _Add_smallerFirst(radix_plural, a, b);



		}

		static public Amplified _Add_smallerFirst(BigInteger radix_plural, SignificandIndex _powerSmaller, SignificandIndex powerMax)
		{


			var t = powerMax.index - _powerSmaller.index;

			return Amplified.Of_0radic_1indic_2precision(
				radix_plural
				,
				_powerSmaller.index
				,

				powerMax.significand * nilnul.num.natural.op.PowX2.Do_basePlural_indexNonNeg(radix_plural, t) + _powerSmaller.significand

			);


		}
	}
}