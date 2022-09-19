using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.slider_.geometric_
{
	public class PolyOdd1 : Geometric
	{
		public PolyOdd1(Q1 x)
			:base(
				 x
				 ,

				 nilnul.num.quotient.op_.unary_._SquareX.Square(x)
				 
				)
		{

		}
		
	}
}
