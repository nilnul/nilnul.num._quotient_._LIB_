using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.gtOne.co
{
	/// <summary>
	/// lg(a,x), whera a is <see cref="quotient.betwixt_.boolish_.IOpen"/>, x is positive;
	/// the result is <see cref="nilnul.num.integer.betwixt_.IClasp"/>
	/// </summary>
	static public class _LgX
	{
		static public (BigInteger, BigInteger) _Lg_01gtOne(DenomNonnil a,DenomNonnil x) {
			BigInteger lowerIndic = 0; //the x in b^x; this is what to be returned;
			DenomNonnil lowerTgt = 1; /// 2^index


			BigInteger indicIncrementLb;  //x in forward, which is a^(2^x)
			BigInteger indicIncrement;

			DenomNonnil tgtAmplifier;		// a^(2^x)
			DenomNonnil upperTgt;  //lower Border


			do
			{
				indicIncrementLb = 0;
				indicIncrement = 1;
				//lowerIndic += indicIncrement;

				tgtAmplifier = a;

				upperTgt = lowerTgt * tgtAmplifier;

				while (upperTgt <= x)
				{
					//update index
					lowerIndic += indicIncrement;
					lowerTgt = upperTgt; //next lowerBorde of Pow


					//update forward

					indicIncrementLb ++;
					indicIncrement <<= 1;// indicIncrement << 1;
					tgtAmplifier *= tgtAmplifier;

					//update recon
					upperTgt = lowerTgt * tgtAmplifier; //next upperBound
				}//overreach, now backtrack


			} while (indicIncrementLb != 0); // we need to shrink the range's width to one;

			
			return lowerTgt==x?(lowerIndic, lowerIndic):(lowerIndic,lowerIndic+1);

		}

	}
}
