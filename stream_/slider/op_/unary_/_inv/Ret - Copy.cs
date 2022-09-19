using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q0 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.slider.op_.unary_._inv
{
	public class Ret : nilnul.num.quotient.slider._call.ArgA
		,SliderI2
	{
		public Ret(SliderI2 arg) : base(arg)
		{
		}
	

		public  Quotient1 current
		{
			get
			{
				return 1 / arg.current ;
				//throw new NotImplementedException();
			}
		}

		public  void moveNext()
		{
			arg.moveNext();
			//throw new NotImplementedException();
		}
	}
}
