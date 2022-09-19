using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.matrix.square.op
{
	public partial class Inverse
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_nonSingular"></param>
		/// <returns>
		/// empty if empty.
		/// </returns>
		public static Q[,] _Eval( Q[,] _nonSingular)
		{


			//if (determ == 0)
			//{
			//	throw new Exception("The determinant of the matrix is 0 so it's not inversible.");
			//}

		

			return quotient.matrix.op.ScaleX.Eval(
				
				Q.CreateOne() / Determinant._Eval(_nonSingular),
			
				Adjugate.Eval(_nonSingular)
			);

			




		}


	}
}
