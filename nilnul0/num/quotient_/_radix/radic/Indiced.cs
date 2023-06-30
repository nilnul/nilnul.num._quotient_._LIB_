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

namespace nilnul.num.quotient_._radix.basic
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	public class Indiced
	{

		//public const char DOT = '.';


		private nilnul.num_._radix.Root _base;

		public nilnul.num_._radix.Root base_
		{
			get { return _base; }
			set { _base = value; }
		}
		public nilnul.num_._radix.Root radic
		{
			get { return _base; }
			set { _base = value; }
		}

		public BigInteger radic8integer
		{
			get { return _base.rootAsBigint; }
			set { _base = new num_._radix.Root( new num_.Plural( value) ); }
		}

		/// <summary>
		/// the root or base such as 10, 16, or 2.
		/// </summary>
		public BigInteger baseAsBigInt
		{
			get { return _base.rootAsBigint; }
			set { _base.radic = new num_.Plural(value); }
		}



		private BigInteger _indic;

		public BigInteger indic
		{
			get { return _indic; }
			set { _indic = value; }
		}


	


		public int indicAsInt
		{
			get
			{
				return (int)_indic;
			}
			set
			{
				_indic = value;
			}
		}



		public Indiced(
			nilnul.num_._radix.Root base_
			,
			BigInteger float_

			)
		//: this(base_.val, float_.significand, float_.index)
		{
			this._base = base_;
			this._indic = float_;


		}

		public Indiced(
			BigInteger base_
			,
			BigInteger float_

	)
			: this(new nilnul.num_._radix.Root(new num_.Plural(base_)), float_)
		{


		}
		public Indiced(BigInteger radix)
			: this(radix, 0)
		{


		}
		public Indiced(natural.be.plural.bigint.Asserted base_)
			: this(base_.val)
		{

		}

		public Indiced()
			: this(2)
		{

		}


		public Indiced(
			Indiced other
			)
			: this(other.base_.rootAsBigint,  other._indic)
		{

		}
	



		public nilnul.num.natural.collection.Interval gitsAsInterval()
		{
			return new natural.collection.Interval(baseAsBigInt);
		}

		public void assertIsDigit(BigInteger digit)
		{

			AssertX.True(gitsAsInterval().contains(new Natural2(digit)));

		}




		public override string ToString()
		{
			return $"{this.baseAsBigInt}^{this._indic}"; 
		}

	
		public quotient_.DenomNonnil toDenomNonnil(
)
		{

			return  nilnul.num.quotient.of_.unary_._IndicX.DenomNonnil(_base.rootAsBigint, _indic)
			;


		}

	}
}