﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q0 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.slider_.geometric_
{
	/// <summary>
	/// the first one is 1.
	/// </summary>
	/// <remarks>
	/// Performance: binary divide and conquer for power expression evaluation.
	/// </remarks>
	public class Std : Geometric
	{
		public Std( Q0 rate) : base(1, rate)
		{
		}
	}
}
