﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R=nilnul.num.rational.Rational_InheritFraction2;

using R1 = nilnul.num.quotient.Range1;//.duo.be_.Nonempty.En;

using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.range.op_.unary_
{
	static public class _ScaleX
	{
		static public R1 Scale(Q1 scale, R1 cut) {


			if (scale==0)
			{
				return R1.CreateZero();

			}
			if (scale>0)
			{
				return new R1(
					nilnul.num.quotient.border.op_.unary_._ScaleX.Scale(scale, cut.lower)
					, 
					nilnul.num.quotient.border.op_.unary_._ScaleX.Scale(scale,cut.upper)
				);
			}

			return new R1(
					nilnul.num.quotient.border.op_.unary_._ScaleX.Scale(scale,cut.upper)

					, 
					nilnul.num.quotient.border.op_.unary_._ScaleX.Scale(scale, cut.lower)
			
			);
		
		}

	}
}
