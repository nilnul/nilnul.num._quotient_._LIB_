using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.slider
{
	public class Prepended : num.quotient.stream_.slider._calc.ArgA
	{
		public Prepended(SliderI1 arg, num.Quotient1 prepended) : base(arg)
		{
			_current = prepended;
		}

		public Prepended(SliderI1 arg):this(arg,0)
		{

		}

		num.Quotient1 _current;



		public override Quotient1 current => _current;

		public override void moveNext()
		{
			_current = arg.current;
			arg.moveNext();
			//throw new NotImplementedException();
		}
	}
}
