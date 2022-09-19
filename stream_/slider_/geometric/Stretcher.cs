using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.slider_.geometric
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// use stardard geometric to enhance performance for standard geomtric can utilize binary divide and conquer.
	/// </remarks>
	public class Stretched : slider.Stretched
	{
		public Stretched(Q1 head, Q1 rate)
			:base(
				head
				 ,
				new slider_.GeometricStandard(rate)	 
			)
		{

		}
	}
}
