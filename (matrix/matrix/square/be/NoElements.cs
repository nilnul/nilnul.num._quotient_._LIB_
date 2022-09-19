using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.matrix.square.be
{
	public partial class NoElements
	{
		static public bool Eval(Q[,] x) {
			return x.Length == 0;
		}
	}
}
