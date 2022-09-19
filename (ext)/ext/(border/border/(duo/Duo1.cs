using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.ext.border
{
	public class Duo1
		:
		nilnul.border.Duo1<quotient.ExtI, ext.Border1>

	{

		public Duo1(bool left, ExtI leftMark, bool right, ExtI rightMark)
			:this(new Border1(left,leftMark),new Border1(right,rightMark))
		{

		}
		
		public Duo1(bool left, Q1 leftMark, bool right, Q1 rightMark)
			:this(new Border1(left,leftMark),new Border1(right,rightMark))
		{

		}

		public Duo1(Border1 lower, Border1 upper):base(lower,upper)
		{

		}



		public bool contains(ExtI ext) {
			return border.comparer_.lower.Decider.Singleton.contains(lower, ext)

				&& border.comparer_.lower.upper.Decider.Singleton.contains(upper,ext)

				;
		}

		public bool notContains(ExtI ext) {

			return !contains(ext);
		}

		


		static public Duo1 CreateClose(ExtI leftMark,  ExtI rightMark) {
			return new Duo1(true,leftMark,true, rightMark);

		}
		

		static public Duo1 CreateClose(Q1 leftMark,  Q1 rightMark) {
			return new Duo1(true,leftMark,true, rightMark);

		}

		static public Duo1 CreateSingleton(Q1 leftMark) {
			return new Duo1(true,leftMark,true, leftMark);

		}




		
	}
}
