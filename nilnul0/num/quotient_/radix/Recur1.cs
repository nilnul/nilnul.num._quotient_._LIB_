using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;
using nilnul.num.quotient_.radix.to_;

namespace nilnul.num.quotient_.radix
{
	///
	/// <summary>
	/// eg:
	///		1.233333....
	///		123333.33333...... | 12333(3.but we generally only allow recurrence in mantissa part;
	///	implemented using signific;
	/// </summary>
	/// <remarks>recurring, cyclic, repeating, recurring...</remarks>
	///
	[Obsolete(nameof(recur_.ByNeg))]
	public class Recur1 : RecurI
		,
		Recur8unsignedI

	//: quotient._radix_.AmplifierI
	{

		private Radix3 _radix;

		public Radix3 radix
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


		public integer_.Radix significand
		{
			get
			{

				return _radix.signific;

			}
		}

		public BigInteger radixAsBigInt
		{
			get
			{
				return _radix.signific;
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



		public int sign8int
		{
			get
			{
				return _radix.signific.sign ? 1 : -1;
			}
		}

		public BigInteger amplitude8integer
		{
			get
			{
				return _radix.signific.abs.toBigint();
				//return BigInteger.Abs(significand);
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

		public Num_ofIn period {
			get  {
				return this.recurSpan;
			}
		}

		public bool negated => this.radix.negated;

		public nonneg_.radix.RecurI unsigned => new nonneg_.radix.Recur(
			this.radix.unsigned
			,
			this._cycle
		);




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

		public BigInteger cycleAsNum()
		{
			return significand
				%
				nilnul.num.natural.op.PowX2.Do_basePlural_indexNonNeg(_radix.radic8integer, recurSpan)
			;
		}

	
		public Recur1(Radix3 radix, Num_ofIn cycle)
		{
			num.quotient_.nonneg_.radix.recur_.xpn_.CycleGtPrecisionException.Vow(radix.signific.abs,cycle);

			this.radix = radix;
			this._cycle = cycle;

		}

		public Recur1(RadixI radix, Num_ofIn _natural_recurSpan)
			:this(Radix3.Of(radix), _natural_recurSpan)
		{
		}

		public Recur1(Radix3 radix, BigInteger _natural_recurSpan):this(
			radix, Num_ofIn.Of(_natural_recurSpan)
		)
		{
		}
		public Recur1(Radix3 radix, int cycle):this(
			radix, Num_ofIn.Of( cycle)
		)
		{
		}

		public Recur1(RadixI radix1, int cycle):this(
			quotient_.Radix3.Of(radix1),cycle
		)
		{
		}


		//public Recur1(Radix1 float_, Num1 recurSpan_natural):this(
		//	(float_.ToRadix3())
		//	,
		//	recurSpan_natural.en
		//)
		//{
		//}

		public Recur1(integer_.Radix signific, BigInteger indic, Num_ofIn cycle)
			:
			this(new Radix3(signific,indic),cycle)
		{
		}

		public Recur1(integer_.Radix item1, BigInteger item2, int cycle1)
			:
			this(
				item1
				,
				item2,
				Num_ofIn.Of(cycle1)
		)
		{
		}

		public override string ToString()
		{
			return quotient_.radix.recur._PhraseX.Phrase(this);
		}
	}
}
