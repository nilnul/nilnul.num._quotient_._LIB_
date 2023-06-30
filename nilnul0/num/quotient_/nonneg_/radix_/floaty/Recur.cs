using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty
{
	/// <inheritdoc cref="RecurI"/>
	public class Recur : RecurI
	{

		private nonneg_.radix_.Floaty _floaty;

		public nonneg_.RadixI radix
		{
			get { return _floaty; }
		}
		public nonneg_.radix_.Floaty floaty
		{
			get { return _floaty; }
			set { _floaty = value; }
		}

		private nilnul.Num_ofIn _cycle;

		public nilnul.Num_ofIn period
		{
			get { return _cycle; }
			set { _cycle = value; }
		}


		public num_.RadixI precision
		{
			get
			{

				return _floaty.precision;

			}
		}

		public BigInteger precision8integer
		{
			get
			{
				return _floaty.precision.toBigint();
			}
		}

		public BigInteger indic
		{
			get
			{
				return _floaty.indic;
			}
		}
		public int indic8int
		{
			get
			{
				return (int)_floaty.indic;
			}
		}







		public BigInteger cycle8integer
		{
			get { return _cycle.eeByRef; }
			set
			{
				this._cycle = Num_ofIn.Of(value);
			}
		}
		public int cycle8int
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
		/// alias:
		///		period starts with "p" in precision;

		public BigInteger period8integer()
		{
			return precision8integer
				%
				nilnul.num.natural.op.PowX2.Do_basePlural_indexNonNeg(_floaty.precision.radic, period)
			;
		}


		public Recur(Floaty radix, Num_ofIn cycle)
		{
			nonneg_.radix.recur_.xpn_.CycleGtPrecisionException.Vow(radix, cycle);

			this._floaty = radix;
			this._cycle = cycle;
		}
		public Recur(Floaty unsigned1, BigInteger cycle1)
			:this(
				 unsigned1, Num_ofIn.Of(cycle1)
			 )
		{
		}

		public Recur(
			RadixI radix, Num_ofIn _natural_recurSpan
		)
		: this(
			  radix_.floaty.of_._CoerceX.ToFloaty(radix)
			  ,
			_natural_recurSpan
		)
		{
		}
		public Recur(
			Radix radix, Num_ofIn _natural_recurSpan
		)
		: this(

			(RadixI)(radix)
			  ,
			_natural_recurSpan
		)
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


		public Recur((num_.Radix2 precison, BigInteger indic) floaty, Num_ofIn cycle)
			:this(
				 new Floaty(floaty),cycle
			)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="recur">must be a valid floaty recur;</param>
		public Recur(radix.Recur recur):this(recur.precision,recur.indic,recur.period)
		{
		}


		public override string ToString()
		{

			return nonneg_.radix_. floaty.recur._PhraseX.Phrase(this);

		}
		public  string phrase8noncollapse()
		{

			return nonneg_.radix_. floaty.recur.phrase_._PrecisionIntNonemptyX.Phrase(this);

		}

	}
}
