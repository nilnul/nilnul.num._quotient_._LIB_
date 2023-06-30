using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix_
{

	public class FloatyOfMantissa
		:
		quotient_.nonneg_.radix_.FloatyI 
	//,
	//nilnul.num_._radix

	{
		public const char POINT = '.';

		/// <summary>
		/// little1st
		/// </summary>
		private nilnul.num_.RadixI _gits;

		public nilnul.num_.RadixI precision
		{
			get { return _gits; }
			//set { _gits = value; }
		}

		public nilnul.num_.ref_.vowless_.Plural radic
		{
			get
			{
				return num_.ref_.vowless_.Plural.Of(_gits.radic.eeByRef);
			}
		}

		/// <summary>
		/// the indic negated; not indic, but the negation of indic;
		/// </summary>
		private nilnul.Num_ofIn _mantissa;

		/// <summary>
		/// eg:
		///		123.45 reversed to be a little endian
		///			the position is 2, that means since position 2, the gits are mantissa
		///		0012300
		///			the position is 0
		/// </summary>
		public nilnul.Num_ofIn mantissa
		{
			get { return _mantissa; }
			//set { _mantissa = value; }
		}


		public BigInteger indic => -_mantissa.eeByRef;

		public DenomNonnil toQuotient()
		{
			var integer = this.precision.toBigint();
			return new DenomNonnil(
				integer
				,
				nilnul.num.op_.binary_._PowX._Op_basePlural_indexNonNeg(
					_gits.radic.eeByRef, _mantissa
				)
			);
		}


		public FloatyOfMantissa(nilnul.num_.RadixI gits, nilnul.Num_ofIn mantissa)
		{
			nilnul.bit.vow_.True1.Vow(
				mantissa <= gits.gits.Count()
				,
				$"{mantissa} cannot exceed {gits}.Count;"
			);

			this._gits = gits;
			this._mantissa = mantissa;

		}

		public FloatyOfMantissa(num_.RadixI radix, BigInteger bigInteger) : this(
			radix,
			 Num_ofIn.Of(

			bigInteger
				)
		)
		{
		}

		public FloatyOfMantissa((num_.RadixI, BigInteger) value) : this(value.Item1, value.Item2)
		{
		}

		public FloatyOfMantissa(
			BigInteger radic, List<BigInteger> gits, BigInteger indic
		):this(
			new num_.Radix2(radic,gits)
			,
			indic
		)
		{
		}

		public override string ToString()
		{

			return floaty._PhraseX.Phrase(this);
		}

	


	

	}
}
