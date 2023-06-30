using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_
{
	/// <summary>
	/// significed indiced;
	/// allow negative indicand;
	/// eg:
	///		01230 * 10^-2 = 012.30
	///		01230 * 10^2 = 0123000
	/// </summary>
	///
	[Obsolete(nameof(nonneg_.Radix))]
	public class Radix3
		:
		RadixI
		,
		Radix8unsignedI

	{
		private nilnul.num.integer_.Radix _gits;

		/// <summary>
		/// where signific can be retrieved, and radic can be retrieved;
		/// </summary>
		public nilnul.num.integer_.Radix signific
		{
			get { return _gits; }
			//set { _gits = value; }
		}


		//public num_.Plural radic { get { return new _gits.abs.radic.eeByRef; } }

		public BigInteger radic8integer { get { return _gits.abs.radic.eeByRef; } }


		private BigInteger _indic;

		/// <summary>
		/// eg:
		///		123.45 reversed to be a little endian
		///			the position is 2, that means since position 2, the gits are mantissa
		///		0012300
		///			the position is 0
		/// </summary>
		public BigInteger indic
		{
			get { return _indic; }
			//set { _mantissa = value; }
		}

		public nonneg_.RadixI unsigned => new nonneg_.Radix(
			this.signific.abs
			,
			this._indic
		);

		public bool negated =>this.signific.negated;

		public DenomNonnil toQuotient() {
			//var integer = (BigInteger)this._gits;
			return _gits * nilnul.num.quotient.of_.unary_._IndicX.DenomNonnil(_gits.abs.radic, _indic);

			//return new DenomNonnil(
			//	integer
			//	,
			//	nilnul.num.op_.binary_._PowX._Op_basePlural_indexNonNeg(
			//		_gits.abs.root, _mantissa
			//	)
			//);
		}


		public Radix3(nilnul.num.integer_.Radix gits, BigInteger indic_)
		{
		

			this._gits = gits;
			this._indic = indic_;

		}

		public Radix3(nilnul.num.integer_.Radix gits, nilnul.Num_ofIn mantissa):this(gits,mantissa.eeByRef)
		{
			

		}

		public Radix3((integer_.Radix, BigInteger) value):this(value.Item1,value.Item2)
		{
		}
		public override string ToString()
		{
			return quotient_.radix._PhraseX.Phrase(this);
			//return $"{this.signific}*{this.signific.abs.radic}^{this._indic}";
		}

		public static Radix3 Of(RadixI radix1)
		{

			return radix1 is Radix3 r?r: new Radix3(
				radix1.signific
				,
				radix1.indic
			);
		}

	}
}
