using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.str.be
{ 
	public partial class Zero
	{
		static public bool Eval(Q[] matrix) {

			return matrix.All(x => x == 0);

		}
		static public bool Eval(IEnumerable<Q> matrix) {

			return matrix.All(x => x == 0);

		}
	}
}
