using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.ext.border
{
	public class Duo
		:nilnul.tuple.comparer.border.Duo_comparerDefault<_ext.ExtI , Comparer, Border>
	{

		public Duo(bool left, _ext.ExtI leftMark, bool right, _ext.ExtI rightMark)
			:this(new Border(left,leftMark),new Border(right,rightMark))
		{

		}
		public Duo(bool left, Q leftMark, bool right, Q rightMark)
			:this(new Border(left,leftMark),new Border(right,rightMark))
		{

		}
		public Duo(bool left, Q1 leftMark, bool right, Q1 rightMark)
			:this(new Border(left,leftMark),new Border(right,rightMark))
		{

		}

		public Duo(Border lower, Border upper):base(lower,upper)
		{

		}

		static public Duo CreateClose(_ext.ExtI leftMark,  _ext.ExtI rightMark) {
			return new Duo(true,leftMark,true, rightMark);

		}
		static public Duo CreateClose(Q leftMark,  Q rightMark) {
			return new Duo(true,leftMark,true, rightMark);

		}

		static public Duo CreateClose(Q1 leftMark,  Q1 rightMark) {
			return new Duo(true,leftMark,true, rightMark);

		}


		
	}
}
