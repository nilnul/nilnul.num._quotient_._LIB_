using System.Collections;
using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_
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

	static public class _BinX
		//: quotient_.radix.ext.errable_.ieee_.IDbl
	{
		/// <summary>
		/// 2^(11-1)-1
		/// </summary>
		public const int INDIC_BIAS = 1023;


		/// <summary>
		/// note the endianess;
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public byte[] BytsAsLittle1st(double x)
		{
			var bytes = BitConverter.GetBytes(x);
			return BitConverter.IsLittleEndian ? bytes : bytes.Reverse().ToArray();
		}

		static public BitArray BitsAsLittle1st(double x)
		{
			return new BitArray(
				BytsAsLittle1st(x)
			);
		}

		static public double OfBitsInLittle1st(
			byte[] byts
		) {
			return BitConverter.ToDouble(
				byts,
				0
			);
		}




	}
}
