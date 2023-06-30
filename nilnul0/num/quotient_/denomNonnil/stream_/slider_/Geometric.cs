using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q1 = nilnul.num.quotient_.DenomNonnil;//.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient_.denomNonnil.stream_.slider_
{
	public class Geometric :
		num.quotient_.denomNonnil.stream_. SliderA
		
	{
		private Q1 _current;
		private Q1 _rate;

		public Geometric(Q1 head, Q1 rate)
		{
			_current = head;
			_rate = rate;
		}

		public override Q1 current
		{
			get
			{
				return _current;			}
		}

	

		public Q1 multiplier
		{
			get
			{
				return _rate;
				//throw new NotImplementedException();
			}
		}

		public override void moveNext()
		{
			_current *= _rate;
			//throw new NotImplementedException();
		}

		public void setIndex(Num1 num)
		{
			_current = nilnul.num.quotient.of_.unary_._PonentX.AsDenomNonnil(_rate, num);
			//throw new NotImplementedException();
		}

		public void moveNext(Num1 num)
		{
			_current *= nilnul.num.quotient.of_.unary_._PonentX.AsDenomNonnil(_rate, num);
			//throw new NotImplementedException();
		}
	}
}
