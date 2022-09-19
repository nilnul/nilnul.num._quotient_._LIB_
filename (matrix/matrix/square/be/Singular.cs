using nilnul.num.quotient.matrix.square.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.matrix.square.be
{
	public partial class Singular
		:nilnul.bit.BeI<Square_array>
	{
		static public bool Eval(matrix.Square_array matrix) {
			return Determinant._Eval(matrix.val) == 0;
		}

		public bool be(Square_array obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}

		public class Be:nilnul.bit.Be<Square_array>
		{
			public Be()
				:base(Eval)
			{

			}
		}

		public class Asserted:nilnul.bit.be.Asserted<Square_array, Be>
		{
			public Asserted(Square_array array)
				:base(array)
			{
		
			}
			public Asserted(Q[,] array)
				:this( new Square_array( array))
			{
		
			}
		}
	}
}
