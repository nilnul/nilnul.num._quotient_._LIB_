using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.quotient_.DenomNonnil;//._quotient.fraction.op.Simplify.Ed1;
using nilnul.obj.border.comp;

namespace nilnul.num.quotient_.denomNonnil._range.border
{
	public class Co_nonnilDenom
		:
		nilnul.obj.border.Co<nilnul.num.quotient_.DenomNonnil, BorderI>

	{
		public Co_nonnilDenom(Border lower, Border upper):base(lower,upper)
		{

		}

		public Co_nonnilDenom(bool left, Q1 leftMark, bool right, Q1 rightMark)
			:this(new Border(left,leftMark),new Border(right,rightMark))
		{

		}
		
		

		public bool contains(Q1 ext) {
			return border_.lower.Comp.Singleton.Le(lower, ext)

				&&
				border_.upper.Comp.Singleton.Ge(upper,ext)

				;
		}

		public override string ToString()
		{
			return nilnul.obj.border.co.phrase_._LowerUpperX.Phrase(lower,upper);
		}


		static public Co_nonnilDenom CreateClose(Q1 leftMark,  Q1 rightMark) {
			return new Co_nonnilDenom(true,leftMark,true, rightMark);

		}
		

		

		static public Co_nonnilDenom CreateSingleton(Q1 leftMark) {
			return new Co_nonnilDenom(true,leftMark,true, leftMark);

		}




		
	}
}
