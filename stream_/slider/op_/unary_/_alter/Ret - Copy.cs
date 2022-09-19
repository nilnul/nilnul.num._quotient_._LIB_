using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q0 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.slider.op_.unary_._alter
{
	[Obsolete()]
	public class Ret : nilnul.num.quotient.slider._call.ArgA
		,SliderI2
	{
		public Ret(SliderI2 arg) : base(arg)
		{
			_alter = new bit.slider_.Alter(true);
		}

		private nilnul.bit.slider_.Alter _alter;

		public nilnul.bit.slider_.Alter alter
		{
			get { return _alter; }
			//set { _alter = value; }
		}

		public  Quotient1 current
		{
			get
			{
				return _alter.current ? arg.current : -arg.current;
				//throw new NotImplementedException();
			}
		}

		public  void moveNext()
		{
			_alter.moveNext();
			arg.moveNext();
			//throw new NotImplementedException();
		}
	}
}
