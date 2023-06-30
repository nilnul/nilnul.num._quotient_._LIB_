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

	//[Obsolete(nameof(radix_.IndicNonpos))]
	[Obsolete(nameof(radix_.INonfarright))]

	public class Radix2
		//:
		//quotient_.DenomNonnilI

	{
		private nilnul.num.integer_.Radix _gits;

		public nilnul.num.integer_.Radix gits
		{
			get { return _gits; }
			//set { _gits = value; }
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

		public DenomNonnil toQuotient() {
			var integer = (BigInteger)this._gits;
			return new DenomNonnil(
				integer
				,
				nilnul.num.op_.binary_._PowX._Op_basePlural_indexNonNeg(
					_gits.abs.radic, _mantissa
				)
			);
		}


		public Radix2(nilnul.num.integer_.Radix gits, nilnul.Num_ofIn mantissa)
		{
			nilnul.bit.vow_.True1.Vow(
				mantissa <= gits.abs.gits.Count()
				,
				$"{mantissa} cannot exceed {gits}.Count;"
			);

			this._gits = gits;
			this._mantissa = mantissa;

		}

	

		public IEnumerable<char> __chars(
			char[] _chars
		)
		{
			if (!this._gits.sign)
			{
				yield return '-';
			}
			var enumerator = this._gits.abs.gits.Select(x => _chars[(int)(x.eeByRef)]).GetEnumerator();

			for (int i = 0; i < this._mantissa.eeByRef; i++)
			{
				enumerator.MoveNext();
				yield return enumerator.Current;

			}
			yield return '.';

			while (enumerator.MoveNext())
			{
				yield return enumerator.Current;
			}
		}

		public string _phrase_assumeValid(
			char[] _chars
		)
		{
			return string.Join("", __chars(_chars).Reverse()).TrimEnd('.');
		}

		public static Radix2 Of(Radix1 radix)
		{
			//radix.toMorePresion
			var signify = radix.significand;
			var indic = radix.indicand;
			if (indic > 0)
			{
				signify *= nilnul.num.op_.binary_._PowX._Op_basePlural_indexPositive(
					radix.baseAsBigInt, indic
				);
				indic = 0;
			}

			return new Radix2(
				 integer_.Radix.Create(signify,/*new num_.Plural*/(radix.base_.radic))
				 ,
				  Num_ofIn.Of(-indic)
			);
		}
	}
}
