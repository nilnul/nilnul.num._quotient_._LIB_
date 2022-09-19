using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.square
{
	/// <summary>
	/// first minor
	/// </summary>
	public partial class Minor
	{
		static public double Eval(double[,] matrix,int i,int j) {

			return Determinant._Eval_laplace(nilnul.collection.matrix.MatrixX.Delete(matrix, i, j));
		
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix">must be square</param>
		/// <param name="rows2del"></param>
		/// <param name="cols2del">must equal to rows2del</param>
		/// <returns></returns>

		static public double _Eval(double[,] matrix,IEnumerable<int> rows2del,IEnumerable<int> cols2del) {

			return Determinant.Eval(
				nilnul.collection.matrix.MatrixX.Delete(matrix, rows2del, cols2del)
			);
		
		}

	}
}
