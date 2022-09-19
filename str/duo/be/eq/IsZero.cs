using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.str.duo.be.eq
{
	public partial class IsZero
	{
		static public bool Eval(Q[] matrix) {

			return matrix.All(x => x == 0);

		}
	}
}
