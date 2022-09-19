using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.slider_
{
	[Obsolete()]
	public class Constant : SliderI
	{
		public Constant(Q1 q)
		{
			_current = q;
		}
		private Simplify.Ed1 _current;
		public Simplify.Ed1 current
		{
			get
			{
				return _current;
				//throw new NotImplementedException();
			}
		}

		public void moveNext()
		{
			return;
			//throw new NotImplementedException();
		}
	}
}
