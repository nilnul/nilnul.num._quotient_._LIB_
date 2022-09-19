using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.matrix.duo.be
{
	public class SameDimension
	{
		static public bool Eval(Q[,] a, Q[,] b) {
			return a.GetLength(0) == b.GetLength(0) && a.GetLength(1) == b.GetLength(1);
		}



		public class Asserted
		{

			static public bool _Eq(Q[,] a, Q[,] b)
			{
				
				for (int i = 0; i < a.GetLength(0); i++)
					{
						for (int j = 0; j < a.GetLength(1); j++)
						{
							if (a[i, j] != b[i, j])
							{
								return false;
							}

						}
					}

				return true;
				
			}


		}
	}
}
