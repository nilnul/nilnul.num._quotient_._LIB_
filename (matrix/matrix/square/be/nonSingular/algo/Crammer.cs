using nilnul.num.quotient.matrix.square.prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.matrix.square.be.nonSingular.algo
{
	public class Crammer
	{
		private Q[,] _coefficients;

		public Q[,] coeeficients
		{
			get { return _coefficients; }
			set { _coefficients = value; }
		}

		private Q[] _b;

		public Q[] b
		{
			get { return _b; }
			set { _b = value; }
		}

		static public Q[] _Solve(
			Q[,] _coefficients
			,
			Q[] _b
			) {
			var dimension = _coefficients.GetLength(0);

			var _augments =new  Q[dimension][,];

			for (int i = 0; i < dimension; i++)
			{
				_augments[i] =collection.matrix.MatrixX.Clone(_coefficients);

				for (int row = 0; row < dimension; row++)
				{

					_augments[i][row, i] = _b[row];
				}

			}

			var r = new Q[dimension];

			for (int i = 0; i < dimension; i++)
			{
				r[i] = Determinant._Eval(_augments[i]) / Determinant._Eval(_coefficients);
			}

			return r;
				
				

		

		}


	}
}
