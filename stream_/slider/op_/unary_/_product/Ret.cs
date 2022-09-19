using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider.op_.unary_._product
{
	public class Ret : nilnul.num.quotient.slider.op_._unary.RetA
	{
		public Ret(SliderI1 arg) : base(arg)
		{
		}

		private nilnul.bit.slider_.Alter _alter;

		public nilnul.bit.slider_.Alter alter
		{
			get { return _alter; }
			//set { _alter = value; }
		}

		public override Simplify.Ed1 current
		{
			get
			{
				return _alter.current ? arg.current : -arg.current;
				//throw new NotImplementedException();
			}
		}

		public override void moveNext()
		{
			_alter.moveNext();
			arg.moveNext();
			//throw new NotImplementedException();
		}
	}
}
