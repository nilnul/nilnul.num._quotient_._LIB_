using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.matrix.op
{
	public class GaussianEliminationInRows
	{
		static public void Eval(Q[,] matrix)
		{
			var rowCount = matrix.GetLength(0);
			var colCount = matrix.GetLength(1);
			var rowCount_minus1=rowCount-1;
			rowLoop:
			for (int row = 0, col = 0; row < rowCount_minus1 && col < colCount; col++)
			{

				int pivotedRowIndex;
				for (pivotedRowIndex = row; pivotedRowIndex < rowCount; pivotedRowIndex++)
				{
					if (matrix[pivotedRowIndex, col] != 0)
					{
						break;
					}

				}


				if (pivotedRowIndex == rowCount)
				{
					continue;

				}

				else
				{
					nilnul.collection.matrix.MatrixX.SwapTwoRows(matrix, row, pivotedRowIndex);

					for (int k = row+1; k < matrix.GetLength(0); k++)
					{
						RowMergeOther.Eval(matrix, k, row, -matrix[k, col] / matrix[row, col]);
						//if (matrix[k, col] != 0)
						//{
						//	RowMergeOther.Eval(matrix, k, row, -matrix[k, col] / matrix[row, col]);

						//}
					}

					row++;

					continue;


				}

			}
			return;
			throw new NotImplementedException();
		}
	}
}
