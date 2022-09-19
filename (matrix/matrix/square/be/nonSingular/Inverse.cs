using nilnul.num.quotient.matrix.square.op;
using nilnul.num.quotient.matrix.square.prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

using Determ = nilnul.num.quotient.matrix.square.prop.Determinant;

namespace nilnul.num.quotient.matrix.square.be.nonSingular
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
				
				Q.CreateOne() / Determ._Eval(_nonSingular),
			
				Adjugate.Eval(_nonSingular)
			);



		}

		static public Square_array _Eval(Square_array _nonSingular) {

			return new Square_array(
				_Eval(_nonSingular.val)
				);

		}


	}
}
