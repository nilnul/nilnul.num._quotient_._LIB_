using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.stream_.slider_;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.slider_
{
	public class Repeater : SliderI2
		,
		_FuncI

	{
		public Repeater(Q1 q)
		{
			_current = q;
		}
		private Q1 _current;
		public Q1 current
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

		public void setIndex(nilnul.Num1 num)
		{
			
		}

		public void moveNext(nilnul.Num1 num)
		{
			
		}
	}
}
