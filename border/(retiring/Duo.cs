using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.border
{
	[Obsolete()]
	public class Duo
		:
		nilnul.border.Duo1<Q1, Border1>

	{

		public Duo(bool left, Q1 leftMark, bool right, Q1 rightMark)
			:this(new Border1(left,leftMark),new Border1(right,rightMark))
		{

		}
		
		

		public Duo(Border1 lower, Border1 upper):base(lower,upper)
		{

		}
		public bool contains(Q1 ext) {
			return border.comparer_.lower.Decider.Singleton.contains(lower, ext)

				&& border.comparer_.lower_.upper.Decider.Singleton.contains(upper,ext)

				;
		}

		public override string ToString()
		{
			return nilnul.border.Lower.ToTxt(lower) + "," + nilnul.border.Upper.ToTxt(upper);
		}


		static public Duo CreateClose(Q1 leftMark,  Q1 rightMark) {
			return new Duo(true,leftMark,true, rightMark);

		}
		

		

		static public Duo CreateSingleton(Q1 leftMark) {
			return new Duo(true,leftMark,true, leftMark);

		}




		
	}
}
