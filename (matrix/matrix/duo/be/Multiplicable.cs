using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;
namespace nilnul.num.quotient.matrix.duo.be
{
	public class Multiplicable
	{
		static public bool Eval(Q[,] a, Q[,] b) {
			return a.GetLength(1) == b.GetLength(0);
		}

		static public bool Eval(Duo duo) {
			return Eval(duo.Item1, duo.Item2);
		}


		public class Be :nilnul.bit.Be<Duo> 
		{
			public Be()
				:base(Eval)

			{

			}

			public class Asserted :nilnul.bit.be.Asserted<Duo,Be>
			{
				public Asserted(Duo duo)
					:base(duo)
				{

				}


				static public Q[,] Multi(Asserted a) {

					var x = a.val.Item1;
					var y = a.val.Item2;

					var rows = x.GetLength(0);
					var cols = y.GetLength(1);

					var r = new Q[rows,cols];

					for (int i = 0; i < rows; i++)
					{
						for (int j = 0; j < cols; j++)
						{
							r[i, j] = nilnul.num.quotient.str.duo.be.Multiplicable.Be.Asserted._Multi(
								nilnul.collection.matrix.MatrixX.Row(x, i)
								,
								nilnul.collection.matrix.MatrixX.Column(y,j)	
							);
						}

					}
					return r;
				}

				static public Q[,] _Multi_multiplicable(Q[,] x, Q[,] y) {
					

					var rows = x.GetLength(0);
					var cols = y.GetLength(1);

					var r = new Q[rows,cols];

					for (int i = 0; i < rows; i++)
					{
						for (int j = 0; j < cols; j++)
						{
							r[i, j] = nilnul.num.quotient.str.duo.be.Multiplicable.Be.Asserted._Multi(
								nilnul.collection.matrix.MatrixX.Row(x, i)
								,
								nilnul.collection.matrix.MatrixX.Column(y,j)	
							);
						}

					}
					return r;

				}


			}
		}
	}
}
