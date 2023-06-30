using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.co
{
	static public class _DiameterX
	{
		static public DenomNonnil Diameter(this (DenomNonnil,DenomNonnil) bound)
		{
			return (bound.Item1 - bound.Item2).toAbs();
		}
	}
}
