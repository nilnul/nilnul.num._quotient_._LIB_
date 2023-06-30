using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.quotient_.DenomNonnil;//._quotient.fraction.op.Simplify.Ed1;
using Qi = nilnul.num.quotient_.DenomNonnil;//._quotient.fraction.op.Simplify.Ed1;
using nilnul.obj.comp;

namespace nilnul.num.quotient_.denomNonnil._range.border.co_.lowerUpper.be_
{
	static public class _HasX

	{


		

	


		static public bool Has(this LowerUpperI lowerUpper, Q1 ext) {
			return
				nilnul.obj.border.comp._ReX.Le(
					border_.lower.Comp.Singleton
					,
					lowerUpper.
					lower
					,
					ext
				)
				&&
				nilnul.obj.border.comp._ReX.Ge(
					border_.upper.Comp.Singleton
					,
					lowerUpper.

					upper
					,
					ext
				)
			;
		}


		static public bool Has(this LowerUpperI lowerUpper,int element)
		{
			return Has(lowerUpper, new quotient_.DenomNonnil(element));
		}
	}
}