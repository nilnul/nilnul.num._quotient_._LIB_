using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q0 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.stream_.slider
{
	public class MemPrev : num.quotient.stream_.slider._calc.ArgA

	{
		public MemPrev(num.quotient.stream_.SliderI1 arg) : base(arg)
		{
			moveNext();

		}

		num.Quotient1 _prev;
		public num.Quotient1 prev {
			get { return _prev; }
		}
		public override Q0 current => arg.current;

		public override void moveNext()
		{
			_prev=arg.current;
			arg.moveNext();
		}
	}

	public class MemPrev_ofNew<T> :
		MemPrev
		where T : num.quotient.stream_.SliderI1, new()
	{
		public MemPrev_ofNew() : base(new T())
		{
		}

	}



}
