using nilnul.num.quotient._matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.matrix.be
{
	public partial class Square
		:
		
		
		nilnul.bit.AdjectiveI3<Matrix>

	{
		static public bool _Be(Matrix matrix_notNull) {

			return nilnul.collection.matrix.twoDimensionalArray._be.Square<Q>.Eval(matrix_notNull.components);
		
		}


		static public bool _Be(Q[,] _notNull) {
			return nilnul.collection.matrix.twoDimensionalArray._be.Square<Q>.Eval(_notNull);
		
		}


		public static bool Be( Q[,] matrix)
		{
			return matrix.GetLength(0) == matrix.GetLength(1);
		}

		static public nilnul.bit.Assertion_FroAdj2<Q[,]> Assertion = new bit.Assertion_FroAdj2<Q[,]>(_Be);




		private bool _be(Matrix obj_notNull)
		{
			return _Be(obj_notNull);

			throw new NotImplementedException();
		}

		public bool be(NotNull2<Matrix> val)
		{
			return _Be(val.val);

			throw new NotImplementedException();
		}

		public class Be_ofPlanarArray:nilnul.bit.Be<Q[,]>
		{
			public Be_ofPlanarArray()
				:base(Square.Be)
			{

			}

			public class Asserted:nilnul.bit.be.Asserted<Q[,],Be_ofPlanarArray>
				
			{

				public Asserted(Q[,] m):base(m)
				{

				}
			}
		}

		public class Be_ofMatrix:nilnul.bit.Be<_matrix.Matrix>
		{
			public Be_ofMatrix()
				:base(Square._Be)
			{

			}
		}


		
	}
}
