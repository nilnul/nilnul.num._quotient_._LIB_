using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.stream.buffered
{
	public class Series
		:
		nilnul.obj.Box<Buffered>
	{
		public List<nilnul.num.Quotient1> buffer {
			get {
				return boxed.buffer;
			}
		}

		private Q1 _accumulated = 0;
		public Q1 accumulated
		{
			get
			{
				return _accumulated;
			}
		}

		public Series(Buffered holdable):base(holdable)
		{
		}

		public Series(StreamI6 stream, int c)
			:this(new Buffered(stream,c))
		{
		}

		public void move()
		{
			_accumulated += buffer.First();
			boxed.move();
			//throw new NotImplementedException();
		}
	}
}
