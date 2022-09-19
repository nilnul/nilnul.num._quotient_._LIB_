using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.square
{
	public partial class Assertion
	{

		static public bool _Be(double[,] matrix_notNull) {

			return nilnul.collection.matrix.twoDimensionalArray._be.Square<double>.Eval(matrix_notNull);
		
		
		}


		static public bool Be( NotNull2<double[,]> matrix)
		{
			return _Be(matrix.val);
			


		}

		static public nilnul.bit.Assertion_FroAdj2<double[,]> AssertionOfDouble = new bit.Assertion_FroAdj2<double[,]>(_Be);


	}
}
