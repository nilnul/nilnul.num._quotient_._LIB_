using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.matrix
{
	public class Square_array
		:nilnul.num.quotient.matrix.be.Square.Be_ofPlanarArray.Asserted
	{

		public Square_array(Q[,] array)
			:base(array)
		{

		}

		public Square_array()
			:this(new Q[0,0])
		{

		}
		static public Q[,] CreatePlanarArray(int dimension) {

			return quotient._matrix.Matrix.CreatePlanarArray(dimension, dimension);

		}
		static public Q[,] CreateZeroArray(int dimension) {

			return quotient._matrix.Matrix.CreateZeroArray(dimension, dimension);

		}

		static public implicit operator Q[,](Square_array square) {
			return square.val;
		}

		static public Q[,] CreateIdentityArray(int dimension) {
			var created = CreatePlanarArray(dimension);
			for (int i = 0; i < dimension; i++)
			{
				for (int j = 0; j < dimension; j++)
				{

					created[i,j] = (i==j)?1:0;
				}
			}
			return created;
		}



		static public Square_array CreateNul() {
			return new Square_array();
		}

		static public Q[,] CreateNulArray() {
			return new Q[0,0];
		}





	}
}
