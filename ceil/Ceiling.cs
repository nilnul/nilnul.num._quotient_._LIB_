using System;
using System.Net;
using System.Numerics;

namespace nilnul.number.quotient.ceil
{

    /// <summary>
    /// a function to get the number no less than given x, but mod given unit=0.
    /// </summary>
	static public  class _PadX
	{

		
		static public BigInteger _Pad_assumeDenomPositive(BigInteger num,BigInteger unit) {
           var rem= num% unit;
		   if (rem.Equals(0))
		   {
			   return num;

		   }
		   else
		   {
			   return num - rem + unit;
		   }

			
		}
				


	}
	
}
