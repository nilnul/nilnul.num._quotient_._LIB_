using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.quotient.stream
{
	public class Buffered : nilnul.obj.stream.Buffered<nilnul.num.Quotient1>
	{
		public Buffered(StreamI2<Quotient1> val, int count) : base(val, count)
		{
		}

	}
}
