using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.matrix.square.op
{
	/// <summary>
	/// This will regard two-dimensional arrays as Matrix and define matrix computation.
	/// The mothods we defined on our matrix class is not applicable on these arrays for they are built in CLR types; however we convert or box them as matrix and compute, then unbox back.
	/// </summary>
	static public partial class AllX
	{


		/// <summary>
		/// the remaining square's determinat * evenOdd
		/// </summary>
		/// <param name="_matrix__square"></param>
		/// <param name="m"></param>
		/// <param name="n"></param>
		/// <returns></returns>
		/// 
		[Obsolete("Cofactor")]
		public static Q _AlgebraicCofactor(this Q[,] _square, int m, int n)
		{

			//if (!squareMatrix.IsSquare()) {
			//    throw new Exception("The matrix must be square.");
			//}
			if ((m % 2) == (n % 2))
			{
				return  quotient.matrix.square.op.Determinant._Eval(matrix.X.Delete(_square, m, n));
			}
			else
			{
				return - quotient.matrix.square.op.Determinant._Eval(matrix.X.Delete(_square, m, n));

			}




		}

	






	}//class



}
