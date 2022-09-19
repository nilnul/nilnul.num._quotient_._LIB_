using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.matrix
{
	/// <summary>
	/// This will regard two-dimensional arrays as Matrix and define matrix computation.
	/// The mothods we defined on our matrix class is not applicable on these arrays for they are built in CLR types; however we convert or box them as matrix and compute, then unbox back.
	/// </summary>
	static public partial class X
	{

	


		public static Q[,] Delete(this Q[,] matrix, int m, int n)
		{
			return nilnul.collection.matrix.MatrixX.Deltete_literally(matrix, m, n);

		}//Cofactor







	}//class



}
