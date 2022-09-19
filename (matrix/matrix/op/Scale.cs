using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.matrix.op
{
	static public partial class ScaleX
	{


		static public Q[,] Eval(this Q q, Q[,] m) {
			Q[,] r = new Q[m.GetLength(0), m.GetLength(1)];

			for (int i = 0; i < r.GetLength(0); i++)
			{
				for (int j = 0; j < r.GetLength(1); j++)
				{
					r[i, j] = m[i, j] * q;
				}

			}
			return r;


		}
		static public Q[,] Eval(this Q[,] m, Q q) {
			return Eval(q, m);


		}


	}
}
