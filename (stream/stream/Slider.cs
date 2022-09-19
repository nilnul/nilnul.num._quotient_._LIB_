using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
//using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream
{
	public class Slider1
		:nilnul.num.quotient.SliderI2
	{
		private StreamI6 _stream;

		public StreamI6 stream
		{
			get { return _stream; }
		//	set { _stream = value; }
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

		public Slider1(StreamI6 stream)
		{
			_stream = stream;
			moveNext();

			//_current = _stream.next();
		}

		public void moveNext()
		{
			_current = (_stream ).next();

			//throw new NotImplementedException();
		}

		public override string ToString()
		{
			return $"current:{_current}";
		}
	}
}
