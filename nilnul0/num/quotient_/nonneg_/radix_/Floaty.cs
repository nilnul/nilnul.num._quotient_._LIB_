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

	/// <summary>
	/// the input parameter of ctor is indic, which shall be nonpositive, and its abs would not exceed precision width;
	/// </summary>
	public class Floaty
		:
		quotient_.nonneg_.radix_.FloatyI 
	//,
	//nilnul.num_._radix

	{
		public const char POINT = '.';
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
				return _gits.radic;
				return num_.ref_.vowless_.Plural.Of(_gits.radic.eeByRef);
			}
		}

		/// <summary>
		/// </summary>
		private BigInteger _indic;

		/// <summary>
		/// the indic negated; not indic, but the negation of indic;
		/// eg:
		///		123.45 reversed to be a little endian
		///			the position is 2, that means since position 2, the gits are mantissa
		///		0012300
		///			the position is 0
		/// </summary>

		public nilnul.Num_ofIn mantissa
		{
			get { return Num_ofIn.Of(-_indic); }
			//set { _mantissa = value; }
		}


		public BigInteger indic => _indic;

		public DenomNonnil toQuotient()
		{
			var integer = this.precision.toBigint();
			return new DenomNonnil(
				integer
				,
				nilnul.num.op_.binary_._PowX._Op_basePlural_indexNonNeg(
					_gits.radic.eeByRef, -_indic
				)
			);
		}


		public Floaty(nilnul.num_.RadixI gits, nilnul.num.integer.be_.nonpos.vow.Ee mantissa)
		{
			_floaty.xpn_.Farleft.Vow(gits, mantissa);
			

			this._gits = gits;
			this._indic = mantissa;

		}

		public Floaty(num_.RadixI radix, BigInteger indic) : this(
			radix,
			 new integer.be_.nonpos.vow.Ee(

			indic
				)
		)
		{
		}

		public Floaty((num_.RadixI, BigInteger) value) : this(value.Item1, value.Item2)
		{
		}

		public Floaty(
			BigInteger radic, List<BigInteger> gits, BigInteger indic
		):this(
			new num_.Radix2(radic,gits)
			,
			indic
		)
		{
		}

		public Floaty(BigInteger v1, IEnumerable< BigInteger> bigIntegers, BigInteger v2)
			:
			this(
				new num_.Radix2(v1,bigIntegers),v2
			)
		{
		}

		public override string ToString()
		{

			return floaty._PhraseX.Phrase(this);
		}

		public  string phrase8noncollapse()
		{

			return floaty.phrase_._NoncollapseX.Phrase(this);
		}

	

	

	}
}
