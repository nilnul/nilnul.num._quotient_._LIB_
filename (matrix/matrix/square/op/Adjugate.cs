using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.matrix.square.op
{
	public partial class Adjugate
	{

		static public Q[,] Eval(Q[,] matrix) {

			return  collection.matrix.MatrixX.Transpose(CofactorMatrix.Eval(matrix));
		
		}
	}
}
