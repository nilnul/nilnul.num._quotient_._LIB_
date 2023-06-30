using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_.nonerr_
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
	/// alias:
	///		finite
	///		

	static public class _NoninfX
		//:quotient_.radix.ext.errable_.ieee_.IBin
	{
		/// <summary>
		/// 2^(11-1)-1
		/// </summary>
		public const int INDIC_BIAS =1023;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x">
		/// as the typ is double, we need to use <see cref="bin_.IFinite"/>, not <see cref="bin_.nonerr_.INoninf"/>, where <see cref="INonerr"/> ; finite is relative to the typ of <paramref name="x"/>;
		/// </param>
		/// <returns></returns>
		static public _radix.basic.indiced.significed_.Bin _ToSignificed_0finite(double x)
		{
			var t = _ToSignificandIndic_0finite(
				x
			);
			return new _radix.basic.indiced.significed_.Bin(t.Item1, t.Item2);
		}
		static public _radix.basic.indiced.significed_.Bin ToSignificed(bin.be_.finite.vow.Ee x)
		{
			return _ToSignificed_0finite(x.eeByRef);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		/// alias:
		///		significAndIndic
		static public (long, int) _ToSignificandIndic_0finite(double x)
		{
			const int signBitsCount = 1;
			const int mantissaCount = 52;
			const int significandCount = signBitsCount + mantissaCount;
			const int indicCount = 64 - significandCount; //11
			const int indicRangeHalfDecre = 1023;// (2^11-2) /2, where the 2 minused is the infinitesimal and the infinity;  [0, 2^11)
												 // =[0,1, ... ,  2^11-2]
												 // -->  [-1022, -1022, -1021, ...,-1,0,1, 1021, 1022, (2048-2)-1023], where the first -1023 is to denote infinitesimal (the significand is deheaded into a mantissa, so the indic has to increased;), the 1023 at the end is to denote infinity;


			var bits = _BinX.BitsAsLittle1st(x);

			/// 1.b[51]b[50]b[49]..b[0] (based 2)
			var offset = new BitArray(significandCount);

			//var mantissaCount = offset.Length - 1;

			for (int i = 0; i < mantissaCount; i++)
			{
				offset[i] = bits[i];
			}

			/// unnormalized
			var indicBiased = new BitArray(indicCount); //11
			for (int i = 0; i < indicBiased.Length; i++)
			{
				indicBiased[i] = bits[i + mantissaCount];
			}

			var indicInts = new int[1];
			indicBiased.CopyTo(indicInts, 0);

			var indic2debias = indicInts[0];
			//indicBeforeBiasAsInt= nilnul.num.integer.of

			if (indic2debias == 0)  //biased indic; as biased is unsigned, hence 0 is the mininum;subnormal
			{
				//significand[mantissaLength] = false;
				indic2debias ++; //+=1

				// 0.xxxxxx * 2^(-1023 ) =0xxxx * 2^ (-1023 -52)
				// 0.1111111... * 2^(-1023)
				/// [0, 0.111111... ] * 2^(-1022)
				/// = [0, 2^-1022)
				/// =[0,1) * 2^-1022
				/// = 0,
				///		0.000...1 * 2^-1022
				///		, 0.000...10 * 2^-1022, 0.000...11 * 2^-1022
				///		,0.010000000000 * 2^-1022 =1. * 2^-1023
				///			,0.01111111111111... * 2^-1022 = 0.11111... * 2^-1023
				///		,  0.1111111111... * 2^ -1022
				///		=0 + [0.000..., 0.1111...] * 2^ -1022
				///	togethe with the subsequent range:
				///		= [0.000..., 0.1111..., 1.000..., ..., 1.111...] * 2^ -1022

			}
			else
			{
				offset[mantissaCount] = true; // +1; 2^precision  * 2^ponent = 2^(precision + ponent)
											// 1.xxxxx... * 2^ y = 2^y + 0.xxxxx... * 2^y, where y is in [1,2046]-1023-52, xxxxx... is in [0000000...,11111...]
											// the minimal is 1.00000 * 2^ (1-1023)

											/// [1, ..., 1.1111... ] * 2^(-1022) = 2^-1022 + [0.000..., 0.1111...] * 2^ -1022
											///			= [1,2) * 2^(-1022)  
											/// ,[2,3) * 2^(-1022) = [1,2) * 2^(-1021) =  2^-1021 + [0.000..., 0.1111...] * 2^ -1021
			}

			var debiasedIndic = indic2debias - 1023 - mantissaCount;

			//var mantissaInts = new long[1];
			var significandAsByts = new byte[8];

			offset.CopyTo(significandAsByts, 0);

			var significandAsLong = BitConverter.ToInt64(significandAsByts, 0);

			if (bits[63])
			{
				significandAsLong = -significandAsLong;
			}

			return (
				significandAsLong
				,
				debiasedIndic
			);
		}

		static public (long, int) ToSignificand9indic(bin.be_.finite.vow.Ee x)
		{
			return _ToSignificandIndic_0finite(x.eeByRef);
		}
		


	}
}
