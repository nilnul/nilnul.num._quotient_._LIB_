using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider.op_.uni_._alter
{
	[Obsolete()]
	public class Ret : nilnul.num.quotient.slider.op_._uni.RetA
	{
		public Ret(SliderI arg) : base(arg)
		{
			_alter = new bit.slider_.Alter(true);
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
