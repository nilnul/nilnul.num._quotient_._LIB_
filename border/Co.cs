using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.border
{
	public class Co
		:
		nilnul.obj.border.Co<nilnul.num.Quotient1, Border2>

	{

		public Co(bool left, Q1 leftMark, bool right, Q1 rightMark)
			:this(new Border2(left,leftMark),new Border2(right,rightMark))
		{

		}
		
		

		public Co(Border2 lower, Border2 upper):base(lower,upper)
		{

		}
		public bool contains(Q1 ext) {
			return border.comparer_.lower.Re.Singleton.le(lower, ext)

				&& border.comparer_.upper.Re.Singleton.ge(upper,ext)

				;
		}

		public override string ToString()
		{
			return nilnul.border.Lower.ToTxt(lower) + "," + nilnul.border.Upper.ToTxt(upper);
		}


		static public Co CreateClose(Q1 leftMark,  Q1 rightMark) {
			return new Co(true,leftMark,true, rightMark);

		}
		

		

		static public Co CreateSingleton(Q1 leftMark) {
			return new Co(true,leftMark,true, leftMark);

		}




		
	}
}
