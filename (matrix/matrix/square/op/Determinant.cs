using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using Q = nilnul.num.quotient.Q;


namespace nilnul.num.quotient.matrix.square.op
{
	public class Determinant
	{
		

		public static double _Eval_triangluarDecomposition(double[,] squareMatrix)
		{
			throw new NotImplementedException();
		}
		public static Q _Eval(Q[,] matrix_square)
		{
			return _Eval_laplace(matrix_square);
		}

		public static Q _Eval_laplace(Q[,] squareMatrix)
		{

			if (squareMatrix.GetLength(0) == 0)
			{
				return 1;
			}

			else
			{
				Q r = 0;

				for (int i = 0; i < squareMatrix.GetLength(0); i++)
				{
					r +=  squareMatrix[0, i] * Cofactor.Eval(squareMatrix, 0, i);
				}
				return r;
			}
		}

		
	}//class
}
