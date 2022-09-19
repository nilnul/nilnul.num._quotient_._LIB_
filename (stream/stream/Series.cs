using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.obj._slider_;
using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream
{
	public class Series1:
		nilnul.obj.Box<StreamI6>
		,
		SeriesI1
		,
		nilnul.num.quotient.SliderI2
		,StreamI6
	{

		public Series1(StreamI6 stream):base(stream)
		{


		}
		public Series1(nilnul.num.quotient.SliderI2 slider)
			:this( new nilnul.num.quotient.stream_.Slider1(slider))
		{

		}

		private Q1 _current=0;
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
			_current += (boxed as nilnul.obj._stream_.NextI<nilnul.num.Quotient1>).next();
			//throw new NotImplementedException();
		}

		public Q1 next()
		{
			var old = _current;
			moveNext();
			return old;
		}
	}
}
