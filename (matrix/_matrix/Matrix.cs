using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient._matrix
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// why we need the matrix, which adds no constraints to an Array?
	/// 
	/// we can define operators, for example. If we use no operator but name methods, we may don't need this non-constraint type.
	/// </remarks>
	public partial class Matrix
		:nilnul.collection.matrix.Matrix<Q>
	{
		public Matrix(Q[,] array)
			:base(array)
		{

		}

		[Obsolete("scale")]
		static public Q[,] Multi(Q q, Q[,] m) {
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
		[Obsolete("scale")]
		static public Q[,] Multi( Q[,] m, Q q) {
			return Multi(q, m);

		}



		static public Q[,] CreateZeroArray(int rows, int cols) {
			return nilnul.collection.matrix.Matrix.CreatePlanarArray<Q>(rows,cols,0);
		}



		static public new Q[,]  CreatePlanarArray(int rows, int cols) {
			return nilnul.collection.matrix.Matrix.CreatePlanarArray<Q>(rows, cols);
		}

	



	}
}
