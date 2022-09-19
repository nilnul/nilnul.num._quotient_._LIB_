using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.matrix.square.op
{
	/// <summary>
	/// cofactor matrix
	/// </summary>

	static public class AdjointX
	{
		public static Q[,] _Adjoint(this Q[,] _square)
		{
			//it has to be square
			int n = _square.GetLength(0);
			var r = new Q[n,n];

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					r[i, j] = Cofactor.Eval(_square,j, i);
				}
			}
			return r;
		}

/*************Cofactor Matrix
		static public Q[,] Eval(Q[,] matrix)
		{

			var raw = Square_array.CreatePlanarArray(matrix.GetLength(0));

			for (int i = 0; i < raw.GetLength(0); i++)
			{
				for (int j = 0; j < raw.GetLength(1); j++)
				{
					raw[i, j] = Cofactor.Eval(matrix, i, j);

				}

			}


			return raw;



		}
		*/

	}




	[Obsolete("Adjoint")]
	public partial class CofactorMatrix
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <returns>
		/// empty if matrix is empty
		/// </returns>
		static public Q[,] Eval(Q[,] matrix)
		{

			var raw = Square_array.CreatePlanarArray(matrix.GetLength(0));

			for (int i = 0; i < raw.GetLength(0); i++)
			{
				for (int j = 0; j < raw.GetLength(1); j++)
				{
					raw[i, j] = Cofactor.Eval(matrix, i, j);

				}

			}


			return raw;



		}
	}
}

