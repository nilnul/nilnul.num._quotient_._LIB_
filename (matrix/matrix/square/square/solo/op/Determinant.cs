using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;


namespace nilnul.num.real.matrix.square.solo.op
{
	public class Determinant
	{
		public static double Eval(params double[] squareMatrix)
		{

			return InDouble.Create(squareMatrix).determinant;
		}

		public static double _Eval_2x2(double[] v0, double[] v1)
		{

			return InDouble.Create(v0[0], v0[1], v1[0], v1[1]).determinant;


		}

		public static double _Eval_triangluarDecomposition(double[,] squareMatrix)
		{
			throw new NotImplementedException();
		}
		public static double _Eval(double[,] matrix)
		{
			return _Eval_laplace(matrix);
		}

		public static double _Eval_laplace(double[,] squareMatrix)
		{

			if (squareMatrix.GetLength(0) == 0)
			{
				return 1;
			}

			else
			{
				double r = 0;

				for (int i = 0; i < squareMatrix.GetLength(0); i++)
				{
					r += squareMatrix[0, i] * Cofactor.Eval(squareMatrix, 0, i);
				}
				return r;
			}
		}

		public static double Eval(double[,] squareMatrix)
		{
			if (squareMatrix.GetLength(0) != squareMatrix.GetLength(1))
			{
				throw new Exception("The matrix must be square.");
			}

			if (squareMatrix.GetLength(0) == 0)
			{
				throw new Exception("The square matrix must be 1 or more in width.");
			}

			//suppose it's one in length.
			if (squareMatrix.GetLength(0) == 1)
			{

				return squareMatrix[0, 0];
			}
			else
			{
				double r = 0;
				for (int i = 0; i < squareMatrix.GetLength(0); i++)
				{
					r += squareMatrix[0, i] * Math.Pow(-1, i) * Eval(MatrixX131113.Cofactor(squareMatrix, 0, i));
				}
				return r;
			}
		}
	}//class
}
