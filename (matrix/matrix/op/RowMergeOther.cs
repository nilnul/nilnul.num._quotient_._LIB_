using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.matrix.op
{
	public class RowMergeOther
	{
		static public void Eval(Q[,] matrix, int row, int other) {

			for (int i = 0; i < matrix.GetLength(1); i++)
			{
				matrix[row, i] += matrix[other,i];
			}
			return;

			throw new NotImplementedException();
		}
		static public void Eval(Q[,] matrix, int row, int other, Q otherScale) {

			for (int i = 0; i < matrix.GetLength(1); i++)
			{
				matrix[row, i] += matrix[other,i]*otherScale;
			}
			return;

			throw new NotImplementedException();
		}
	}
}
