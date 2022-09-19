using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace nilnul.number.rational
{
	static public partial class InverseX
	{
		static public RationalI Inverse(this RationalI a) {
			return (1).Divide(a);
		}

		static public RationalI Inverse(this BigInteger a)
		{
			return (1).Divide(a);
		}
	}
}
