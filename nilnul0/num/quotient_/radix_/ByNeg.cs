using nilnul.num.integer_;
using nilnul.num.quotient_.nonneg_.radix.to_;
using nilnul.num.quotient_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix_
{
	/// <summary>
	/// allow negative indicand;
	/// eg:
	///		01230 * 10^-2 = 012.30;
	///		01230 * 10^2 = 0123000;
	/// </summary>
	/// alias:
	///		BySign9nonneg
	public class ByNeg
		:
		RadixI
		,
		Radix8unsignedI

	{
		private nilnul.num.quotient_.nonneg_.RadixI _unsigned;

		/// <summary>
		/// where precision can be retrieved, and radic can be retrieved;
		/// </summary>
		public nilnul.num.quotient_.nonneg_.RadixI unsigned
		{
			get { return _unsigned; }
			//set { _gits = value; }
		}


		public num_.ref_.vowless_.Plural radic { get { return _unsigned.precision.radic; } }

		public BigInteger radic8integer { get { return radic.eeByRef; } }


		/// <summary>
		/// is there an minus sign at the beginning?
		/// </summary>
		private bool _negated;

		public bool negated
		{
			get { return _negated; }
			set { _negated = value; }
		}
		public bool sign
		{
			get { return !_negated; }

			[Obsolete(nameof(_negated))]
			set { _negated = !value; }
		}

		/// <summary>
		/// eg:
		///		123.45 reversed to be a little endian
		///			the position is 2, that means since position 2, the gits are mantissa
		///		0012300
		///			the position is 0
		/// </summary>
		public BigInteger indic
		{
			get { return unsigned.indic; }
			//set { _mantissa = value; }
		}

		public integer_.Radix signific => new integer_.Radix(
			new num_.Radix1(
				new num_.Plural(
				this.unsigned.precision.radic
				)
				,
				new str_.List(
					this.unsigned.precision.gits.Select(x => new Num1(x.eeByRef))
				)
			)
			,
			this.sign
		);

		public DenomNonnil toDenomNonnil()
		{
			var q = unsigned.ToDenomNonnil();

			return negated ? -q : q;

		}

		public ByNeg(nilnul.num.quotient_.nonneg_.RadixI unsigned, bool negated=false)
		{
			this._negated = negated;
			this._unsigned = unsigned;

		}

		static public ByNeg OfAsNeg(nilnul.num.quotient_.nonneg_.RadixI unsigned)
		{
			return new ByNeg(unsigned, true);

		}

		public ByNeg(nilnul.num.quotient_.nonneg_.Radix unsigned, bool negated=false)
			:
			this(
				(nilnul.num.quotient_.nonneg_.RadixI)unsigned
				,
				negated
			)
		{
		}

		public ByNeg(nilnul.num_.RadixI gits, BigInteger indic, bool negated)
			: this(
new quotient_.nonneg_.Radix(gits, indic)
				 ,
negated
		)
		{
		}

	
		public ByNeg(nilnul.num.integer_.Radix gits, BigInteger indic)

			: this(
				  new num_.Radix2(
					gits.abs.radic.eeByRef
					,
					gits.abs.gits.Select(x=>x.eeByRef)
				  )
				  ,
				 indic

				  ,
				 !gits.sign
			)
		{
		}

		public ByNeg(nilnul.num.integer_.Radix gits, nilnul.Num_ofIn mantissa) : this(gits, mantissa.eeByRef)
		{


		}

		public ByNeg((integer_.Radix, BigInteger) value) : this(value.Item1, value.Item2)
		{
		}

		public override string ToString()
		{
			return $"{(this._negated?"-":"")}{this._unsigned}";
		}


		public static ByNeg Of(RadixI radix1)
		{

			return radix1 is ByNeg r ? r : new ByNeg(
				radix1.signific
				,
				radix1.indic
			);
		}
	


	}
}
