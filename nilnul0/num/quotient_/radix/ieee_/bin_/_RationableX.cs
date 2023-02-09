using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.ieee_.bin_
{
	/*
> BitConverter.GetBytes(0d)
byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 }
> BitConverter.GetBytes(-0d)
byte[8] { 0, 0, 0, 0, 0, 0, 0, 128 }
 	 
	 */
	/*
	 if
		ponent is 0
			then
				if mantissa is 0
					then signed nil
				else
					subnormal numbers
		if ponent is all ones
			then
				if mantissa is 0
					it's infinity
				else
					NaN
	 */
	/// <summary>
	/// note: dbl includes some abnormal numbers such as infinity, NaN, negNil. We donot consider abnormal numbers here. We only consider normal number;
	/// </summary>
	/// <remarks>
	/// to make this a quotient, the indicand 
	/// </remarks>
	///

	static public class _RationableX
		//:quotient_.radix.ieee_.IBin
	{
		/// <summary>
		/// 2^(11-1)-1
		/// </summary>
		public const int INDIC_BIAS =1023;

		static public _radix.basic.indiced.significed_.Bin _ToSignificed_assumeNormal(double x)
		{
			var t = _ToSignificandIndic_assumeNormal(
				x
			);
			return new _radix.basic.indiced.significed_.Bin(t.Item1, t.Item2);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		/// alias:
		///		significAndIndic
		static public (long, int) _ToSignificandIndic_assumeNormal(double x)
		{

			var bits = _BinX.BitsAsLittle1st(x);

			/// 1.b[51]b[50]b[49]..b[0] (based 2)
			var significand = new BitArray(53);

			var mantissaLength = significand.Length - 1;

			for (int i = 0; i < mantissaLength; i++)
			{
				significand[i] = bits[i];
			}

			/// unnormalized
			var indicBeforeBias = new BitArray(63 - 52); //11
			for (int i = 0; i < indicBeforeBias.Length; i++)
			{
				indicBeforeBias[i] = bits[i + 52];
			}

			var indicInts = new int[1];
			indicBeforeBias.CopyTo(indicInts, 0);

			var indicBeforeBiasAsInt = indicInts[0];
			//indicBeforeBiasAsInt= nilnul.num.integer.of

			if (indicBeforeBiasAsInt == 0)  //subnormal
			{
				//significand[mantissaLength] = false;
				indicBeforeBiasAsInt ++; //+=1
			}
			else
			{
				significand[mantissaLength] = true; // +1
			}

			var biasedIndic = indicBeforeBiasAsInt - 1023 - 52;

			//var mantissaInts = new long[1];
			var significandAsByts = new byte[8];

			significand.CopyTo(significandAsByts, 0);

			var significandAsLong = BitConverter.ToInt64(significandAsByts, 0);

			if (bits[63])
			{
				significandAsLong = -significandAsLong;
			}

			return (
				significandAsLong
				,
				biasedIndic
			);
		}

		


	}
}
