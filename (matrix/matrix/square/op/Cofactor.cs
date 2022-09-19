using nilnul.num.quotient.matrix.square.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.matrix.square.op
{
	/// <summary>
	/// signed minor
	/// </summary>
	public partial class Cofactor
	{
		static public Q Eval(Q[,] matrix,int row,int col) {
			return nilnul.num.int_.MinusOnePow.Eval(row + col)*Minor.Eval(matrix,row,col);
		
		}
	}
}
