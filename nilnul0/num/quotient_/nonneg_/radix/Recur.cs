using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;

namespace nilnul.num.quotient_.nonneg_.radix
{
	/// <summary>
	/// eg:
	///		12(33 * 10^-1
	///		12333(3*10^3
	/// </summary>
	/// <remarks>recurring, cyclic, repeating, recurring...</remarks>
	public class Recur : RecurI



	//: quotient._radix_.AmplifierI
	{

		private nonneg_.Radix _radix;

		public nonneg_.RadixI radix
		{
			get { return _radix; }
		}
		public nonneg_.Radix radixAsImpl
		{
			get { return _radix; }
			set { _radix = value; }
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
		[Obsolete()]
		public int recurSpanAsInt
		{
			get { return (int)_cycle.eeByRef; }
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


		public Recur(Radix radix, Num_ofIn cycle)
		{
			if (cycle.eeByRef > radix.precision.gits.Count())
			{
				throw new recur_.xpn_.CycleGtPrecisionException(
					$"cycle:{cycle} would exceed the precision of {radix};"
				);
			}
			this._radix = radix;
			this._cycle = cycle;

		}

		public Recur(RadixI radix, Num_ofIn _natural_recurSpan)
			: this(Radix.Of(radix), _natural_recurSpan)
		{
		}


		public Recur(Radix radix, BigInteger _natural_recurSpan) : this(
			radix, Num_ofIn.Of(_natural_recurSpan)
		)
		{
		}
		public Recur(Radix radix, int cycle) : this(
			radix, Num_ofIn.Of(cycle)
		)
		{
		}

		public Recur(RadixI radix1, int cycle) : this(
			Radix.Of(radix1), cycle
		)
		{
		}

		public Recur(RadixI radix1, BigInteger cycle) : this(
			Radix.Of(radix1), cycle
		)
		{
		}

		public Recur(Radix float_, Num1 recurSpan_natural) : this(
			(float_), recurSpan_natural.en
		)
		{
		}

		public Recur(num_.RadixI signific, BigInteger indic, Num_ofIn cycle)
			:
			this(new Radix(signific, indic), cycle)
		{
		}

		public Recur(num_.RadixI item1, BigInteger item2, int cycle1)
			:
			this(
				item1
				,
				item2,
				Num_ofIn.Of(cycle1)
		)
		{
		}

		public Recur(BigInteger radix_plural, List<BigInteger> gits, BigInteger indic1, BigInteger bigInteger)
			: this(
				  Radix.Of_0radic_1gits_2indic(radix_plural, gits, indic1)
				 ,
				 bigInteger
			)
		{
		}

		public Recur(BigInteger radix_plural, IEnumerable<BigInteger> gits, BigInteger indic1, BigInteger bigInteger)
			: this(
				  Radix.Of_0radic_1gits_2indic(radix_plural, gits, indic1)
				 ,
				 bigInteger
			)
		{
		}

		public Recur(
			(num_.Radix2, BigInteger) t
			,
			Num_ofIn cycle
		)
			: this(new Radix(t), cycle)
		{
		}

		public Recur(num_.Radix2 radix2, BigInteger indic1, BigInteger period1)
			:
		this(
			new Radix(radix2,indic1)
			,period1
		)
		{
		}

		public Recur((num_.RadixI, BigInteger) radix, Num_ofIn period)
			: this(new Radix(radix), period)

		{
		}

		public int cycleAsInt { get { return (int)period.eeByRef; } }

		public override string ToString()
		{
			return nonneg_.radix.recur._PhraseX.Phrase(this);

			var precisionTxt = nilnul.num_.radix._phrase._Insignificant1stX.Phrase(this.precision);

			//if (this.cycle != 0)
			//{
			//	precisionTxt = precisionTxt.Insert(this.cycleAsInt, "("); // success ensured by vow in ctor;
			//}
			precisionTxt = precisionTxt.Insert(this.cycleAsInt, "(");
			precisionTxt = precisionTxt.TrimStart();

			/// we cannot always express this in pointed format; to present this in pointed format, convert this to <see cref="radix_.floaty.RecurI"/>
			return $"{string.Join("", precisionTxt.Reverse())}*{this._radix.precision.radic}^{_radix.indic}";
		}
		static public Recur Of(RecurI recur)
		{
			return recur is Recur r ? r : new Recur(
				recur.radix, recur.period
			);
		}
	}
}
