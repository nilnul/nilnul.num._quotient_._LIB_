using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient
{
	static public class CoX
	{
		static public nilnul.num.Quotient1 Max(nilnul.num.Quotient1 x, nilnul.num.Quotient1 y) {
			return x >= y ? x : y;
		}

		static public nilnul.num.Quotient1 Min(nilnul.num.Quotient1 x, nilnul.num.Quotient1 y) {
			return x <= y ? x : y;
		}

	}
}
