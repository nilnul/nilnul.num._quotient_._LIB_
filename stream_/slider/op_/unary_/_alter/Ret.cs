using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q0 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.stream_.slider.op_.unary_._alter
{
	public class Ret : nilnul.num.quotient.stream_.slider._call.ArgA
		,num.quotient.stream_.SliderI1
	{
		public Ret(SliderI1 arg) : base(arg)
		{
			_alter = new bit.stream_.slider_.alter_.OneNil();
		}

		private nilnul.bit.stream_.slider_.Alter _alter;

		public nilnul.bit.stream_.slider_.Alter alter
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

		public Q0 next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);
		}
	}

	public class Ret_ofNew<T> : Ret
		where T : num.quotient.stream_.SliderI1, new()
	{
		public Ret_ofNew() : base(new T())
		{
		}
	}
}
