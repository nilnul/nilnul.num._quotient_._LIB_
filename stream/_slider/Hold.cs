using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream
{
	[Obsolete()]
	public class Holdable
		:nilnul.num.quotient._stream_.InitedI
	{
		private StreamI3 _stream;

		public StreamI3 stream
		{
			get { return _stream; }
		//	set { _stream = value; }
		}

		private Q1 _current;

		public Q1 accumulated
		{
			get { return _current; }
			//set { current = value; }
		}


		public Holdable(StreamI3 stream)
		{
			_stream = stream;
			moveNext();

			//_current = _stream.next();
		}

		public void moveNext()
		{
			_current = _stream.next();

			//throw new NotImplementedException();
		}

		public override string ToString()
		{
			return $"current:{_current}";
		}
	}
}
