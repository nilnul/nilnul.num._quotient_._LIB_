using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix_
{

	public class IndicNonpos
		:
		RadixI
	//,
	//nilnul.num_._radix

	{
		private nilnul.num.integer_.Radix _gits;

		public nilnul.num.integer_.Radix gits
		{
			get { return _gits; }
			//set { _gits = value; }
		}

		public nilnul.num_.ref_.vowless_.Plural radic
		{
			get
			{
				return num_.ref_.vowless_.Plural.Of(_gits.abs.radic.eeByRef);
			}
		}

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

		public integer_.Radix signific => _gits;

		public BigInteger indic => -_mantissa.eeByRef;

		public DenomNonnil toQuotient()
		{
			var integer = (BigInteger)this._gits;
			return new DenomNonnil(
				integer
				,
				nilnul.num.op_.binary_._PowX._Op_basePlural_indexNonNeg(
					_gits.abs.radic.eeByRef, _mantissa
				)
			);
		}


		public IndicNonpos(nilnul.num.integer_.Radix gits, nilnul.Num_ofIn mantissa)
		{
			nilnul.bit.vow_.True1.Vow(
				mantissa <= gits.abs.gits.Count()
				,
				$"{mantissa} cannot exceed {gits}.Count;"
			);

			this._gits = gits;
			this._mantissa = mantissa;

		}

		public IndicNonpos(integer_.Radix radix, BigInteger bigInteger) : this(
			radix,
			 Num_ofIn.Of(

			bigInteger
				)
		)
		{
		}

		public IndicNonpos((integer_.Radix, BigInteger) value) : this(value.Item1, value.Item2)
		{
		}

		public override string ToString()
		{
			return indicNonpos.phrase_._NonemptyBeforeDotX.Phrase(this);
		}

		static public IndicNonpos Of(
			ByNeg indicPosible
		)
		{
			return Of((RadixI)indicPosible);
		}
		public static IndicNonpos Of(Radix1 radix)
		{
			return Of(ByNeg.Of(radix) );
		}
		public static IndicNonpos Of(RadixI indicPosible)
		{
			if (indicPosible.indic > 0)
			{
				return new IndicNonpos(
					new integer_.Radix(
						new nilnul.num_.Radix1(
							indicPosible.signific.abs.root
							,
							new str_.List(
								indicPosible.signific.abs.gits.Concat(
									Enumerable.Repeat(0, (int)indicPosible.indic).Select(i => new Num1(i))
								)
							)
						)
						,
						indicPosible.signific.sign
					)
					, 0
				);
			}
			return new IndicNonpos(
				indicPosible.signific



				, Num_ofIn.Of(-indicPosible.indic)
			);
		}

	}
}
