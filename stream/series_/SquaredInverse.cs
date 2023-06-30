using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream.series_
{

	/// <summary>
	/// this converges to Pi^2/6
	/// </summary>
	public class SquaredInverse:Series
	{
		public SquaredInverse():base(
			
			 new nilnul.num.quotient.stream.FroFunc(
					
					
					  x=>  nilnul.num.quotient_.nonzero.op_._inverse.Extensions._Inverse( nilnul.num.op_.Square.Eval(x+1) )	
					
				)
			
			)
		{

		}
	}
}
