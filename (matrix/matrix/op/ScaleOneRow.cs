using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.matrix.op
{
	public class ScaleOneRow
	{
		static public void Eval(Q[,] matrix, int row, Q scale) {

			for (int i = 0; i < matrix.GetLength(1); i++)
			{
				matrix[row, i] *= scale;
			}
			return;

			throw new NotImplementedException();
		}
	}
}
