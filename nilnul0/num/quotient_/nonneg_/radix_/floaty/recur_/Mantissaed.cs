using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur_
{
	/// <summary>
	/// the cycle is in the mantissa;
	/// eg:
	///		the cycle is nil; no cycle;
	///		
	///		01230._04560
	///		01230.0(4560
	///		01230.0456(0
	///			which can be simplied to 01230.0456(
	///		
	/// </summary>
	/// alias:
	///		proper
	///		properly
	///			distinguish with a popular word:proper;
	///		mantissaed
	///			distinguish with a popular word:，<see cref="quotient_.IProper"/>;
	///		
	public class Mantissaed:MantissaedI
	{

		private nonneg_.radix_.Floaty _radix;

		public nonneg_.radix_.Floaty floaty
		{
			get { return _radix; }
			set { _radix = value; }
		}

		public nonneg_.RadixI radix
		{
			get { return _radix; }
		}

		private nilnul.Num_ofIn _cycle;
		public nilnul.Num_ofIn recurSpan
		{
			get { return _cycle; }
			set { _cycle = value; }
		}
		public nilnul.Num_ofIn period
		{
			get { return _cycle; }
			set { _cycle = value; }
		}


		public num_.RadixI precision
		{
			get
			{

				return _radix.precision;

			}
		}

		public BigInteger precisionAsBigInt
		{
			get
			{
				return _radix.precision.toBigint();
			}
		}

		public BigInteger indic
		{
			get
			{
				return _radix.indic;
			}
		}
		public int indexAsInt
		{
			get
			{
				return (int)_radix.indic;
			}
		}







		public BigInteger recurSpanAsInteger
		{
			get { return _cycle.eeByRef; }
			set
			{
				this._cycle = Num_ofIn.Of(value);
			}
		}
	






		/// <summary>
		/// return the string of digits inside the recuring scope.
		/// </summary>
		/// <returns>
		///		
		/// </returns>
		/// <example>
		///  12345123.(45123)  here 45123 as an integer is the returned.
		/// for:
		///		1234*10^5, recur:3  --> 1234_234_23.4 , where the returned is 1234 % 10^3 =234;
		/// </example>
		/// <remarks>
		/// 0.0080808080.
		/// 		应写成0.00(80)，在最后的80上打点。
		/// 		不可以: 写作0.0(08)，在最后的08上打点。
		/// </remarks>

		public BigInteger recurPart()
		{
			return precisionAsBigInt
				%
				nilnul.num.natural.op.PowX2.Do_basePlural_indexNonNeg(_radix.precision.radic, recurSpan)
			;
		}


		public Mantissaed(Floaty radix, Num_ofIn cycle)
		{
			nonneg_.radix_.floaty.recur_.mantissaed_.xpn_.CycleImproperException.Vow(radix, cycle);

			this._radix = radix;
			this._cycle = cycle;
		}

		public Mantissaed(
			RadixI radix, Num_ofIn _natural_recurSpan
		)
		: this(
			  radix_.floaty.of_._CoerceX.ToFloaty(radix)
			  ,
			_natural_recurSpan
		)
		{
		}
		public Mantissaed(
			Radix radix, Num_ofIn _natural_recurSpan
		)
		: this(
			radix_.floaty.of_._CoerceX.ToFloaty(radix)
			  ,
			_natural_recurSpan
		)
		{
		}

		public Mantissaed(Radix radix, BigInteger _natural_recurSpan) : this(
			radix, Num_ofIn.Of(_natural_recurSpan)
		)
		{
		}
		public Mantissaed(Radix radix, int cycle) : this(
			radix, Num_ofIn.Of(cycle)
		)
		{
		}

		public Mantissaed(RadixI radix1, int cycle) : this(
			Radix.Of(radix1), cycle
		)
		{
		}


		public Mantissaed(Radix float_, Num1 recurSpan_natural) : this(
			(float_), recurSpan_natural.en
		)
		{
		}

		public Mantissaed(num_.RadixI signific, BigInteger indic, Num_ofIn cycle)
			:
			this(new Radix(signific, indic), cycle)
		{
		}

		public Mantissaed(num_.RadixI item1, BigInteger item2, int cycle1)
			:
			this(
				item1
				,
				item2,
				Num_ofIn.Of(cycle1)
		)
		{
		}

		public Mantissaed(BigInteger radix_plural, List<BigInteger> gits, BigInteger indic1, BigInteger bigInteger)
			: this(
				  Radix.Of_0radic_1gits_2indic(radix_plural, gits, indic1)
				 ,
				 bigInteger
			)
		{
		}
		public Mantissaed(BigInteger radix_plural, IEnumerable<BigInteger> gits, BigInteger indic1, BigInteger bigInteger)
			: this(
				  Radix.Of_0radic_1gits_2indic(radix_plural, gits, indic1)
				 ,
				 bigInteger
			)
		{
		}

		public Mantissaed((num_.Radix2 precison, BigInteger indic) t, Num_ofIn cycle)
			:this(
				 new Floaty(t),cycle
			 )
		{
		}

		public int cycleAsInt { get { return (int)period.eeByRef; } }

		public override string ToString()
		{
			
			return recur_.mantissaed._PhraseX.Phrase(this);

		}

		public  string phrase8decollapse()
		{
			
			return recur_.mantissaed.phrase_._PrecisionIntNonemptyX.Phrase(this);

		}
	}
}
