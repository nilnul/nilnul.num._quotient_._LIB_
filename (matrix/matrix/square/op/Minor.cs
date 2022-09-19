using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.matrix.square.op
{
	/// <summary>
	/// first minor. determinant of the remaining square matrix.
	/// </summary>
	public partial class Minor
	{
		static public Q Eval(Q[,] matrix,int i,int j) {

			return Determinant._Eval_laplace(nilnul.collection.matrix.MatrixX.Delete(matrix, i, j));
		
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix">must be square</param>
		/// <param name="rows2del"></param>
		/// <param name="cols2del">must equal to rows2del</param>
		/// <returns></returns>

		static public Q _Eval(Q[,] matrix,IEnumerable<int> rows2del,IEnumerable<int> cols2del) {

			return Determinant._Eval(
				nilnul.collection.matrix.MatrixX.Delete(matrix, rows2del, cols2del)
			);
		
		}

	}
}
