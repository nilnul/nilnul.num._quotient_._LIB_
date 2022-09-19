using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider.convert_._skip
{
	public class Ret :
		slider._convert.RetA
		,
		
		SliderI
	{
		private int _skipped;

		public int skipped
		{
			get { return _skipped; }
			//set { _skipped = value; }
		}

		


		public Ret(int skipped,  SliderI arg  )
			:base(arg)
		{
			_skipped = skipped;
			for (int i = 0; i < _skipped; i++)
			{
				this.arg.moveNext();
			}
		}
		public override Simplify.Ed1 current
		{
			get
			{
				return arg.current;
				//throw new NotImplementedException();
			}
		}

		public override void moveNext()
		{
			arg.moveNext();
			//throw new NotImplementedException();
		}
	}
}
