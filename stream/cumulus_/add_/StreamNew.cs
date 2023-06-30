using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream.cumulus_.add_
{
	public class StreamNew<TStream>
		: num.quotient.stream.cumulus_.Add
		where TStream:num.quotient.StreamI6,new()
	{
		public StreamNew() : base(new TStream())
		{
		}
	}
}
