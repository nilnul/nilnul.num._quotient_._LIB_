using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.QuotientI;

namespace nilnul.num.quotient
{
	public interface StreamI7
		:
		nilnul.obj._stream_.NextI<Q1>
	{

	}

	public abstract class StreamA7 : StreamI7
	{
		public abstract Q1 next();
		public nilnul.num.Quotient1 nextAsClass()
		{
			return new Quotient1(next());
		}
	}

	public class Stream7 : StreamA7
	{
		private StreamI7 _boxed;

		public StreamI7 boxed
		{
			get { return _boxed; }
			set { _boxed = value; }
		}

		public Stream7(StreamI7 stream)
		{
			_boxed = boxed;
		}
		public override Q1 next()
		{
			return _boxed.next();
		}
	}

}
