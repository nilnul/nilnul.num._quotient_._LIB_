using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nilnul.num.quotient_.nonneg_
{
	public class Radix : RadixI
	{
		/// <summary>
		/// light1st, not heavy1st;
		/// </summary>
		private nilnul.num_.RadixI _precision;

		public nilnul.num_.RadixI precision
		{
			get { return _precision; }
			set { _precision = value; }
		}

		private BigInteger _indic;

		public BigInteger indic
		{
			get { return _indic; }
			set { _indic = value; }
		}

		public Radix(
			nilnul.num_.RadixI precision
			, BigInteger indic
		)
		{
			this._precision = precision;
			this._indic = indic;

		}

		public Radix((num_.Radix2, BigInteger) t) : this(t.Item1, t.Item2)
		{
		}
		public Radix((num_.RadixI, BigInteger) radix) : this(radix.Item1, radix.Item2)
		{
		}

		public Radix(BigInteger radix_plural, IEnumerable<BigInteger> gitsAftDot, BigInteger indic)
			: this(
				 new nilnul.num_.Radix2(radix_plural, gitsAftDot)
				 , indic
			)
		{
		}


		public num.Quotient1 toQuotient()
		{
			return nilnul.num.quotient.op_.binary_.Multi1.Singleton.op(
				_precision.toBigint()
				,
				quotient.op_.unary_._IndexX.RetQuotient(_precision.radic.eeByRef, _indic)
			)
			;
		}

		public num.quotient_.denomNonnil_.Nonneg toNonnegQuotient()
		{
			return new denomNonnil_.Nonneg(
				denomNonnil._RegressionsX.ToDenomNonnil(
					toQuotient()
				)
			);
		}

		public override string ToString()
		{
			/// we have no enough information to present this <see cref="radix_.IFloaty"/>:
			/// 1) the <see cref="num_._radix.IRadic"/> of precision and indic might be not the same; note the indic is radic neutral;
			/// 2) the indic might be not little or big enough such that we can insert the floating point; that is, the floating point might be out of precision;
			/// To present this as dotted floaty, use <see cref="radix_.IFloaty"/>
			///
			return $"{this._precision}*{
				this._precision.radic	//this is intentionaly left to use default radic, as in eg: 010011(2), where 2 is in decimal, used for binary
				}^{
				nilnul.num.integer_.radix_.byNeg.of_._OfIntegerX.Of(
					new num_.Plural(
						this._precision.radic
					)
					,
					this._indic
				)
			}";

			//return _radix.radic.indiced.amplified._PhraseX._Phrase_nonneg0amplific_plural1radic_2indic(
			//	_precision.ToString() //.toBigint()
			//	,
			//	_precision.radic
			//	,
			//	_indic
			//);
		}

		public static Radix Of_0radic_1gits_2indic(BigInteger radix_plural, IEnumerable<BigInteger> gitsAftDot, BigInteger indic)
		{
			return new Radix(
				new num_.Radix2(
					radix_plural
					,
					gitsAftDot.Select(
						x => new Num1(x)
					)
				)
				,
				indic
			);
		}

		public static Radix Of(RadixI radix)
		{
			return radix is Radix x ? x : new Radix(
				radix.precision, radix.indic
			);
		}
	}
}
