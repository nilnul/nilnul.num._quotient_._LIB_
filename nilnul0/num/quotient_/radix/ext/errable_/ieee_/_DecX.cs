using System.Collections;
using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace nilnul.num.quotient_.radix.floaty_
{




	static public class _DecX
	{



		/// <summary>
		/// note the endianess;
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public int[] BitsAsInts(decimal x)
		{
			return decimal.GetBits(x);
		}





	}
}
