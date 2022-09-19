using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.matrix.square.be
{
	public class NonSinglar
	{
		public class Be:nilnul.bit.be.op.Complement.Expr_TBeDefault<Square_array,Singular>
		{



		}

		public class Asserted:nilnul.bit.be.Asserted<Square_array,Be>
		{
			public Asserted(Square_array array)
				:base(array)
			{

			}




		}


	}
}
